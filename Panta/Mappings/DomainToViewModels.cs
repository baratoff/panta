using AutoMapper;
using Panta.Admin.Booking.Models;
using Panta.Admin.Booking.ViewModels;
using Panta.Admin.Company.Models;
using Panta.Admin.Company.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.Mappings
{
    public class DomainToViewModels : Profile
    {
        public override string ProfileName { get { return "DomainToViewModels"; } }
        public DomainToViewModels()
        {
            CreateMap<Settings, SettingViewModel>();
            CreateMap<Recource, ResourceViewModel>();
        }
    }
}