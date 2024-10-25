namespace destradaExamen.Views;

public partial class Registro : ContentPage
{
    string user_global = "";
    public Registro(string user)
	{
		InitializeComponent();
        lbluser.Text = "Usuario Conectado " + user;
        user_global = user;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen(user_global));
    }

    private void btnPagomes_Clicked(object sender, EventArgs e)
    {
        double montoInicial = double.Parse(txtpagomes.Text);
        double pagoMensual = (1500 - montoInicial) / 4 * 1.04; 
       


    }
}