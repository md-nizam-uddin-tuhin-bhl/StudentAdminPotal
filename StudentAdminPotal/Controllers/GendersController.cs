using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPotal.DomainModels;
using StudentAdminPotal.Repository;

namespace StudentAdminPotal.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudent studentReposity;
        private readonly IMapper mapper;

        public GendersController(IStudent student, IMapper mapper)
        {
            this.studentReposity = student;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[Controller]")]
        public async Task<IActionResult> Index()
        {
            var GenderList = await studentReposity.GetGendersAsync();
            if(GenderList == null || !GenderList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Gender>>(GenderList));
        }
    }
}
