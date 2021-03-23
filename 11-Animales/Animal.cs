using System;
public abstract class Animal: Reino //esta es Herencia
{
   
    public string Pelaje {get;set;}
    public string Parto {get; set;}
    
    public void funcionesmamiferos()
    {
      cosasdemamiferos();
    }
   
    private void cosasdemamiferos()//esto es encapsulamiento
    {
      
        
    }

    public void defensasdealpaca()
    {
      cosasdealpacas();
    }
   
    private void cosasdealpacas()//encapsulamiento
    {
        Console.WriteLine("Pastar llanuras todo el dia sin parar");
    }
}