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
    public partial class PrincipalView : MasterDetailPage
    {
        public PrincipalView()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomeView());
            IsPresented = false;
            Usuario u = App.Database.buscar();
            LblUser.Text = u.User;
            LblEmail.Text = u.Email;
            BtnFoto.Text = u.User.Substring(0, 1).ToUpper();

        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomeView());
            IsPresented = false;
        }

        private void btnCarrinho_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CarrinhoView());
            IsPresented = false;
        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginView();
        }
    }
}