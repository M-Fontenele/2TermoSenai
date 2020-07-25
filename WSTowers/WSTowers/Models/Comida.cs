using System;
using System.Collections.Generic;
using System.Text;

namespace WSTowers.Models
{
    class Comida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Img { get; set; }
        public bool Ativo { get; set; }
    }
}
