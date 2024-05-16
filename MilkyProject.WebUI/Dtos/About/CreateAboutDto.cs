namespace MilkyProject.WebUI.Dtos.About
{
    public class CreateAboutDto
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AboutListTitle { get; set; }
        public string AboutListDescription { get; set; }
        public string AboutListIcon { get; set; }
    }
}
