using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SmartParking.Server.DAL.EFCore;

namespace SmartParking.Server.Service
{
    public class BaseService : IBaseService, IDisposable
    {
        protected EFCoreContext context { get; private set; }

        public BaseService(IEFContext ef)
        {
            this.context = ef.CreateDBContext();
        }


        public void Commit()
        {
            context.SaveChanges(true);
        }

        public void Delete<T>(int Id) where T : class
        {
            T t = Find<T>(Id);
            if (t != null)
            {
                Delete<T>(t);
            }
        }

        public void Delete<T>(T t) where T : class
        {
            context.Set<T>().Attach(t);
            context.Set<T>().Remove(t);
            Commit();
        }

        public void Delete<T>(IEnumerable<T> tList) where T : class
        {
            context.Set<T>().AttachRange(tList);
            context.Set<T>().RemoveRange(tList);
            Commit();
        }

        public T Find<T>(int id) where T : class
        {
            return context.Set<T>().Find(id);
        }

        public T Insert<T>(T t) where T : class
        {
            context.Set<T>().Add(t);
            Commit();
            return t;
        }

        public IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class
        {
            context.AddRange(tList);
            Commit();
            return tList;
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> funcWhere) where T : class
        {
            return context.Set<T>().Where(funcWhere);
        }

        public void Update<T>(T t) where T : class
        {
            context.Set<T>().Attach(t);
            //context.Update<T>(t);
            context.Entry<T>(t).State = EntityState.Modified;
            Commit();
        }

        public void Update<T>(IEnumerable<T> tList) where T : class
        {
            context.Set<T>().AttachRange(tList);
            //context.UpdateRange(tList);
            foreach (var t in tList)
            {
                context.Entry<T>(t).State = EntityState.Modified;
            }
            Commit();
        }

        public virtual void Dispose()
        {
            context?.Dispose();
        }
    }
}
