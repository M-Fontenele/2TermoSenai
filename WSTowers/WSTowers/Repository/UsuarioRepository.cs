using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;

namespace WSTowers.Repository
{
    public class UsuarioRepository
    {
        readonly SQLiteAsyncConnection _database;
        Usuario usuarioLogado;

        public UsuarioRepository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
        }

        public void usuario(Usuario u)
        {
            usuarioLogado = u;
        }

        public Usuario buscar()
        {
            return usuarioLogado;
        }

        public Task<List<Usuario>> GetUsuarioAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }
    }
}
