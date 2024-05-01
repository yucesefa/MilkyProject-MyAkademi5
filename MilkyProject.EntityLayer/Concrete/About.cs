using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutListTitle { get; set; }
        public string AboutListDescription { get; set; }
        public string AboutListIcon { get; set; }
    }
}
