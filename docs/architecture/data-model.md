# Modelo de datos

## Entidades principales

### Ingreso
- ING_Id
- ING_Placa
- ING_Conductor
- ING_Fecha
- ING_SyncStatus

### Foto
- FOT_Id
- ING_Id (FK)
- FOT_RutaLocal
- FOT_UrlNube
- FOT_SyncStatus

## Relaciones
- Un ingreso puede tener múltiples fotos
