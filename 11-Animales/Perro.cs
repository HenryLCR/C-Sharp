using System;
public class Perro: Animal
{
   public string Sentido {get;set;}
   
   
   public void aullido()
   {
       Console.WriteLine("El perro Esta Ladrando");
   }
}