using linq.Models;
using System;
using System.Collections.Generic;

namespace linq.Repository
{
    public class Insertar
    {

        public void InsertarEstudiante()
        {

            var estudiante = new Estudiante()
            {
                Nombre = "Noe Romero",
                FechaNacimiento = new DateTime(1985, 9, 15)
            };

            using (var context = new ApplicationDbContext()) {

                //1-Crear objeto
                

                //2-Notificar que queremos agregar estudiante
                context.Estudiante.Add(estudiante);

                //3-Guardar los cambios
                context.SaveChanges();

            }
        }

        //Esta función deberia crear una tabla temporal e insertar los valores con un solo insert
        // nunca se verifcó
        public void InsertaListaEstuadiante()
        {
            var listaEstudiante = new List<Estudiante>();

            for (int i = 20; i < 30; i++) {
                listaEstudiante.Add(new Estudiante() { Nombre = "Estudiante " + i.ToString(), FechaNacimiento = new DateTime(2001, 3, 15) });
            }

            using (var context = new ApplicationDbContext())
            {
                context.Estudiante.AddRange(listaEstudiante);
                context.SaveChanges();
            }

        }



    }
}
