using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Alumno> alumnos;
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "1758964";


            alumno.alumnos[1].Nombre = "Maria Gonzalez";
            alumno.alumnos[1].Matricula = "9475323";

            alumno.alumnos[2].Nombre = "Lupe Castro";
            alumno.alumnos[2].Matricula = "641565";

            alumno.alumnos[3].Nombre = "Pepe Gamboa";
            alumno.alumnos[3].Matricula = "146826";

            alumno.alumnos[4].Nombre = "Concepción de la Rosa";
            alumno.alumnos[4].Matricula = "758621";

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matemáticas";
            matematicas.Identificador = "M153222514";

            //  Add es para añadir elementos
            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "H416521";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "E852455" ;

            //cuando se remueven los elementos, la lista se recorre y el espacio 1 no queda vacio
           // alumno.Materias.RemoveAt(1);

            //el clear borra todo en la lista
            //alumno.Materias.Clear();

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Número de materias: " + alumno.Materias.Count);

            //El foreach Es para recorrer todos lo elementos de una coleccion o de un arreglo
            foreach(Materia materia in alumno.Materias  Alumno Alumnos in alumno.Nombre)
            {
                Console.WriteLine("Materia: " + materia.Nombre);

            }
            Console.ReadLine();
        }
    }
}
