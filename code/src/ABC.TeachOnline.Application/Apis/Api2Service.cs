using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.TeachOnline.Bases;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace ABC.TeachOnline.Books
{
    //[AllowAnonymous]
    public class ApiTestAppService :
        CrudAppService<
            Apis, //The Book entity
            ApiDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateApiDto>, //Used to create/update a book
        IApiTestAppService //implement the IBookAppService

    {
        private readonly IRepository<Apis, Guid> _repository;

        public ApiTestAppService(IRepository<Apis, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// get all 
        /// </summary>
        /// <returns></returns>
        public IList<ApiDto> GetAllApis()
        {
            var list = _repository.GetListAsync().Result;
            return ObjectMapper.Map<List<Apis>, List<ApiDto>>(list);
        }

        // protected async override Task DeleteByIdAsync(Guid id)
        // {
        //     await Repository.DeleteAsync(d => d.Id == id);
        // }

        
    }
}