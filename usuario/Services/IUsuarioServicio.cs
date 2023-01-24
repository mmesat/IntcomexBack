using System.Collections.Generic;
using System.Threading.Tasks;
using usuario.DTO;

namespace usuario.Services
{
    public interface IUsuarioServicio
    {
        Task<bool> GuardarUsuarios(UsuarioDTO usuario);
        Task<List<TipoContactoDTO>> ObtenerTipoContacto();
        Task<List<UsuarioDTO>> ObtenerUsuarios();
    }
}
