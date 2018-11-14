using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class PoiRepository : IPoiRepository
    {
        private readonly PoisContext _context;

        public PoiRepository(PoisContext context)
        {
            _context = context;
        }

        public void Create(Poi Poi)
        {
            _context.Pois.Add(Poi);
            _context.SaveChanges();
        }
        public void Delete(Poi PoiId)
        {
            if (PoiId != null)
            {
                _context.Pois.Remove(PoiId);

            }
        }
        public Poi GetById(Guid id)
        {
            return _context.Pois.Find(id);
        }
        public IReadOnlyList<Poi> GetAll()
        {
            return _context.Pois.ToList();
        }

    }
}
