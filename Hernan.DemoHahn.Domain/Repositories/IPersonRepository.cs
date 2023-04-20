using Hernan.DemoHahn.Domain.Entities;
using Hernan.DemoHahn.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.DemoHahn.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonById(PersonId Id);
        Task AddPerson(Person person);
    }
}
