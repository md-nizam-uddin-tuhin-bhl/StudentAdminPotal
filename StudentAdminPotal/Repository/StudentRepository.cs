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


        public async Task<bool> Exists(Guid studentId)
        {
            return await studentDbContext.Student.AnyAsync(x => x.Id == studentId);
        }

        public async Task<Student> UpdateStudent(Guid studentId, Student request)
        {
            var exitingStudent = await GetStudentAsync(studentId);
            if (exitingStudent != null)
            {
                exitingStudent.FirstName = request.FirstName;
                exitingStudent.LastName = request.LastName;
                exitingStudent.DateOfBirth = request.DateOfBirth;
                exitingStudent.Email = request.Email;
                exitingStudent.Mobile = request.Mobile;
                exitingStudent.GenderId = request.GenderId;
                exitingStudent.Address.PhysicalAddress = request.Address.PhysicalAddress;
                exitingStudent.Address.PostalAddress = request.Address.PostalAddress;

                await studentDbContext.SaveChangesAsync();
                return exitingStudent;
            }
            return null;
        }

        public async Task<Student> DeleteStudent(Guid studentId)
        {
            var student = await GetStudentAsync(studentId);
            if(student != null)
            {
                studentDbContext.Student.Remove(student);
                await studentDbContext.SaveChangesAsync();
                return student;
            }
            return null;
        }

        public async Task<Student> AddStudent(Student request)
        {
            var student = await studentDbContext.Student.AddAsync(request);
            await studentDbContext.SaveChangesAsync();
            return student.Entity;
        }

    }
}
