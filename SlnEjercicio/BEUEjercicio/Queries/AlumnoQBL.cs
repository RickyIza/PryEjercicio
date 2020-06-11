using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUEjercicio.Queries
{
    public static class AlumnoQBL
    {
        public static List<Alumno> GetAlumnos() {
            Entities db = new Entities();
            return db.Alumnoes.ToList();

        }

       // public static Alumno GetAlumno(int id) {
       //     Entities db = new Entities();
            //return db.Alumnoes.FirstOrDefault
      //  }

    }
}
