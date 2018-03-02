using Panta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.DAL
{
    public class BookingObjectDB
    {
        internal void Create(Admin.Booking.Models.Recource model)
        {
            model.Id = Guid.NewGuid();

            using (var DB = new ApplicationDbContext())
            {
                DB.BookingObjects.Add(model);
                DB.SaveChanges();
            }
        }
        internal void Edit(Admin.Booking.Models.Recource model)
        {
            model.Id = Guid.NewGuid();

            using (var DB = new ApplicationDbContext())
            {
                var entity = DB.BookingObjects.FirstOrDefault(original => original.Id == model.Id);
                DB.Entry(entity).CurrentValues.SetValues(model);
                DB.SaveChanges();
            }
        }
        internal void Delete(Admin.Booking.Models.Recource model)
        {
            using (var DB = new ApplicationDbContext())
            {
                var entity = DB.BookingObjects.FirstOrDefault(original => original.Id == model.Id);
                DB.BookingObjects.Remove(entity);
                DB.SaveChanges();
            }
        }
    }
}