namespace IFEN.CSharp.TestePratico.Data.Model
{
    public class ComsCargo
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Cargo Cargo { get; set; }
        public decimal PercComsSW { get; set; }
        public decimal PercComsHW { get; set; }
    }
}
