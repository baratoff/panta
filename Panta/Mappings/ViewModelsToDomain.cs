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
    public class ViewModelsToDomain : Profile
    {
        public override string ProfileName { get { return "ViewModelsToDomain"; } }

        public ViewModelsToDomain()
        {
            CreateMap<SettingViewModel, Settings>();
            CreateMap<ResourceViewModel, Recource>();
        }

    }
}