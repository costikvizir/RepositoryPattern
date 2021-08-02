using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    class CityRepository : ICityRepository
    {
        public List<City> cityList = new List<City>();

        public void DeleteCity<TEntity>(int cityId) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCity()
        {
            throw new NotImplementedException();
        }

        public TEntity GetCityByID<TEntity>(int cityId) where TEntity : class
        {
           
        }

        public void InsertCity<TEntity>(TEntity cityId) where TEntity : class
        {
            
        }

        public void UpdateCity<TEntity>(TEntity cityId) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        
    }
}
