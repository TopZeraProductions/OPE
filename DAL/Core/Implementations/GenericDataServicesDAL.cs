using System;
using System.Collections.Generic;
using System.Linq;

using DAL.Core.Contracts;

using Microsoft.EntityFrameworkCore;

namespace DAL.Core.Implementations {

    public class GenericDataServicesDAL<T> : IGenericDataServicesDAL<T> where T : class {

        private readonly DefaultContext _defaultContext;

        protected GenericDataServicesDAL(DefaultContext defaultContext) {
            _defaultContext = defaultContext;
        }

        public virtual IQueryable<T> Query() {
            IQueryable<T> dbQuery = _defaultContext.Ctx.Set<T>();

            return dbQuery;
        }

        public virtual IList<T> GetAll() {
            var dbQuery = this.Query();

            var list = dbQuery.AsNoTracking().ToList();

            return list;
        }

        public virtual IList<T> GetList(Func<T, bool> where) {
            var dbQuery = this.Query();

            var list = dbQuery.AsNoTracking().Where(where).ToList();

            return list;
        }

        public virtual T GetSingle(Func<T, bool> where) {
            T   item    = null;
            var dbQuery = this.Query();

            item = dbQuery.AsNoTracking()         //Don't track any changes for the selected item
                          .FirstOrDefault(where); //Apply where clause

            return item;
        }

        public virtual void Add(params T[] items) {
            foreach (var item in items) {
                _defaultContext.Ctx.Entry(item).State = EntityState.Added;
            }

            _defaultContext.Ctx.SaveChanges();
        }

        public virtual void Update(params T[] items) {
            foreach (var item in items) {
                _defaultContext.Ctx.Entry(item).State = EntityState.Modified;
            }

            _defaultContext.Ctx.SaveChanges();
        }

        public virtual void Remove(params T[] items) {
            using (var db = new DefaultContext()) {
                foreach (var item in items) {
                    _defaultContext.Ctx.Entry(item).State = EntityState.Deleted;
                }

                _defaultContext.Ctx.SaveChanges();
            }
        }

    }

}