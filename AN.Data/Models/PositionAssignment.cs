using System;

namespace AN.Data.Models
{
    public sealed class PositionAssignment : IEntity
    {
        public Guid Id { get; set; }
        public Guid PositionId { get; set; }
        public Position Position { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
