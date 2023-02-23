﻿using System;
using System.Collections.Generic;

namespace FutureMebels.Data
{
    public class Articul
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        public Type Types { get; set; }


        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public string NameModel { get; set; }
       
        public decimal Size { get; set; }

        public string Applied { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }

        public DateTime RegisterOn { get; set; }

        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
