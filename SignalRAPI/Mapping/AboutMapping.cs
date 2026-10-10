using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;
using System.Runtime;

namespace SignalRAPI.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            //maplemek yani eşleştirmek istediğim metodları çağırıcam
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
