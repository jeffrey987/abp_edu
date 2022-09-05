using ABC.TeachOnline.Books;
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
        }
    }
}
