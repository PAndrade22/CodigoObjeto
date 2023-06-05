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
