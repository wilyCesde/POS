namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        //Declaracion de martricula de nuestra interface a nivel repository..
        ICategoryRepository Category { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
