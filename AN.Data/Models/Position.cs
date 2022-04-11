using System;

namespace AN.Data.Models
{
    public sealed class Position : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
