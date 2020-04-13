using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Extensions;
using RestAPI.Resources;


namespace RestAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>();

            CreateMap<Sepet, SepetResource>();

            CreateMap<Siparis, SiparisResource>();

            CreateMap<Slider, SliderResource>();

            CreateMap<User, UserResource>();

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
            CreateMap<QueryResult<Sepet>, QueryResultResource<SepetResource>>();
            CreateMap<QueryResult<Siparis>, QueryResultResource<SiparisResource>>();
        }
    }
}
