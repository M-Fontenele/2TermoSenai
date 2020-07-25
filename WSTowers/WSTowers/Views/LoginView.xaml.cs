using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                var user = txtUsuario.Text ?? "";

                if (!string.IsNullOrEmpty(user) && user.Length >= 4)
                {
                    var usuarios = await App.Database.GetUsuarioAsync();

                    var usuario = usuarios.Where(p => p.User == user && p.Senha != "").FirstOrDefault();

                    if (usuario != null)
                    {
                        // Coloque aq a nevegação pra tela principal
                        App.Database.usuario(usuario);
                        App.Current.MainPage = new PrincipalView();
                    }
                    else
                    {
                        await DisplayAlert("", "Usuario ou senha incorretos", "OK");
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        private void BtnCadastro_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CadastroView();
        }
    }
}