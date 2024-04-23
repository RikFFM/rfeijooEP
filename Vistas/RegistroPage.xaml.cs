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
        double valorfinal = cuota + (3000 * 0.05);
        double valorTotal = monto + (valorfinal * 3);

        txtfin.Text = valorfinal.ToString();

    }

    private async void btnResume_Clicked(object sender, EventArgs e)
    {
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        int edad = Convert.ToInt32(txtedad.Text);
        DateTime fecha = dpDate.Date;
        string pais = pkPais.SelectedItem.ToString();
        string ciudad = pkCiudad.SelectedItem.ToString();
        double montoInicial = Convert.ToDouble(txtmonto.Text);
        double pagoMensual = Convert.ToDouble(txtfin.Text);

        await Navigation.PushAsync(new ResumenPage(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual));
    }

}