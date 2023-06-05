# CodigoObjeto.cs

using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;

namespace myApp
{ 
  public class Geometria
  {  
   static double calculaArea(double cateto1, double cateto2)
   {
     return (cateto1 * cateto2)/2;
   }

   static void Main (string[] args)
   {
    //Triangulo X
    Console.WriteLine("[Triângulo X]");  
    double cateto1X    = 3;
    double cateto2X    = 4;
    double hipotenusaX = 5;
    double AreaTrianguloX;
  
    AreaTrianguloX  = calculaArea(cateto1X, cateto2X);
  
    Console.WriteLine ("Cateto 1: " + cateto1X);
    Console.WriteLine ("Cateto 2: " + cateto2X);
    Console.WriteLine ("Hipotenusa: " + hipotenusaX);
    Console.WriteLine ("Área do Triângulo: " + AreaTrianguloX);

    //Triangulo Y
    Console.WriteLine ("\n[Triângulo Y] ");
    double cateto1Y    = 3;
    double cateto2Y    = 4;
    double hipotenusaY = 5;
    double AreaTrianguloY;

    AreaTrianguloY  = calculaArea(cateto1Y, cateto2Y);
  
    Console.WriteLine ("Cateto 1: " + cateto1Y);
    Console.WriteLine ("Cateto 2: " + cateto2Y);
    Console.WriteLine ("Hipotenusa: " + hipotenusaY);
    Console.WriteLine ("Área do Triângulo: " + AreaTrianguloY);

    // Comparação dos valores das áreas dos triângulos
     if(AreaTrianguloX == AreaTrianguloY)
         Console.WriteLine("\nAs áreas são iguais!");
           else
           {
               if(AreaTrianguloX < AreaTrianguloY)      
                   Console.WriteLine("\nA maior área do triângulo é o Y: {0} ", AreaTrianguloY);
                     else
                       Console.WriteLine("\nA maior área do triângulo é o X: {0} ", AreaTrianguloX);
           }      
    }
  }
}


/*/

using System;

namespace ProjetoSalvadorVaiDeBike
{ 

 public class Bicicleta
 {
   private string cor;
   private double velocidade;
  
   //Construtor
   Bicicleta(string cor, double velocidade)
   {
     this.cor        = cor;
     this.velocidade = velocidade;
   } 

   //Métodos GET
   public string getCor()
   {
      return(cor);     
   }

   public double getVelocidade()
   {
      return(velocidade);     
   }

   //Métodos SET
   public void setCor(string cor)
   {
     this.cor = cor;    
   }

   public void setVelocidade(double velocidade)
   {
     this.velocidade = velocidade;    
   }
     
   //Métodos Geral
   public void acelera()
   {
     velocidade = velocidade + 10; 
   } 
 
   //Destructor
   ~Bicicleta()
   {
     
   } 

   public double calculaDeslocamento(double inicio, double fim)
   {
     return(fim - inicio); 
   }


   public static void Main()
   {
      Bicicleta Caloi = new Bicicleta("vermelha", 23);
    
      Console.WriteLine("A 'Velocidade' da Caloi no instante t1 era de {0} km/h ", Caloi.getVelocidade()); 
      Console.WriteLine("A 'Cor' da Caloi é {0}\n", Caloi.getCor()); 

          Console.WriteLine("\t:: Acelerando a Caloi ++++ ::\n");
          Caloi.acelera();

      Console.WriteLine("A 'Velocidade' da Caloi no instante t2 era {0} km/h ", Caloi.getVelocidade()); 
      Console.WriteLine("A 'Distância' percorrida pela Caloi foi de {0} km \n", Caloi.calculaDeslocamento(2, 10)); 
    
   }/*main*/

 }/*Bicicleta*/

}/*namespace*/

/*/


using System;

namespace ProjetoSalvadorVaiDeBike
{ 
 public class Bicicleta
 {
     
   static double acelera(double velocidade)
   {
     velocidade = velocidade + 10; 

     return velocidade;
   } 
 
   static double calculaDeslocamento(double inicio, double fim)
   {
     return(fim - inicio); 
   }

   public static void Main()
   {
      string cor = "vermelha";
      double velocidade = 23; 

      Console.WriteLine("A 'Velocidade' da Caloi no instante t1 era de {0} km/h ", velocidade); 
      Console.WriteLine("A 'Cor' da Caloi é {0}\n", cor); 

          Console.WriteLine("\t:: Acelerando a Caloi ++++ ::\n");

      Console.WriteLine("A 'Velocidade' da Caloi no instante t2 era {0} km/h ", acelera(velocidade)); 
      Console.WriteLine("A 'Distância' percorrida pela Caloi foi de {0} km \n", calculaDeslocamento(2, 10)); 
    
   }/*main*/

 }/*Bicicleta*/

}/*namespace*/
