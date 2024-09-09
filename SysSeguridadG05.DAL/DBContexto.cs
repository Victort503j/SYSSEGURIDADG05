using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SysSeguridadG05.EN;

namespace SysSeguridadG05.DAL
{
    public class DBContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("Server=localhost;Database=DBSeguridadG05;User=root;Password=password;",
            optionsBuilder.UseSqlServer(@"workstation id = DbSeguridadG05.mssql.somee.com; packet size = 4096; user id = victor2005_SQLLogin_1; pwd = zk4o1kgw5h; data source = DbSeguridadG05.mssql.somee.com; persist security info = False; initial catalog = DbSeguridadG05; TrustServerCertificate = True");
                //new MySqlServerVersion(new Version(8, 0, 0)));
        }

    }
}
