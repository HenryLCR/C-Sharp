using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a= new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Luis";
            a.SegundoNombre = "Alexander";
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Cristina";

            Alumno c = new Alumno(3);
            
            c.PrimerNombre = "Carlos";
            c.SegundoNombre = "Arnoldo";

            Alumno d = new Alumno ("Luis", "Alexander");


            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);

        }
    }
}
