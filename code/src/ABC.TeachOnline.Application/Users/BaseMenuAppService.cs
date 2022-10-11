using System;
using ABC.TeachOnline.Books;
using ABC.TeachOnline.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABC.TeachOnline.Users
{
    public class BaseMenuAppService : CrudAppService
        <BaseMenus,BaseMenuDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateBaseMenuDto>,
        IBaseMenuAppService
    {
        public BaseMenuAppService(IRepository<BaseMenus,Guid> repository):base(repository)
        {

        }
    }
}

