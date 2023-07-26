using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();
    }
}
