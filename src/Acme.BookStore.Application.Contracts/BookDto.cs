using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore
{
    // DTO classes are used to transfer data between the presentation layer and the application layer.
    // BookDto is used to transfer bood data to the presentation layer in order to show the bood 
    // information ont the UI.
    // BookDto is derived from the AuditedEntityDto<Guid> which has audit properties just like 
    // the Book class defined above.
    public class BookDto
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
