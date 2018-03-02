using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.Admin.Booking.Models
{
    public class Recource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desctiption { get; set; }
        public Company.Models.Company Company { get; set; }
    }
}