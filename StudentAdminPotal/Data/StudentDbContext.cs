using Microsoft.EntityFrameworkCore;
using StudentAdminPotal.Models;

namespace StudentAdminPotal.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options) { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }  
        public DbSet<Address> Address { get; set; }
    }
}
