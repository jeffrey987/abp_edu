using ABC.TeachOnline.Books;
using ABC.TeachOnline.Dtos;
using ABC.TeachOnline.Users;
using AutoMapper;

namespace ABC.TeachOnline
{
    public class TeachOnlineApplicationAutoMapperProfile : Profile
    {
        public TeachOnlineApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
            CreateMap<User, UserDto>();
            CreateMap<CreateUpdateUserDto, User>();
            CreateMap<Apis, ApiDto>();
            CreateMap<CreateUpdateApiDto, Apis>();
            CreateMap<BaseMenus, BaseMenuDto>();
            CreateMap<CreateUpdateBaseMenuDto, BaseMenus>();

        }
    }
}
