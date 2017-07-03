namespace CursoAspNetCore.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
