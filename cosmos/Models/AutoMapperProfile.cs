using AutoMapper;
using cosmos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosmos.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<IEnumerable<CustomerViewModel>, Customers>();
            CreateMap<IEnumerable<SupplierViewModel>, Suppliers>();
            
        }
    }
}