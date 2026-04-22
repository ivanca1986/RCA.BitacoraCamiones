using SQLite;
using RCA.BitacoraCamiones.Models;

namespace RCA.BitacoraCamiones.Data;

public class IngresoRepository
{
    private readonly SQLiteAsyncConnection _db;

    public IngresoRepository(DatabaseService dbService)
    {
        _db = dbService.GetConnection();
    }

    public async Task Save(Ingreso ingreso)
    {
        await _db.InsertAsync(ingreso);
    }

    public async Task<List<Ingreso>> GetAll()
    {
        return await _db.Table<Ingreso>().ToListAsync();
    }
}