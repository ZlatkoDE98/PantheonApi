using AutoMapper;
using PantheonApi.DTOs.Item;
using PantheonApi.DTOs.Subject;
using PantheonApi.Models;

namespace PantheonApi.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ItemDto, THeSetItem>()
            .ForMember(dest => dest.AcIdent, opt => opt.MapFrom(src => src.AcIdent))
            .ForMember(dest => dest.AcName, opt => opt.MapFrom(src => src.AcName))
            .ForMember(dest => dest.AcCode, opt => opt.MapFrom(src => src.AcCode))
            .ForMember(dest => dest.AcCurrency, opt => opt.MapFrom(src => src.AcCurrency))
            .ForMember(dest => dest.AnSalePrice, opt => opt.MapFrom(src => src.AnSalePrice))
            .ForMember(dest => dest.AnRebate, opt => opt.MapFrom(src => src.AnRebate));


        CreateMap<SubjectDto, THeSetSubj>();
            
    }
}
