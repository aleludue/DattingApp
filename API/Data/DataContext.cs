using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //clase definida para usar e inyectar posteriormente dentro del sistema
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //se define el nombre de la tabla (Users en este caso) y se le pasa la clase base (appuser en este caso)
        //de esta forma, va a generar la tabla con los campos detallados en la clase
        public DbSet<AppUser> Users { get; set; }

    }
}