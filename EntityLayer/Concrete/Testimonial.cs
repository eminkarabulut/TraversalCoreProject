using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientComment { get; set; }
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
