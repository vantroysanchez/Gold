using Gold.Models;

namespace Gold.Interfaces
{
    public interface IContactTypeService
    {
        Task<IEnumerable<ContactType>> GetAll();
    }
}
