using System;

namespace HeroesVSVillanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje h = new Personaje("Batman","Bruce Wayne");
            
            h.Nombre = "Batman";
            h.IdentidadSecreta = "Bruce Wayne";
            h.Millonario = true;
            h.OtorgarSuperPoderes();

            HeroesVSVillanos v = new HeroesVSVillanos ();
            v.Id = 2;
            v.nombre ="Jocker";
            v.IdentidadSecreta = "DEsconocido";

            Console.WriteLine("Hello World!");
        }
    }
}
