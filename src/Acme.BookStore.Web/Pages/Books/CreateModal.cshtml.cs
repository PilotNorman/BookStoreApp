using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.BookStore.Web.Pages.Books
{
    public class CreateModalModel : BookStorePageModel 
        // BookStorePageModel 
        // inherits the PageModel and adds some common properties & methods that 
        // can be used in your page model classes.
    {
        // [BindProperty] attribute on the Book property binds post request data to this property.
        [BindProperty] 
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        // This class simply injects the IBookAppService in the constructor and calls 
        // the CreateAsync method in the OnPostAsync handler.
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}