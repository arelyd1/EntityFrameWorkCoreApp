﻿using System;
using System.Collections.Generic;

namespace UdemyElCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<SaleHistory> SaleHistories
        {
            get; set;
        }
        public DateTime CreatedTime { get; set; }
    }
}
