using AutoMapper;
using Gold.Common.Mappings;
using Gold.Common.Models;
using Gold.Dtos;
using Gold.Interfaces;
using Gold.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Reflection.PortableExecutable;

namespace Gold.Services
{
    public class ContactTypeService: IContactTypeService
    {
        private readonly IGoldDbContext _database;
        private readonly IMapper _mapper;

        public ContactTypeService(IGoldDbContext database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContactTypeDto>> GetAll()
        {
            var model = await _database.ContactTypes.ToListAsync();

            return _mapper.Map<IEnumerable<ContactTypeDto>>(model);
        }

        public async Task<PaginatedList<ContactType>> GetAllPaginated(PaginationParameters pagination)
        {
            var model = await _database.ContactTypes.PaginatedListAsync(pagination.PageNumber, pagination.PageSize);

            return model;
        }
    }
}
