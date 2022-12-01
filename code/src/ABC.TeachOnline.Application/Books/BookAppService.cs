using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ABC.TeachOnline.Bases;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABC.TeachOnline.Books
{
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {

        private readonly IRepository<Book, Guid> _bookRepository;

        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            _bookRepository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult GetBookCollect()
        {
            var list =  _bookRepository.GetListAsync().Result;

            var result= ObjectMapper.Map<List<Book>, List<BookDto>>(list);
            return BaseResponse.OkWithDetailed<List<BookDto>>(result,"获取成功");
        }

        
    }
}


