namespace rfeijooEP.Vistas;

public partial class RegistroPage : ContentPage
{
	public RegistroPage(string user)
	{
		InitializeComponent();
        DisplayAlert("Bienvenido ", user, "Aceptar");
           lbluser.Text = "Usuario Conectado: " + user;
    }

    private void btnCalculate_Clicked(object sender, EventArgs e)
    {
        double monto = Convert.ToDouble(txtmonto.Text);
        double residuo = 3000 - monto;
        double cuota = residuo / 3;
        double valorfinal = cuota + (3000*0.05);
    }

    private void btnResume_Clicked(object sender, EventArgs e)
    {

    }
}