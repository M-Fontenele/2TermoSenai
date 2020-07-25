namespace XF_Lanches.Models
{
    public class Acrescimo
    {
        public int AcrescimoId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        //
        public decimal Maionese { get; } = 1.00M;
        public decimal Ovo { get; }
        public decimal Cheddar { get; }
        public decimal Catupiry { get; }
        public decimal Bacon { get; }
    }
}
