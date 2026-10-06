using CalculateurAge.View;
using CalculateurAge.View;

namespace CalculateurAge;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Déclare la route
        Routing.RegisterRoute(nameof(ResultatPages), typeof(ResultatPages));
    }
}