namespace destradaExamen.Views;

public partial class Login : ContentPage
{
    string[,] datos = { { "estudiante", "uisrael" }, { "moviles", "2024" } };
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string user = txtusuario.Text;
        string password = txtcontrasena.Text;
        bool acceso = false;

        for (int i = 0; i < datos.GetLength(1); i++)
        {
            if (datos[0, i] == user && datos[1, i] == password)
            {
                acceso = true;
                Navigation.PushAsync(new Registro(user));
                DisplayAlert("Bienvendio", "Holii " + user, "Cerrar");
                break;
            }
        }
        if (!acceso)
        {
            DisplayAlert("Error", "usuario/Contrasena Incorrectos", "Cerrar");
        }
    }
}
    