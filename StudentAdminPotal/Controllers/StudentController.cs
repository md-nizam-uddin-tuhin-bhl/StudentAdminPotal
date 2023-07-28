using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPotal.DomainModels;
using StudentAdminPotal.Repository;

namespace StudentAdminPotal.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudent student;
        private readonly IMapper mapper;

        public StudentController(IStudent student, IMapper mapper)
        {
            this.student = student;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[Controller]")]
        public async Task<IActionResult> GetAllStudentAsync()
        {

            var students = await student.GetStudentsAsync();
            return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
