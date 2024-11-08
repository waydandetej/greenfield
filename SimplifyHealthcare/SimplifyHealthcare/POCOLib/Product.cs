﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOLib
    
  
{
    [Serializable]
    public class Product
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }

    }
}
