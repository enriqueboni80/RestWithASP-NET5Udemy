using System.Collections.Generic;
using RestWithAPSNETUdemy.Model;
using RestWithAPSNETUdemy.Repository.Implementations;

namespace RestWithAPSNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {

        private IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
