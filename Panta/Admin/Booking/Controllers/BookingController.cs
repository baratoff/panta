using AutoMapper;
using Panta.Admin.Booking.Models;
using Panta.Admin.Booking.ViewModels;
using Panta.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panta.Admin.Booking.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateResource()
        {
            ViewBag.Title = "Create Object";

            return View();
        }
        [HttpPost]
        public ActionResult CreateResource(ResourceViewModel viewModel)
        {
            ViewBag.Title = "Create Resource";
            BookingObjectDB DAL = new BookingObjectDB();
            DAL.Create(Mapper.Map<ResourceViewModel, Recource>(viewModel));

            return View("Index");
        }
    }
}