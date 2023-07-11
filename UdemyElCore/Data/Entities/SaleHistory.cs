﻿namespace UdemyElCore.Data.Entities
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //Navigation Property
        public Product product { get; set; }
        public int Amount { get; set; }
    }
}
