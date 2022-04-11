using System;

namespace AN.Data.Models
{
    public sealed class Department : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CityId { get; set; }
        public City City { get; set; }
    }
}
