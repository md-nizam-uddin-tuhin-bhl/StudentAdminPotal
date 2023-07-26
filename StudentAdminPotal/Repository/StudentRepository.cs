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

        
    }
}
