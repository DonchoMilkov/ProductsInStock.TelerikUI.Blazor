﻿using System;

namespace TestTelerikUI.Shared
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        //public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public DateTime DeliveryOn { get; set; }
    }
}
