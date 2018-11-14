using DataLayer;
using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public interface IRepository
    {
        void Create(City City);
        void Delete(City CityId);
        City GetById(Guid id);
        IReadOnlyList<City> GetAll();
    }
}
