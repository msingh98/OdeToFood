using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Models
{
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisinType Cuisine { get; set; }
    } 
}
