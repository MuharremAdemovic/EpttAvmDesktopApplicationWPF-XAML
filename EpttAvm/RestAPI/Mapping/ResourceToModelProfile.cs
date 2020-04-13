using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Resources;


namespace RestAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>();

            CreateMap<SaveSepetResource, Sepet>();

            CreateMap<SaveSiparisResource, Siparis>();

            CreateMap<SaveSliderResource, Slider>();

            CreateMap<SaveUserResource, User>();


            CreateMap<ProductsQueryResource, ProductsQuery>();
            CreateMap<SepetQueryResource, SepetQuery>();
            CreateMap<SiparisQueryResource, SiparisQuery>();
        }
    }
}
