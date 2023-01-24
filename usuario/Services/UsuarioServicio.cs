using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using usuario.Data;
using usuario.DTO;
using usuario.Model;

namespace usuario.Services
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public UsuarioServicio(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool>GuardarUsuarios(UsuarioDTO usuario)
        {
            _context.Add(_mapper.Map<Usuario>(usuario));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<TipoContactoDTO>> ObtenerTipoContacto()
        {
            return _mapper.Map<List<TipoContactoDTO>>(await _context.TipoContactos.ToListAsync());
        }


        public async Task<List<UsuarioDTO>> ObtenerUsuarios()
        {
            return _mapper.Map<List<UsuarioDTO>>(await _context.Usuarios.ToListAsync());
        }
    }
}