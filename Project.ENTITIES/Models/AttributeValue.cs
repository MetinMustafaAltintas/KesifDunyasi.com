﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AttributeValue
    {
        public string Value { get; set; }
        public int ProductAttributeID { get; set; }

        //Relational Properties
        public ProductAttribute ProductAttribute { get; set; }
    }
}
