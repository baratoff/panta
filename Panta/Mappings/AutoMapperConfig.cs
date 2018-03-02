using AutoMapper;
using Panta.Admin.Company.Models;
using Panta.Admin.Company.ViewModels;
using Panta.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModels>();
                x.AddProfile<ViewModelsToDomain>();
            });
        }
    }
}