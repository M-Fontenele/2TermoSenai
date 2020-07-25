using System;
using System.IO;
using WSTowers.Repository;
using WSTowers.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers
{
    public partial class App : Application
    {
        static UsuarioRepository database;
        public static UsuarioRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UsuarioRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuario.db3"));
                }

                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new SplashView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
