using OL.AplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBooks" in both code and config file together.
[ServiceContract]
public interface IBooks
{
    [OperationContract]
    string GetVersion();

    [OperationContract]
    IEnumerable<BookDto> GetBooks();
    [OperationContract]
    BookDto Save(string Title);
}
