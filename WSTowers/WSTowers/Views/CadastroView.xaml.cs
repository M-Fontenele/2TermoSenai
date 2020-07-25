using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginView();
        }

        private async void btnCadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    if (txtUsuario.Text.Length >= 5)
                    {
                        if (txtSenha.Text == txtRepSenha.Text)
                        {
                            await App.Database.SaveUsuarioAsync(new Usuario
                            {
                                User = txtUsuario.Text,
                                Email = txtEmail.Text,
                                Senha = txtSenha.Text,
                            });
                            txtUsuario.Text = txtSenha.Text = string.Empty;

                            await DisplayAlert("SUCESSO", "Usuário cadastrado com sucesso. Volte a tela de login e logue-se", "OK");
                        }
                        else
                        {
                            await DisplayAlert("ATENÇÂO", "Senhas diferentes", "OK");
                        }
                    }
                    else
                    {
                        await DisplayAlert("ATENÇÃO", "O nome do usuáio deve possuir mais de 5 caracteres.", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("ATENÇÃO", "Informe o nome do usuário.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Ocorreu um erro desconhecido.", "OK");
            }
        }
    }
}