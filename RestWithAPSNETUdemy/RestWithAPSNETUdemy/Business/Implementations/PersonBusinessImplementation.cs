using System.Collections.Generic;
using RestWithAPSNETUdemy.Model;
using RestWithAPSNETUdemy.Repository.Implementations;

namespace RestWithAPSNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {

        private IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
