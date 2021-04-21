using OL.AplicationServices.DTOs;
using OL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.AplicationServices
{
    public class ConvertHelper
    {
        public static Book ToBookEntity(BookDto bookDto)
        {
            return new Book
            {
                Id = bookDto.Id,
                Title = bookDto.Title,
                ISBN = bookDto.ISBN,
                Price = bookDto.Price
            };
        }

        public static BookDto ToBookDto(Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                ISBN = book.ISBN,
                Price = book.Price
            };
        }

        public static IEnumerable<BookDto> ToBookDtos(IEnumerable<Book> books)
        {
            return books.Select(x => new BookDto { Id = x.Id, Title = x.Title, ISBN = x.ISBN, Price = x.Price });
        }
    }
}
