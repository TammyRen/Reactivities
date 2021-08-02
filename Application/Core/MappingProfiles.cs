using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //mapping from... mapping to...
            CreateMap<Activity, Activity>();
        }
    }
}