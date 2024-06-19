using AutoMapper;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<CategoryDTO, Category>().ReverseMap();
    }
}