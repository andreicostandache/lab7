using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Poi
    {
        public Poi( string description)
        {
            Id = Guid.NewGuid();
            Description = description;
        }
        public Guid Id { get; private set; }  
        public string Description { get; private set; }
        public Guid? CityId { get; set; }
        public virtual City City { get; set; }
    }
}

