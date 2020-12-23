using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBakery.Entities
{
    /// <summary>
    /// Refers to product images on disk
    /// </summary>
    public class Picture : BaseEntity
    {
        /// <summary>
        /// The product this picture belongs to
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Relative path on disk for locating this pic
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Standard or thumbnail
        /// </summary>
        public ImageType Type { get; set; }
        /// <summary>
        /// Picture angle
        /// </summary>
        public ImageView View { get; set; }
    }
}
