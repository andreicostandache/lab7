using System;

namespace DataLayer
{
    public class City
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public City(string description)
        {
            this.Description = description;
        }
    }
}
