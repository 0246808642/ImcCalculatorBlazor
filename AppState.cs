using Imc.Models;

namespace Imc;

public static class AppState
{
    public static List<ImcModel> History { get; set; } = new();

    // Inicializado com delegate vazio para evitar null
    public static event EventHandler<EventArgs> OnChanged = delegate { };

    public static void NotifyChanged(object? sender, EventArgs e)
    {
        OnChanged(sender, e);
    }
}