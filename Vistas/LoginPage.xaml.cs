namespace rfeijooEP.Vistas;

public partial class LoginPage : ContentPage
{


    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contrasenas = { "uisrael2024", "parcial1", "2024" };
	public LoginPage()
	{
		InitializeComponent();
    
    }
    private void btnAction_Clicked(object sender, EventArgs e)
    {
        string user = this.txtUser.Text;
        string pss = this.txtPasswrd.Text;

       bool credencial =false;
       for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i]==user && contrasenas[i] == pss)
            {
                credencial = true;
                break;
            }
        } 
        if(credencial)
        {
            Navigation.PushAsync(new RegistroPage(user));
        }
        else
        {
            DisplayAlert("Error", "Usuario/Contraseña Incorrecta", "Cerrar");
        }
            
    }

    private void abtAction_Clicked(object sender, EventArgs e)
    {
       
    }
}