using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABC.TeachOnline
{
    public interface IApi2Service : ICrudAppService<ApiDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateApiDto>
    {
    
    }
}

