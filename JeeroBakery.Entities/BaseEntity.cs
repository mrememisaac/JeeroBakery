using System;

namespace JeeroBakery.Entities
{
    /// <summary>
    /// Holds fields every entity must have
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        public int Id { get ; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
