using OL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.AplicationServices.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }

        public BookDto() { }

        public BookDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            ISBN = book.ISBN;
            Price = book.Price;
        }
       
        
    }
}
