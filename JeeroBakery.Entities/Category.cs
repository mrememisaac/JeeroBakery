using System.Collections.Generic;

namespace JeeroBakery.Entities
{
    /// <summary>
    /// For this bakery, the categories will be bread, cake, pie ...
    /// </summary>
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}