using Gold.Common.Models;
using Gold.Dtos;
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
        public async Task<IEnumerable<ContactTypeDto>> GetAll() => await _contactTypeService.GetAll();

        [HttpGet("GetAllWithPagination")]
        public async Task<ActionResult<PaginatedList<ContactType>>> GetAllPaginated([FromQuery] PaginationParameters pagination) 
            => await _contactTypeService.GetAllPaginated(pagination);

    }
}
