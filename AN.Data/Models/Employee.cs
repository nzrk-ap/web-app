using System;
using AN.Data.Models.Enums;

namespace AN.Data.Models
{
    public sealed class Employee : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
    }
}
