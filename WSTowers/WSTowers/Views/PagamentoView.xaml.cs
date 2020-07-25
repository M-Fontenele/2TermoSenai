using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagamentoView : ContentPage
    {
        PedidoRepository repository = new PedidoRepository();
        public PagamentoView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Pedido", "Seu pedido está a caminho", "OK");
            repository.limpar();
            App.Current.MainPage = new PrincipalView();
        }
    }
}