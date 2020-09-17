using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace ClothingStore.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForUpdateDto, Product>();
        }
    }
}