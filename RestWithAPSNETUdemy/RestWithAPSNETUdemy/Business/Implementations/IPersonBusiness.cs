using System.Collections.Generic;
using RestWithAPSNETUdemy.Model;

namespace RestWithAPSNETUdemy.Business.Implementations
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
