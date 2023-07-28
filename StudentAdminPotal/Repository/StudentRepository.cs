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
<<<<<<< HEAD

=======
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

<<<<<<< HEAD
        public async Task<Student> GetStudentAsync(Guid studentId)
        {
          return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x =>x.Id == studentId);
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await studentDbContext.Gender.ToListAsync();
        }
=======
        
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
    }
}
