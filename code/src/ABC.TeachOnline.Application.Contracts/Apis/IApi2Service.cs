using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABC.TeachOnline.Books
{
    public interface IApiTestAppService:
            ICrudAppService< //Defines CRUD methods
            ApiDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateApiDto> //Used to create/update a book
    {
        public  Task<IActionResult> GetAllApis();

    
    }
}

