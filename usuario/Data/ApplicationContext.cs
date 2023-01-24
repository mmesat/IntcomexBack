using Microsoft.EntityFrameworkCore;
using usuario.Model;

namespace usuario.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        //Comentar lo de arriba y descomentar lo de abajo para usar base de datos en memoria
        //public ApplicationContext(DbContextOptions options) : base(options)
        //{
        //}
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<TipoContacto> TipoContactos {get;set;}
    }
}
