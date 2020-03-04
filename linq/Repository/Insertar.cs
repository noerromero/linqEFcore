using linq.Models;
using System;

namespace linq.Repository
{
    public class Insertar
    {

        public void InsertarEstudiante()
        {
            using (var context = new ApplicationDbContext()) {

                //1-Crear objeto
                var estudiante = new Estudiante()
                {
                    Nombre = "Noe Romero",
                    FechaNacimiento = new DateTime(1985, 9, 15)
                };

                //2-Notificar que queremos agregar estudiante
                context.Estudiante.Add(estudiante);

                //3-Guardar los cambios
                context.SaveChanges();

            }
        }

    }
}
