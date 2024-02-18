using Gold.Interfaces;
using Gold.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Gold.Services
{
    public class ContactTypeService: IContactTypeService
    {
        private readonly IGoldDbContext _database;

        public ContactTypeService(IGoldDbContext database)
        {
            _database = database;
        }

        public async Task<IEnumerable<ContactType>> GetAll()
        {
            var model = await _database.ContactTypes.ToListAsync();

            return model;
        }
    }
}
