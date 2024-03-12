﻿namespace PrimeTourOperator.Infrastructure.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public  decimal Price { get; set; }
        public string AdditionalExtras { get; set; }
    }
}