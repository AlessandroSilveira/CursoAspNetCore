using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CursoAspNetCore.Infra.Data.Repository
{
	public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private DbContextOptionsBuilder<CursoAspNetCoreContext> _OptionsBuilder;

		public RepositoryBase()
		{
			_OptionsBuilder = new DbContextOptionsBuilder<CursoAspNetCoreContext>();
		}

		public TEntity Add(TEntity obj)
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				banco.Add(obj);
				SaveChanges();
			}
			return obj;
		}

		public virtual TEntity GetById(Guid id)
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				return banco.Set<TEntity>().Find(id);
			}
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				return banco.Set<TEntity>().ToList();

			}
		}

		public virtual TEntity Update(TEntity obj)
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				banco.Update(obj);
				SaveChanges();
			}
			return obj;
		}

		public virtual void Remove(Guid id)
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				var objeto = banco.Set<TEntity>().Find(id);
				banco.Remove(objeto);
				SaveChanges();
			}
		}

		public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
		{
			//return DbSet.Where(predicate);
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				return banco.Set<TEntity>().Where(predicate);
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void Dispose(bool Status)
		{
			if (!Status) return;
		}

		public int SaveChanges()
		{
			using (var banco = new CursoAspNetCoreContext(_OptionsBuilder.Options))
			{
				return banco.SaveChanges();
			}
		}
	}
}