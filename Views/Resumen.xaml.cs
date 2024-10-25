using Microsoft.Maui.Graphics;

namespace destradaExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen(string user, string nombre1, string apellido1, string edad1, string fecha1, string pais1, string ciudad1, double montoInicial, 
        double pagoMensual)
	{
		InitializeComponent();
        lbluser.Text = "Usuario Conectado " + user;
        nombre.Text = nombre1;
        apellido.Text = apellido1;
        edad.Text = edad1;
        fecha.Text = fecha1;
        pais.Text = pais1;
        lblciudad.Text = ciudad1;
        lblmonto.Text = $"{montoInicial}";
        lblpagomes.Text = $"{pagoMensual}";
        lblpagototal.Text = $"{pagoMensual*4+montoInicial}";

    }
}