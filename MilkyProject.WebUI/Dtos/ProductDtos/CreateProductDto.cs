﻿namespace MilkyProject.WebUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string productName { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public string imageUrl { get; set; }
        public bool status { get; set; }
    }
}
