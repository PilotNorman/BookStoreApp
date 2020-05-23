using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.BookStore.Web.Pages.Books
{
    public class EditModalModel : BookStorePageModel
    {
        // [HiddenInput] and [BindProperty] are standard ASP.NET Core MVC attributes. 
        // SupportsGet is used to be able to get Id value from query string parameter of the request.
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;
        
        public EditModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        // In the GetAsync method, we get BookDto from BookAppService and 
        // this is being mapped to the DTO object CreateUpdateBookDto.
        public async Task OnGetAsync()
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Book = ObjectMapper.Map<BookDto, CreateUpdateBookDto>(bookDto);
        }

        // The OnPostAsync uses BookAppService.UpdateAsync() to update the entity.
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(Id, Book);
            return NoContent();
        }
    }
}