using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WSTowers.Models;
using WSTowers.Repository;
using WSTowers.Views;

namespace WSTowers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LancheDetailsPage : ContentPage
	{
        Lanche _lanche;
        PedidoRepository repository = new PedidoRepository();

        public LancheDetailsPage (Lanche lanche)
		{
            InitializeComponent();
            _lanche = lanche;
            this.BindingContext = _lanche;
            LblAviso.IsVisible = !_lanche.Ativo;
		}

        async void btnProximo_Clicked(object sender, EventArgs e)
        {
            if(!_lanche.Ativo)
            {
                await DisplayAlert("Aviso", "Desculpe esse item está momentaneamente indisponivel", "OK");
            }
            else
            {
                if (_lanche == null)
                    return;
                string v = _lanche.ValorTotal.Replace("Valor Total: R$ ","");
                Pedido pedido = new Pedido() { Nome = _lanche.Nome, Valor = Convert.ToDecimal(v) };
                repository.adcionar(pedido);

                await this.Navigation.PushAsync(new CarrinhoView());
            }
        }
    }
}