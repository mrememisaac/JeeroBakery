using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBakery.Entities
{
    /// <summary>
    /// Keeps track of feature periods for data analysis
    /// so that we can look back and say, pdt x was featured at so so point in time and this is how it affected sales ...
    /// </summary>
    public class FeaturedProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
