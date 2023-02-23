﻿using FutureMebels.Data;
using System;
using System.Collections.Generic;

public class Order
{
    public int Id { get; set; }
    //M : 1
    public int ArticulId { get; set; }
    public Articul Articuls { get; set; }
    // M:1
    public int CustomerId { get; set; }
    public Customer Customers { get; set; }

    public int Quantity { get; set; }

    public DateTime RegisterOn{ get; set; }


}
