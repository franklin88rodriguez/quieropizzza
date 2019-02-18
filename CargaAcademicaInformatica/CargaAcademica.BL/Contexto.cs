using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CargaAcademica.BL
{
    public class Contexto: DbContext
    {

        public Contexto(): base("CargaAcademicaDB")
        {

        }

        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}
