using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OL.AplicationServices;
using OL.AplicationServices.DTOs;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Books" in code, svc and config file together.
public class Books : IBooks
{
    #region
    private readonly BookStoreManagmentService _service = new BookStoreManagmentService();
    #endregion

    public string GetVersion()
    {
        return "Version 1.0";
    }

    public IEnumerable<BookDto> GetBooks()
    {
        return _service.GetAll();
    }

    public int Save(string title)
    {
        return _service.Save(new BookDto { Title = title });
    }

    BookDto IBooks.Save(string Title)
    {
        throw new NotImplementedException();
    }
}
