using OL.AplicationServices.DTOs;
using OL.AplicationServices;
using OL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.AplicationServices
{
    public class BookStoreManagmentService
    {
        #region
        private readonly BookStoreDbContext _context = new BookStoreDbContext();
        #endregion

        public IEnumerable<BookDto> GetAll()
        {
            return _context.Books.AsNoTracking().AsEnumerable().ToBookDtos();
        }


        public int Save(BookDto bookDto)
        {
            try
            {
                _context.Books.Add(bookDto.ToBookEntity());
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
        
        public int Delete(int id)
        {
            try
            {
                var movie = _context.Books.Find(id);
                if (movie == null)
                    return -1;

                _context.Books.Remove(movie);
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
      
    }
}
