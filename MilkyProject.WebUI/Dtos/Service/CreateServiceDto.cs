namespace MilkyProject.WebUI.Dtos.Service
{
    public class CreateServiceDto
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
