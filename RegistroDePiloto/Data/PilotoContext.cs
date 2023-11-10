using Microsoft.EntityFrameworkCore;
using RegistroDePiloto.Models;

namespace RegistroDePiloto.Data
{
    public class PilotoContext : DbContext
    {
        public DbSet<Piloto> Pilots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=rm95199;Password=081196;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));");
        }
    }
}
