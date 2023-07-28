using AutoMapper;
using StudentAdminPotal.DomainModels;

namespace StudentAdminPotal.AfterMap
{
    public class AddStudentRequestAfterMap : IMappingAction<AddStudent, Models.Student>
    {
        public void Process(AddStudent source, Models.Student destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Address = new Models.Address()
            {
                Id = Guid.NewGuid(),
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress= source.PostalAddress,    
            };
            
        }
    }
}
