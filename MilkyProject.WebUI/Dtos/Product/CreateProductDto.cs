namespace MilkyProject.WebUI.Dtos.Product
{
    public class CreateProductDto
    {
        public int productid { get; set; }
        public string? productName { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public string? imageUrl { get; set; }
        public bool status { get; set; }
        public int? categoryid { get; set; }
    }
}
