using System;
using Volo.Abp.Application.Services;
using ABC.TeachOnline.Dtos;
using Volo.Abp.Application.Dtos;

namespace ABC.TeachOnline.Users
{
    public interface IBaseMenuAppService:ICrudAppService<BaseMenuDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBaseMenuDto>
    {
   
    }
}

