#!/bin/bash
# Custom entrypoint for SQL Server.
# Starts sqlservr, waits for it to be ready, runs init.sql if the DB is empty,
# then keeps the process in the foreground.

set -e

SA_PASSWORD="${MSSQL_SA_PASSWORD}"
SQLCMD="/opt/mssql-tools18/bin/sqlcmd"
INIT_SCRIPT="/docker-entrypoint-initdb.d/init.sql"

# ── 1. Start SQL Server in the background ──────────────────────────────────
/opt/mssql/bin/sqlservr &
MSSQL_PID=$!

# ── 2. Wait until SQL Server is accepting connections ─────────────────────
echo "[init] Waiting for SQL Server to start..."
for i in $(seq 1 30); do
    if $SQLCMD -S localhost -U sa -P "$SA_PASSWORD" -C -Q "SELECT 1" &>/dev/null; then
        echo "[init] SQL Server is ready (attempt $i)."
        break
    fi
    echo "[init] Attempt $i/30 — not ready yet, retrying in 2s..."
    sleep 2
done

# ── 3. Check whether the database already exists ──────────────────────────
DB_EXISTS=$($SQLCMD -S localhost -U sa -P "$SA_PASSWORD" -C \
    -Q "SET NOCOUNT ON; SELECT COUNT(1) FROM sys.databases WHERE name='MalikaTechMarketDB'" \
    -h -1 2>/dev/null | tr -d '[:space:]')

if [ "$DB_EXISTS" = "0" ] || [ -z "$DB_EXISTS" ]; then
    echo "[init] Database not found — running $INIT_SCRIPT ..."
    $SQLCMD -S localhost -U sa -P "$SA_PASSWORD" -C -i "$INIT_SCRIPT"
    echo "[init] Initialisation complete."
else
    echo "[init] Database already exists — skipping seed."
fi

# ── 4. Hand control back to the SQL Server process ────────────────────────
wait $MSSQL_PID
