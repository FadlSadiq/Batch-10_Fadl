using AutoMapper;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<BrandDTO, Brand>().ReverseMap();
        CreateMap<FactoryDTO, Factory>().ReverseMap();
        CreateMap<TypeDTO, Type>().ReverseMap();
    }
}