using System.Collections.Generic;
using RestWithAPSNETUdemy.Model;

namespace RestWithAPSNETUdemy.Business.Implementations
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long book);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
