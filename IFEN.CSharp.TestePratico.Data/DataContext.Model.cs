namespace IFEN.CSharp.TestePratico.Data
{
    partial class DataContext
    {
        public IRepository<Model.ComsCargo> ComsCargo
        {
            get { return GetRepository<Model.ComsCargo>(); }
        }
        
        public IRepository<Model.Produto> Produto
        {
            get { return GetRepository<Model.Produto>(); }
        }
        
        public IRepository<Model.Usuario> Usuario
        {
            get { return GetRepository<Model.Usuario>(); }
        }
        
        public IRepository<Model.Venda> Venda
        {
            get { return GetRepository<Model.Venda>(); }
        }
    }
}
