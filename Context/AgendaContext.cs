using Microsoft.EntityFrameworkCore;
using MODULOAPI.Entities;

namespace MODULOAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos {get; set;}
    }

}
