using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;
using WSTowers.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarrinhoView : ContentPage
    {
        PedidoRepository repository = new PedidoRepository();
        decimal valorTotal;
        public CarrinhoView()
        {
            InitializeComponent();

            List<Pedido> pedidos = repository.buscarPedido();

            foreach (var item in pedidos)
            {
                valorTotal += item.Valor;
            }

            LvCarrinho.ItemsSource = pedidos;
            LblTotal.Text = valorTotal.ToString();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new PagamentoView());
        }
    }
}