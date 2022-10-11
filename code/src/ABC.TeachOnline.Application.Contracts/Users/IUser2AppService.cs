using System;
using ABC.TeachOnline.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABC.TeachOnline
{
    public interface IUser2AppService: ICrudAppService<UserDto,Guid,PagedAndSortedResultRequestDto, CreateUpdateUserDto>
    {

    }
}

