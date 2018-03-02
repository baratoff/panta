using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.Admin.Company.Models
{
    public class Company
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int CVR { get; set; }
        public int VATNumber { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastChanged { get; set; }
        public bool IsInActive { get; set; }
        public List<Department> Departments { get; set; }
    }
}