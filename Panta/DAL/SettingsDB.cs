using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panta.Admin.Company.Models;
using Panta.Models;

namespace Panta.DAL
{
    public class SettingsDB
    {
        internal void Create(Settings model)
        {
            model.Id = Guid.NewGuid();

            using (var DB = new ApplicationDbContext())
            {
                DB.Settings.Add(model);
                DB.SaveChanges();
            }
        }
        
        internal void Edit(Settings model)
        {
            using(var DB = new ApplicationDbContext())
            {
                var entity = DB.Settings.FirstOrDefault(settings => settings.Id == model.Id);
                DB.Entry(entity).CurrentValues.SetValues(model);
                DB.SaveChanges();
            }
        }

        internal Settings GetSettingsByCompanyId(Guid companyId)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Settings.FirstOrDefault(settings => settings.Company.ID == companyId);
            }
        }
    }
}