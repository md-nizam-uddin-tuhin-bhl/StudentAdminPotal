using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudentsAsync();
<<<<<<< HEAD

        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student> UpdateStudent(Guid studentId, Student request);
        Task<Student> DeleteStudent(Guid studentId);
        Task<Student> AddStudent(Student request);

=======
<<<<<<< HEAD
        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();
=======
>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
>>>>>>> 0287b490315fa22b224992bdc4d7af4056f0f83f
    }
}
