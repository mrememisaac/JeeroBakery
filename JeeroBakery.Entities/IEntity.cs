﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBakery.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
