using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudentsAsync();
<<<<<<< HEAD
        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();
=======
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
    }
}
