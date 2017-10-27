namespace IFEN.CSharp.TestePratico.Data
{
    public interface IDataContext : IUnitOfWork
    {
        IRepository<Model.ComsCargo> ComsCargo { get; }
        IRepository<Model.Produto> Produto { get; }
        IRepository<Model.Usuario> Usuario { get; }
        IRepository<Model.Venda> Venda { get; }
    }
}
