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
        [Route("[Controller]/{studentId:guid}"), ActionName("GetStudentAsync")]
        public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            var student = await studentReposity.GetStudentAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Student>(student));
        }

        [HttpPut]
        [Route("[Controller]/{studentId:guid}")]
        public async Task<IActionResult> UpdateStudentAsync([FromRoute] Guid studentId, [FromBody] UpdateStudentRequest request)
        {
            if(await studentReposity.Exists(studentId))
            {
              var updateStudent =  await studentReposity.UpdateStudent(studentId, mapper.Map<Models.Student>(request));

                if(updateStudent != null)
                {
                    return Ok(mapper.Map<Student>(updateStudent));
                }
            } 
            
                return NotFound();
            
        }

        [HttpDelete]
        [Route("[Controller]/{studentId:guid}")]
        public async Task<IActionResult> DeleteStudentAsync([FromRoute] Guid studentId)
        {
            if (await studentReposity.Exists(studentId))
            {
                var student = await studentReposity.DeleteStudent(studentId);
                return Ok(mapper.Map<Student>(student));
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[Controller]/Add")]
        public async Task<IActionResult> AddStudentAsync([FromBody] AddStudent request)
        {
          var student =await studentReposity.AddStudent(mapper.Map<Models.Student>(request));
            return CreatedAtAction(nameof(GetStudentAsync), new { studentId = student.Id }, mapper.Map<Student>(student));
        }
    }
}
