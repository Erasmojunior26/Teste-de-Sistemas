using CrudTestar.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudTestar.Context
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
