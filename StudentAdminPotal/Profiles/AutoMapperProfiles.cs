using AutoMapper;
using StudentAdminPotal.AfterMap;
using StudentAdminPotal.DomainModels;
using  DataModels = StudentAdminPotal.Models;

namespace StudentAdminPotal.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>().ReverseMap();

            CreateMap<DataModels.Gender, Gender>().ReverseMap();

            CreateMap<DataModels.Address, Address>().ReverseMap();

            CreateMap<UpdateStudentRequest, DataModels.Student>()
            .AfterMap<UpdateStudentRequestAfterMap>();

            CreateMap<AddStudent, DataModels.Student>()
          .AfterMap<AddStudentRequestAfterMap>();


        }
    }
}
