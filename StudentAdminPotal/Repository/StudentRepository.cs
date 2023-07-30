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
<<<<<<< HEAD

=======
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
>>>>>>> 0287b490315fa22b224992bdc4d7af4056f0f83f
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
<<<<<<< HEAD
=======

<<<<<<< HEAD
>>>>>>> 0287b490315fa22b224992bdc4d7af4056f0f83f
        public async Task<Student> GetStudentAsync(Guid studentId)
        {
          return await studentDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x =>x.Id == studentId);
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await studentDbContext.Gender.ToListAsync();
        }
<<<<<<< HEAD

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
=======
=======
        
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
>>>>>>> 0287b490315fa22b224992bdc4d7af4056f0f83f
    }
}
