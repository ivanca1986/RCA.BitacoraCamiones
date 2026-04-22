using RCA.BitacoraCamiones.Data;
using RCA.BitacoraCamiones.Views;

namespace RCA.BitacoraCamiones;

public partial class App : Application
{
    private readonly DatabaseService _db;

    public App()
    {
        InitializeComponent();
        _db = new DatabaseService(); // ✔ solo UNA instancia
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new TestPage(_db));
    }
}