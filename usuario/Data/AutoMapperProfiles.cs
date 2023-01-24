using AutoMapper;
using usuario.DTO;
using usuario.Model;

namespace usuario.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<TipoContacto,TipoContactoDTO>().ReverseMap();
        }
    }
}
