using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<Advert, AdvertInfoDTO>();
        //eklenenler
        CreateMap<AdvertCreateDTO, Advert>();
        CreateMap<AdvertUpdateDTO, Advert>();

        CreateMap<CategoryCreateDTO,Categories>();
        CreateMap<CategoryUpdateDTO,Categories >();
        //Categories,CategoryInfoDTO yerini kerim değişitridi ve çalıştı..
        CreateMap<Categories,CategoryInfoDTO>();
        CreateMap<Animal, AnimalInfoDTO>();
        CreateMap<AnimalCreateDTO,Animal>();
        CreateMap<AnimalUpdateDTO,Animal>();




    }
}