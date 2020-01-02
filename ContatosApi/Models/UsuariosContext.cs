using Microsoft.EntityFrameworkCore;

namespace ContatosApi.Models
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}