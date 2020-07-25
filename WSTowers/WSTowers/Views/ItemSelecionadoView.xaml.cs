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
    public partial class ItemSelecionadoView : ContentPage
    {
        int quant;
        PedidoRepository repository = new PedidoRepository();
        public ItemSelecionadoView()
        {
            InitializeComponent();
            quant = 1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Text == "+")
            {
                quant += 1;
                BtnAdcionar.IsEnabled = true;
                BtnAdcionar.BackgroundColor = Color.FromHex("#E8BB08");
                BtnAdcionar.TextColor = Color.White;
            }
            else if (quant == 0)
            {
                BtnAdcionar.BackgroundColor = Color.Gray;
                BtnAdcionar.TextColor = Color.Black;
                BtnAdcionar.IsEnabled = false;
            }
            else
            {
                quant -= 1;
                if (quant == 0)
                {
                    BtnAdcionar.BackgroundColor = Color.Gray;
                    BtnAdcionar.TextColor = Color.Black;
                    BtnAdcionar.IsEnabled = false;
                }
            }

            LblQuantidade.Text = quant.ToString();
        }

        private async void BtnAdcionar_Clicked(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido
            {
                Nome = LblNome.Text,
                Valor = Convert.ToDecimal(LblValor.Text)
            };

            for (int i = 1; i <= quant ; i++)
            {
                repository.adcionar(pedido);
            }

            await Navigation.PushAsync(new CarrinhoView());
        }
    }
}