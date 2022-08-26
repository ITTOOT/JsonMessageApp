using AutoMapper;

using JsonMessageApi.Models;

namespace JsonMessageApi.Mappers
{
    // Map object attributes automatically - uses the AutoMapper package
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Map source to destination...

            //
            CreateMap<MessageFromErpDto, MessageFromErpDto>().ReverseMap();
            //CreateMap<MessageDto, Message>().ReverseMap();

        }
    }
}
