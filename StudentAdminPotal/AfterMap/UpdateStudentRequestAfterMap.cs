using AutoMapper;
using StudentAdminPotal.DomainModels;

namespace StudentAdminPotal.AfterMap
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, Models.Student>

    {
        public void Process(UpdateStudentRequest source, Models.Student destination, ResolutionContext context)
        {
            destination.Address = new Models.Address()
            {
                PhysicalAddress= source.PhysicalAddress,
                PostalAddress= source.PostalAddress,
            };

        }
    }
}
