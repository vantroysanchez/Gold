using Gold.Interfaces;
using Gold.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gold.Controllers
{
    public class ContactTypeController : ApiController
    {
        private readonly IContactTypeService _contactTypeService;

        public ContactTypeController(IContactTypeService contactTypeService)
        {
            _contactTypeService = contactTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<ContactType>> GetAll() => await _contactTypeService.GetAll();        
    }
}
