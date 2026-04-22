using RCA.BitacoraCamiones.Data;
using RCA.BitacoraCamiones.Models;

public partial class TestPage : ContentPage
{
    private readonly DatabaseService _db;
    private IngresoRepository? _repo;

    public TestPage(DatabaseService db)
    {
        _db = db;

        InitDB();

        Content = new VerticalStackLayout
        {
            Padding = 40,
            Children =
        {
            new Label { Text = "BITÁCORA CAMIONES", FontSize = 30 },

            new Button
            {
                Text = "Insertar",
                Command = new Command(async () =>
                {
                    if (_repo == null)
                    {
                        await DisplayAlertAsync("Error", "DB no lista", "OK");
                        return;
                    }

                    var ingreso = new Ingreso
                    {
                        ING_Placa = "ABC123",
                        ING_Conductor = "Prueba",
                        ING_Fecha = DateTime.Now,
                        ING_SyncStatus = "Pending"
                    };

                    await _repo.Save(ingreso);
                    await DisplayAlertAsync("OK", "Guardado", "OK");
                })
            },

            new Button
            {
                Text = "Ver",
                Command = new Command(async () =>
                {
                    if (_repo == null)
                    {
                        await DisplayAlertAsync("Error", "DB no lista", "OK");
                        return;
                    }

                    var lista = await _repo.GetAll();

                    string resultado = string.Join("\n",
                        lista.Select(x => $"{x.ING_Placa} - {x.ING_SyncStatus}")
                    );

                    await DisplayAlertAsync("Datos", resultado, "OK");
                })
            }
        }
        };
    }
}