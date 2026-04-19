# Sincronización

## Estados
- Pending: Registro creado sin sincronizar
- Synced: Registro sincronizado
- Error: Fallo en sincronización

## Flujo

1. Usuario crea ingreso
2. Se guarda en SQLite
3. Estado = Pending
4. Sistema detecta conexión
5. Envía datos a API
6. Actualiza estado a Synced
