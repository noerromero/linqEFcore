using linq.Repository;
using System;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var insertar = new Insertar();
            var actualizar = new Actualizar();
            //insertar.InsertarEstudiante();

            //insertar.InsertaListaEstuadiante();
            //actualizar.ActualizarEstudianteConectado();
            actualizar.ActualizarEstudianteDesconectado();


        }
    }
}
