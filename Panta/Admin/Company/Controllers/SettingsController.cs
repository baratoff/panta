using AutoMapper;
using Microsoft.AspNet.Identity;
using Panta.Admin.Company.Models;
using Panta.Admin.Company.ViewModels;
using Panta.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panta.Admin.Company.Controllers
{
    [Authorize]
    public class SettingsController : Controller
    {       
        // GET: Settings
        public ActionResult Settings()
        {
            ViewBag.Title = "Settings"; 
            Guid companyId = Guid.Parse("62A4EC58-6121-4FFA-AB30-39956CF7F6EB"); //User.Identity.GetCompanyId();
            SettingsDB Dal = new SettingsDB();
            Settings model = Dal.GetSettingsByCompanyId(companyId);
            SettingViewModel viewModel = Mapper.Map<Settings, SettingViewModel>(model);

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Settings(SettingViewModel viewModel)
        {
            ViewBag.Title = "Settings";
            Settings model = AutoMapper.Mapper.Map<SettingViewModel, Settings>(viewModel);

            SettingsDB Dal = new SettingsDB();
            Dal.Create(model);

            return View(viewModel);
        }

        //[HttpGet]
        //public ActionResult Edit(Guid companyId)
        //{
        //    SettingsDB Dal = new SettingsDB();
        //    Settings model = Dal.GetSettingsByCompanyId(companyId);
        //    SettingViewModel viewModel = Mapper.Map<Settings, SettingViewModel>(model);

        //    return View("details", viewModel);
        //}

        [HttpPost]
        public ActionResult Edit(SettingViewModel viewModel)
        {
            Settings model = AutoMapper.Mapper.Map<SettingViewModel, Settings>(viewModel);
            SettingsDB Dal = new SettingsDB();
            Dal.Edit(model);
            return View("details", viewModel);
        }
    }    
}