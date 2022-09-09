using System;
using ABC.TeachOnline.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABC.TeachOnline.Servers
{
    public class Api2Service:
                CrudAppService<
            Apis, //The Book entity
            ApiDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateApiDto>, //Used to create/update a book
        IApi2Service //implement the IBookAppService
    {
        public Api2Service(IRepository<Apis, Guid> repository)
            : base(repository)
        {
        }
    }
}

