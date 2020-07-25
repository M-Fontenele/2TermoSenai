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
    public partial class HomeView : ContentPage
    {

        List<Comida> listSearch = new List<Comida>
            {
                new Comida{Id=1,Nome="Cerveja Heineken", Descricao="Premium Pilsen Lager 600ml",Valor=5.30M,Img="cerveja_1.jpg",Ativo=false},
                new Comida{Id=2,Nome= "Cerveja Brahma Retomável", Descricao="Garrafa 300ml",Valor=1.75M,Img="cerveja_2.jpg",Ativo=true},
                new Comida{Id=3,Nome= "Cerveja Budweiser", Descricao="Pilsen 330ml",Valor=3.39M,Img="baseline_menu_white_48dp.png",Ativo=true},
                new Comida{Id=4,Nome="Coca-Cola", Descricao="Refrigerante Coca-Cola Lata 350ml",Valor=6.20M,Img="refrigerante_coca_cola_350ml.png",Ativo=true},
                new Comida{Id=5,Nome= "Fanta Laranja", Descricao="Fanta Laranja Lata 350ml",Valor=5.50M,Img="fanta_Lata.jpg",Ativo=true},
                new Comida{Id=6,Nome= "Fanta Uva", Descricao="Fanta Uva Lata 350ml",Valor=3.39M,Img="fanta_Uva.jpg",Ativo=true},
                new Comida{Id=7,
                            Nome="HotDogão (serve 2 pessoas)",
                            Descricao="Acompanhado com duas salsicha, purê de batata maionese, milho, alface, tomate, batata palha.",
                            Valor=14.49M,
                            Img="hot_dog.jpeg",
                            Ativo=true},
                new Comida{Id=8,Nome="Hambúrguer e um Lanche",
                            Descricao="Hambúrguer acompanhado com dois hambúrguer, duas fatias de queijo, maionese, alface, tomate, molho especial." +
                            "Lanche acompanhado com presunto, queijo, alface, pão de forma.",
                            Valor=24.99M,
                            Img="burguer_2.jpeg",
                            Ativo=true},
                new Comida{Id=9,Nome="Lanche Vegano",
                            Descricao="Acompanhado com molhos feitos de verduras, pão ligth, tomate, açafrão, pepino.",
                            Valor=19.99M,
                            Img="lanche_1.jpeg",
                            Ativo=true},
                new Comida{Id=10,Nome="Misto Quente",
                            Descricao="Acompanhado com queijo, manteiga, presunto.",
                            Valor=21.90M,
                            Img="lanche_2.jpeg",
                            Ativo=true},
                new Comida{Id=11,Nome="Porções",
                            Descricao="Acompanhamento a gosto do cliente",
                            Valor=27.59M,
                            Img="porcao.jpeg",
                            Ativo=false}
            };
        public HomeView()
        {
            InitializeComponent();

            LvBebidas.ItemsSource = new List<Comida>
            {
                new Comida{Id=1,Nome="Cerveja Heineken", Descricao="Premium Pilsen Lager 600ml",Valor=5.30M,Img="cerveja_1.jpg",Ativo=true},
                new Comida{Id=2,Nome= "Cerveja Brahma Retomável", Descricao="Garrafa 300ml",Valor=1.75M,Img="cerveja_2.jpg",Ativo=true},
                new Comida{Id=3,Nome= "Cerveja Budweiser", Descricao="Pilsen 330ml",Valor=3.39M,Img="cerveja_3.jpg",Ativo=true},
                new Comida{Id=4,Nome="Coca-Cola", Descricao="Refrigerante Coca-Cola Lata 350ml",Valor=6.20M,Img="refrigerante_coca_cola_350ml.png",Ativo=true},
                new Comida{Id=5,Nome= "Fanta Laranja", Descricao="Fanta Laranja Lata 350ml",Valor=5.50M,Img="fanta_Lata.jpg",Ativo=true},
                new Comida{Id=6,Nome= "Fanta Uva", Descricao="Fanta Uva Lata 350ml",Valor=3.39M,Img="fanta_Uva.jpg",Ativo=true}
            };

            LvLanches.ItemsSource = new List<Lanche>
            {
                new Lanche{ Nome="HotDogão (serve 2 pessoas)",
                            Descricao="Acompanhado com duas salsicha, purê de batata maionese, milho, alface, tomate, batata palha.",
                            Valor=14.49M,
                            Img="hot_dog.jpeg",
                            Ativo=true},
                new Lanche{Nome="Hambúrguer e um Lanche",
                            Descricao="Hambúrguer acompanhado com dois hambúrguer, duas fatias de queijo, maionese, alface, tomate, molho especial." +
                            "Lanche acompanhado com presunto, queijo, alface, pão de forma.",
                            Valor=24.99M,
                            Img="burguer_2.jpeg",
                            Ativo=true},
                new Lanche{Nome="Lanche Vegano",
                            Descricao="Acompanhado com molhos feitos de verduras, pão ligth, tomate, açafrão, pepino.",
                            Valor=19.99M,
                            Img="lanche_1.jpeg",
                            Ativo=true},
                new Lanche{Nome="Misto Quente",
                            Descricao="Acompanhado com queijo, manteiga, presunto.",
                            Valor=21.90M,
                            Img="lanche_2.jpeg",
                            Ativo=true},
                new Lanche{Nome="Porções",
                            Descricao="Acompanhamento a gosto do cliente",
                            Valor=27.59M,
                            Img="porcao.jpeg",
                            Ativo=false}
            };

            LvConteudo.IsVisible = false;

        }

        private async void LvLanches_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                //var selecionado = e.SelectedItem as Comida;

                //var itemSelecionado = new ItemSelecionadoView();

                //itemSelecionado.BindingContext = selecionado;

                //await this.Navigation.PushAsync(itemSelecionado); 

                var lanche = e.SelectedItem as Lanche;
                //DisplayAlert("Item Selecionado (SelectedItem) ", lanche.Nome, "Ok");
                if (lanche == null)
                    return;

                await this.Navigation.PushAsync(new LancheDetailsPage(lanche));
            }
        }

        private void SearchConteudo_TextChanged(object sender, TextChangedEventArgs e)
        {
            var key = SearchConteudo.Text;
            if(key.Length >=1)
            {
                var conteudo = listSearch.Where(c => c.Nome.ToLower().Contains(key.ToLower()));
                LvConteudo.ItemsSource = conteudo;
                LvConteudo.IsVisible = true;
            }
            else
            {
                LvConteudo.IsVisible = false;
            }
        }


        private async void LvBebidas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var selecionado = e.SelectedItem as Comida;

                var itemSelecionado = new ItemSelecionadoView();

                itemSelecionado.BindingContext = selecionado;

                await this.Navigation.PushAsync(itemSelecionado);
            }
        }

        private async void LvConteudo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecionado = e.SelectedItem as Comida;

            var itemSelecionado = new ItemSelecionadoView();

            itemSelecionado.BindingContext = selecionado;

            await this.Navigation.PushAsync(itemSelecionado);
        }
    }
}