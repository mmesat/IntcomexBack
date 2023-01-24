using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using usuario.DTO;
using usuario.Services;

namespace usuario.Controllers
{
    [Route("/usuarios")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioServicio _servicio;

        public UsuariosController(IUsuarioServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpPost("crear")]
        public async Task<ActionResult<bool>> CrearUusario([FromBody] UsuarioDTO usuarioDTO)
        {
            try
            {
                return Ok(await _servicio.GuardarUsuarios(usuarioDTO));
            }
            catch
            {
                //Se puede implementar logs, traza detallada etc...
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task <ActionResult<List<UsuarioDTO>>> ObtenerUsuarios()
        {
            try
            {
                return Ok(await _servicio.ObtenerUsuarios());
            }
            catch
            {
                //Se puede implementar logs, traza detallada etc...
                return BadRequest();
            }
        }

        [HttpGet("tipocontacto")]
        public async Task<ActionResult<List<UsuarioDTO>>> ObtenerTipoContacto()
        {
            try
            {
                return Ok(await _servicio.ObtenerTipoContacto());
            }
            catch
            {
                //Se puede implementar logs, traza detallada etc...
                return BadRequest();
            }
        }

    }
}

//1) Patch put
//2)
//{

//    "myString": "my string",
//  "myInt": 5,
//  "myArrayOfDoubles": [
//    3.14,
//    2.72
//  ],
//  "objectInObject": { }
//}

//(aunque tecnicamente no seria correcto ya que los objetos dentro de la clase no son publicos por lo tanto no se podrian acceder para generar un Json como tal estrictamente hablando)

//3) select a.first_name, MAX(b.salary) from employees a
//inner join salaries b on a.emp_no = b.emp_no group by a.first_name

//4) select dept_name, SUM(salary) from departments a
//inner join dept_emp b on a.dept_no = b.dept_no
//inner join  salaries c on b.emp_no = c.emp_no
//group by dept_name

//5) Select birth_date, first_name, last_name, gender, hire_date, count(birth_date) from employees group by (birth_date)

//6) Select birth_date, first_name, last_name, gender, hire_date, count(birth_date) from employees group by (birth_date)

//7) singleton

//8) Controlador

//9) son un conjunto de buenas practicas orientadas a la programación, cada letra tiene un significado, por ejemplo la S significa en ingles "single responsability" que significa que un solo modulo es encargado de una unica funcion.

//10) git clone

//11) git checkout -b develop
