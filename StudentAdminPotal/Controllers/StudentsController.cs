using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPotal.DomainModels;
using StudentAdminPotal.Repository;

namespace StudentAdminPotal.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudent studentReposity;
        private readonly IMapper mapper;

        public StudentsController(IStudent student, IMapper mapper)
        {
            this.studentReposity = student;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[Controller]")]
        public async Task<IActionResult> GetAllStudentAsync()
        {

            var students = await studentReposity.GetStudentsAsync();
            return Ok(mapper.Map<List<Student>>(students));
        }

        [HttpGet]
        [Route("[Controller]/{studentId:guid}")]
        public async Task<IActionResult> GetAllStudentAsync([FromRoute] Guid studentId)
        {
          var student = await studentReposity.GetStudentAsync(studentId);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Student>(student));
        }
    }
}
