using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panta.Admin.Company.Models;
using Panta.Models;

namespace Panta.DAL
{
    public class CompanyDB
    {
        internal void Create(Company model)
        {
            model.ID = Guid.NewGuid();

            using (var DB = new ApplicationDbContext())
            {
                DB.Companys.Add(model);
                DB.SaveChanges();
            }
        }

        internal void Edit(Company model)
        {
            using (var DB = new ApplicationDbContext())
            {
                var entity = DB.Companys.FirstOrDefault(company => company.ID == model.ID);
                DB.Entry(entity).CurrentValues.SetValues(model);
                DB.SaveChanges();
            }
        }
    }
}