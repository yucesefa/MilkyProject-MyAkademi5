﻿namespace MilkyProject.WebUI.Dtos.Testimonial
{
    public class CreateTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
