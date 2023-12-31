﻿using StudentAdminPotal.Models;

namespace StudentAdminPotal.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudentsAsync();


        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student> UpdateStudent(Guid studentId, Student request);
        Task<Student> DeleteStudent(Guid studentId);
        Task<Student> AddStudent(Student request);


        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();

    }
}
