using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Adapter.II
{
    public class DbPeopleServiceAdapter : IPeopleService
    {
        private readonly DbService dbService;

        public DbPeopleServiceAdapter(DbService dbService)
        {
            this.dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {
            return dbService.Read().Select(x => new Person { Name = $"{x.LastName} {x.FirstName}", Age = (DateTime.Now.Year - x.BirthDate.Year) });
        }
    }
}
