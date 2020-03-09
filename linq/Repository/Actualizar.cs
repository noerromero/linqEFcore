using linq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq.Repository
{
    public class Actualizar
    {
        /// <summary>
        /// Modelo conectado
        /// </summary>
        public void ActualizarEstudianteConectado() {

            using (var context = new ApplicationDbContext()) {
                var estudiante = context.Estudiante.First(x => x.Nombre.StartsWith("Noe"));
                estudiante.FechaNacimiento = new DateTime(1995, 9, 11);
                context.SaveChanges();

            }

        }

        /// <summary>   
        /// Modelo desconectado
        /// </summary>
        public void ActualizarEstudianteDesconectado() {

            Estudiante estudiante;

            using (var context = new ApplicationDbContext()) {
                estudiante = context.Estudiante.First(x => x.Id == 3);
            }

            estudiante.Nombre = "Jaime Daniel";

            using (var context = new ApplicationDbContext()) {
                context.Entry(estudiante).State = EntityState.Modified;
                context.SaveChanges();
            }

        }



    }
}
