﻿using System.Collections;
using System.Collections.Generic;

namespace FutureMebels.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Articul> Articuls { get; set;}

       
    }
}
