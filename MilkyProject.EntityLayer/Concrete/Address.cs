using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string HoursTitle1 { get; set; }
        public string HoursDescription1 { get;}
        public string HoursTitle2 { get; set; }
        public string HoursDescription2 { get;}
        public string HoursTitle3 { get; set; }
        public string HoursDescription3 { get; set; } 
    }
}
