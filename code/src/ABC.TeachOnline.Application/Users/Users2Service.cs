using System;
using ABC.TeachOnline.Books;
using ABC.TeachOnline.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABC.TeachOnline.Servers
{
    public class Users2Service : CrudAppService<User, UserDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUserDto>, IUser2AppService
    {
        public Users2Service(IRepository<User, Guid> repository) : base(repository)
        {

        }
    }
}

