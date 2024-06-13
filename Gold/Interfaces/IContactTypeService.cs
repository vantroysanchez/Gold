using Gold.Common.Models;
using Gold.Dtos;
using Gold.Models;

namespace Gold.Interfaces
{
    public interface IContactTypeService
    {
        Task<IEnumerable<ContactTypeDto>> GetAll();
        Task<PaginatedList<ContactType>> GetAllPaginated(PaginationParameters pagination);
    }
}
