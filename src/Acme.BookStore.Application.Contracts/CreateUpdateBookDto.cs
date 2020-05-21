using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore
{
    // This DTO class is used to get book information from the user interface while 
    // creating or updating a book
    //It defines data annotation attributes (like [Required]) to define validations 
    //for the properties. DTOs are automatically validated by the ABP framework.
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
