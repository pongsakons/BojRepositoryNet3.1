using AutoMapper;
using BojTheft.Bll.Models;
using BojTheft.Dal.Pocos;

namespace BojTheft.Bll.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Theft, TheftModel>();
            CreateMap<TheftModel, Theft>();
        }
    }
}
