using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    interface ICityRepository
    {
        IEnumerable<City> GetCity();
        TEntity GetCityByID<TEntity>(int cityId) where TEntity : class;
        void InsertCity<TEntity>(TEntity cityId) where TEntity : class;
        void DeleteCity<TEntity>(int cityId) where TEntity : class;
        void UpdateCity<TEntity>(TEntity cityId) where TEntity : class;
        void Save();
    }
}
