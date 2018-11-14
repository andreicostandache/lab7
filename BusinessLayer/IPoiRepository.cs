using System;
using System.Collections.Generic;
using DataLayer;

namespace BusinessLayer
{
    public interface IPoiRepository
    {
        void Create(Poi Poi);
        void Delete(Poi PoiId);
        IReadOnlyList<Poi> GetAll();
        Poi GetById(Guid id);
    }
}