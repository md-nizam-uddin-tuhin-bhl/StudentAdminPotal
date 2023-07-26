using Microsoft.EntityFrameworkCore;
using StudentAdminPotal.Data;
using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly StudentDbContext studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
          return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x =>x.Id == studentId);
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await studentDbContext.Gender.ToListAsync();
        }
    }
}
