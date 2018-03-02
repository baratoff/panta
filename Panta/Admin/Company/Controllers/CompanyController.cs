using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panta.DAL;
using Panta.Admin.Company.Models;
using Panta.Admin.Company.ViewModels;

namespace Panta.Admin.Company.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Create()
        {
            CompanyViewModel viewModel = new CompanyViewModel();
            return View("Detail", viewModel);
        }

        [HttpPost]
        public ActionResult Create(CompanyViewModel viewModel)
        {
            Panta.Admin.Company.Models.Company model = AutoMapper.Mapper.Map<CompanyViewModel, Panta.Admin.Company.Models.Company>(viewModel);
            CompanyDB Dal = new CompanyDB();
            Dal.Create(model);
            return View("Detail", viewModel);
        }

        [HttpGet]
        public ActionResult Edit(CompanyViewModel viewModel)//nedds to take GUID not model, and need another POST method
        {
            Panta.Admin.Company.Models.Company model = AutoMapper.Mapper.Map<CompanyViewModel, Panta.Admin.Company.Models.Company>(viewModel);
            CompanyDB Dal = new CompanyDB();
            Dal.Edit(model);
            return View("Detail", viewModel);
        }
    }
}