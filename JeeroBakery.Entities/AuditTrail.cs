using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBakery.Entities
{
    public class AuditTrail : BaseEntity
    {
        /// <summary>
        /// The record id
        /// </summary>
        public int EntityId { get; set; }
        /// <summary>
        /// Name of the model e.g. Product, Category ...
        /// </summary>
        public string EntityName { get; set; }
        /// <summary>
        /// Create, Edit, Delete
        /// </summary>
        public ChangeType Type { get; set; }
        /// <summary>
        /// JSON representation of the Entities previous object graph
        /// </summary>
        public string Before { get; set; }
        /// <summary>
        /// JSON representation of the Entities final object graph
        /// </summary>
        public string After { get; set; }
    }
}
