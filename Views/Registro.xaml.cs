namespace destradaExamen.Views;

public partial class Registro : ContentPage
{
    double costo = 1500.0;
    double porcentajecuota = 0.04;
    public Registro(string user)
	{
		InitializeComponent();
        lbluser.Text = "Usuario Conectado " + user;
        
    }

      private void btnPagomes_Clicked(object sender, EventArgs e)
    {
        
        if (double.TryParse(txtmontoinicial.Text, out double montoInicial))
        {
            if (montoInicial >= 1 && montoInicial <= costo)
            {
                double montofaltante = costo - montoInicial;

                double montoCuota = (montofaltante / 4) * (1 + porcentajecuota);

                txtpagomes.Text =$"{montoCuota}";
            }
            else
            {
                txtpagomes.Text = "El monto inicial debe estar entre 1 y 1500.";
            }
        }
        else
        {
            txtpagomes.Text = "Por favor, ingrese un monto válido.";
        }
         
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        int monto = int.Parse(txtmontoinicial.Text);
        string fecha = dFechas.Date.ToString();
        string pais = pkpais.Items[pkpais.SelectedIndex].ToString();
        string ciudad = pkciudades.Items[pkciudades.SelectedIndex].ToString();
        double montofaltante = costo - monto;
        double pagoMensual = (montofaltante / 4) * (1 + porcentajecuota);
        Navigation.PushAsync(new Resumen(txtnombre.Text, txtapellido.Text, txtedad.Text, fecha, pais, ciudad, monto, pagoMensual));
    }

}
