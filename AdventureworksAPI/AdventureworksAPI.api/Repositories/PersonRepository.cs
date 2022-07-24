using AdventureworksAPI.api.Data;
using AdventureworksAPI.api.Models.Domain;

namespace AdventureworksAPI.api.Repositories
{
    public class PersonRepository : IPersonrepository
    {
        private readonly AdventurewalksDBContext adventurewalksDBContext;
        public PersonRepository(AdventurewalksDBContext adventurewalksDBContext)
        {
                this.adventurewalksDBContext = adventurewalksDBContext;
        }
        public IEnumerable<mPerson> GetAll()
        {
            return adventurewalksDBContext.Person.ToList();
        }
    }
}
    