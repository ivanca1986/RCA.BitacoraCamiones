using RCA.BitacoraCamiones.Data;


namespace RCA.BitacoraCamiones;

public partial class App : Application
{
    private readonly DatabaseService _db;

    public App(DatabaseService db) // 🔥 ahora usa DI
    {
        InitializeComponent();
        _db = db;

        InitDatabase(); // 🔥 inicializa DB al arrancar
    }

    private async void InitDatabase()
    {
        try
        {
            await _db.Init();
            Console.WriteLine("DB inicializada desde App ✔");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"DB ERROR: {ex.Message}");
        }
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new TestPage(_db));
    }
}