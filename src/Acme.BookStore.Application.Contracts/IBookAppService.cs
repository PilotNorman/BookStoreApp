using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IBookAppService : ICrudAppService<
        // Defines CRUD methods: GetAsync, GetListAsync, CreateAsync, UpdateAsync and DeleteAsync
        BookDto, // used to show books
        Guid, // Primary key of the book entity
        PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of books
        CreateUpdateBookDto, // Used to create a new book
        CreateUpdateBookDto> // Used to update a book
    {

    }
}
