﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.Admin.Company.ViewModels
{
    public class CompanyViewModel
    {
        public string Name { get; set; }
        public int CVR { get; set; }
        public int VATNumber { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
    }
}