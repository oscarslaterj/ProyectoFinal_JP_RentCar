using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Cliente{ get; set; }

        public Contexto() : base("Constr") { }
    }
}
