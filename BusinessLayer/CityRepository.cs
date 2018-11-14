using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CityRepository : ICityRepository
    {
        private readonly CitiesContext _context;

        public CityRepository(CitiesContext context)
        {
            _context = context;
        }

        public void Create(City City)
        {
            _context.Cities.Add(City);
            _context.SaveChanges();
        }
        public void Delete (City CityId)
        {
            if (CityId != null)
            {
                _context.Cities.Remove(CityId);
                
            }
        }
        public City GetById(Guid id)
        {
            return _context.Cities.Find(id);
        }
        public IReadOnlyList<City> GetAll()
        {
            return _context.Cities.ToList();
        }

    }
}
