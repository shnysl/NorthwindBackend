using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description  { get; set; }
        //public string Picture { get; set; }
    }
}
