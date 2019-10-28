using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Core.Contracts
{
    public interface IGenericDataServicesDAL<T> where T : class
    {
        IQueryable<T> Query();

        IList<T> GetAll();

        IList<T> GetList(Func<T, bool> where);

        T GetSingle(Func<T, bool> where);

        void Add(params T[] items);

        void Update(params T[] items);

        void Remove(params T[] items);
    }
}