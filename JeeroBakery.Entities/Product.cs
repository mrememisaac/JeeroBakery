using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBakery.Entities
{
    /// <summary>
    /// Represents a product e.g bread
    /// </summary>
    public class Product : BaseEntity
    {
        public Product()
        {
            Pictures = new List<Picture>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Featured { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Picture> Pictures { get; set; }
    }
}
