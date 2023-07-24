using AutoMapper;

namespace Sender.DTO
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Consignor, ConsignorDTO>().ReverseMap();
        }
    }
}
