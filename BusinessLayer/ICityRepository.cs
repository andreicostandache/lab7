using DataLayer;
using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public interface ICityRepository
    {
        void Create(City City);
        void Delete(City CityId);
        City GetById(Guid id);
        IReadOnlyList<City> GetAll();
    }
}
