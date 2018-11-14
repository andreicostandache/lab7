using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Poi
    {
        public Poi(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
        public Guid Id { get; private set; }  
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Guid? CityId { get; set; }
        public virtual City City { get; set; }
    }
}

