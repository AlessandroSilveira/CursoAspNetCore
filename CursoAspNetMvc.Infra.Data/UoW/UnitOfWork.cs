using System;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetMvc.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CursoAspNetCoreContext _db;
        private bool _disposed;


        public UnitOfWork(CursoAspNetCoreContext db)
        {
            _db = db;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _db.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}