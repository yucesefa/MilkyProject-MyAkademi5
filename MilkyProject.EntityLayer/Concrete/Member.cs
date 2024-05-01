using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string XUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
