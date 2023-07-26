using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
