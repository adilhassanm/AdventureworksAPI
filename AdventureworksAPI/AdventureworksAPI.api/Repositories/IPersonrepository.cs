using AdventureworksAPI.api.Models.Domain;

namespace AdventureworksAPI.api.Repositories
{
    public interface IPersonrepository
    {
        IEnumerable<mPerson> GetAll();
    }
}
