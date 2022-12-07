using AutoMapper;
using POS.Aplication.Dtos.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Utilities.Static;

namespace POS.Aplication.Mappers
{
    public class CategoryMappingsProfile : Profile
    {
        public CategoryMappingsProfile()
        {
            //elaboramos mapeos
            CreateMap<Category, CategoryResponseDto>()
              .ForMember(x => x.StateCategory, x => x.MapFrom
              (y => y.State.Equals((int)StateTypes.Active) ? "Active" : "Inactivo"))
              .ReverseMap();

            CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDto>>()
                .ReverseMap();

            CreateMap<CategoryResponseDto, Category>();

            CreateMap<Category, CategoryResponseDto>()
                .ReverseMap();
        }
    }
}
