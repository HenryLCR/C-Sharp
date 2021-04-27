using System;
namespace main
{
  class Animal
  {
    static void Main ()
    {
        
		     int num;
	  		Console.Clear ();
        	Console.WriteLine ("Elija una opcion");
        	Console.WriteLine ("1 Mamiferos");
        	Console.WriteLine ("2 Aves");
        	Console.WriteLine ("3 Acuaticos");
        	num = Convert.ToInt32 (Console.ReadLine ());

      		switch (num)
			{
				case 1:
	  				{
	    				Console.Clear ();
	    				Leon l = new Leon ();
	      				l.Grupo = "Mamiferos";
	      				l.Nombre = "Leon";
	      				l.NombreC = "Panthera leo";
	      				l.Melena = "Su melena Color Marron";

	      				Console.WriteLine ("Nombre Comun:" + l.Nombre);
	      				Console.WriteLine ("Nombre Cientifico: " + l.NombreC);
	      				Console.WriteLine ("Grupo: " + l.Grupo);
	     				l.funcionesmamiferos ();
	     				l.rugido ();
	      				Console.WriteLine ("Distintivo de un leon :" + l.Melena);
	      				Console.ReadKey ();
	     				Console.WriteLine ("");

	    				Perro b = new Perro ();
	      				b.Grupo = "Mamiferos";
	      				b.Nombre = "Perro";
	      				b.NombreC = "Canis familiaris";
		  				b.Sentido="Ladrido";

	      				Console.WriteLine ("Nombre Comun:" + b.Nombre);
	      				Console.WriteLine ("Nombre Cientifico: " + b.NombreC);
	      				Console.WriteLine ("Grupo: " + b.Grupo);
	      b.funcionesmamiferos ();
	      Console.WriteLine ("Distintivo de un Perro:" + b.Sentido);
	      Console.ReadKey ();
	      Console.WriteLine ("");

		   Gato c = new Gato ();
	      c.Grupo = "Mamiferos";
	      c.Nombre = "Gato";
	      c.NombreC = "Felis silvestris catus";

	      Console.WriteLine ("Nombre Comun:" + c.Nombre);
	      Console.WriteLine ("Nombre Cientifico: " + c.NombreC);
	      Console.WriteLine ("Grupo: " + c.Grupo);
	      Console.WriteLine ("Distintivo de un Gato: Maullar" );
	      Console.ReadKey ();
	      Console.WriteLine ("");

			Mono m = new Mono ();
	      m.Grupo = "Mamiferos";
	      m.Nombre = "Mono";
		  m.Metodo="Maullar";

	      Console.WriteLine ("Nombre Comun:" + m.Nombre);
	      Console.WriteLine ("Grupo: " + m.Grupo);
	      Console.WriteLine ("Distintivo de un Mono: " + m.Metodo);
	      Console.ReadKey ();
	      Console.WriteLine ("");

	      break;
	  }
	  case 2:
	  {
	    Console.Clear ();
	    Cuervo k = new Cuervo ();
	      k.Grupo = "Aves";
	      k.Nombre = "Cuervo";
	      k.NombreC = "Corvus corax ";

	      Console.WriteLine ("Nombre Comun:" + k.Nombre);
	      Console.WriteLine ("Nombre Cientifico: " + k.NombreC);
	      Console.WriteLine ("Grupo: " + k.Grupo);
	      Console.ReadKey ();
	      Console.WriteLine ("");

         Aguila p = new Aguila();
          p.Grupo="Aves"; 
          p.Nombre="Aguila";
          p.NombreC="Aves de Presa";
		  p.Metodo="Volar Alto";
         
          Console.WriteLine("Nombre Comun:"+ p.Nombre);
		  Console.WriteLine ("Grupo: " + p.Grupo);
          Console.WriteLine("Metodo: " + p.Metodo);
          Console.ReadKey();
          Console.WriteLine("");

		  Loro r = new Loro();
          r.Grupo="Aves"; 
          r.Nombre="Loro";
          r.NombreC="Psittacoidea ";
		  r.Metodo="Hablar";
         
          Console.WriteLine("Nombre Comun:"+ r.Nombre);
		  Console.WriteLine ("Nombre Cientifico: " + r.NombreC);
		  Console.WriteLine ("Grupo: " + r.Grupo);
          Console.WriteLine("Metodo: " + r.Metodo);
          Console.ReadKey();
          Console.WriteLine("");
	      break;
		  

	  }
	  case 3:
	  {
	      Console.Clear ();
	      AnguilaElectrica k = new AnguilaElectrica ();
	      k.Grupo = "Acuatico Pez";
	      k.Nombre = "Anguila Electrica";
	      k.NombreC = "Electrophorus electricus";
	      k.Aleta=2;
	      
	      Console.WriteLine ("Nombre Comun:" + k.Nombre);
	      Console.WriteLine ("Nombre Cientifico: " + k.NombreC);
	      Console.WriteLine ("Grupo: " + k.Grupo);
	      Console.WriteLine("Numero de Aletas: "+k.Aleta);
	      Console.ReadKey ();
	      Console.WriteLine ("");
          
          PezGlobo p = new PezGlobo();
          p.Grupo="Acuatico Pez"; 
          p.Nombre="Pez Globo";
          p.NombreC="Arothron nigropunctatus"; 
          p.Aleta=2;
          Console.WriteLine("Nombre Comun:"+p.Nombre);
          Console.WriteLine("Nombre Cientifico: "+p.NombreC);
          Console.WriteLine("Grupo: "+p.Grupo);
          Console.WriteLine("Numero de Aletas: "+p.Aleta);
          p.Picotazovenenozo();
          Console.ReadKey();
          Console.WriteLine("");
	    
	    
	    break;
	  }
	default:
	  break;
	}

		
	

    }
  }
}