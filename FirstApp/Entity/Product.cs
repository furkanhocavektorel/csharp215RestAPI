﻿namespace Mvc.Models.Entity
{
    public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public Category CategoryId { get; set; }
        public bool Discontinued { get; set; }
    }
}
