using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;

namespace ProjetoGeometria
{ 
  public class Triangulo
  {  
    public double cateto1, cateto2, hipotenusa;
 
    //Construtor - (this)
    Triangulo(double cateto1, double cateto2, double hipotenusa)
    {
     this.cateto1    = cateto1;
     this.cateto2    = cateto2; 
     this.hipotenusa = hipotenusa; 
   
     Console.WriteLine("Construtor Inicializado.");
   
    } 

    //Destrutor
    ~Triangulo()
    {
     Console.WriteLine("Destrutor Inicializado.");
    } 

    //metodos get/set
    public double getCateto1() {return this.cateto1;}
    public double getCateto2() {return this.cateto2;}
    public double getHipotenusa() {return this.hipotenusa;}
    
    public void setCateto1(double cateto1) {this.cateto1 = cateto1;}
    public void setCateto2(double cateto2) {this.cateto2 = cateto2;}
    public void setHipotenusa(double hipotenusa) {this.hipotenusa = hipotenusa;}

    public double calculaArea()
    {
     return (this.cateto1 * this.cateto2)/2;
    }
  
    public static void Main (string[] args)
    {
      Console.WriteLine("[Triângulo X]");
      double cateto1X    = 3;
      double cateto2X    = 4;
      double hipotenusaX = 5;

      Triangulo X  = new Triangulo(cateto1X, cateto2X, hipotenusaX);
  
      Console.WriteLine ("Cateto 1: " + X.getCateto1 ());
      Console.WriteLine ("Cateto 2: " + X.getCateto2());
      Console.WriteLine ("Hipotenusa: " + X.getHipotenusa());
      Console.WriteLine ("Area do Triangulo: " + X.calculaArea());

      Console.WriteLine("\n[Triângulo Y]");
      double cateto1Y    = 3;
      double cateto2Y    = 4;
      double hipotenusaY = 5;
    
      Triangulo Y  = new Triangulo(cateto1Y, cateto2Y, hipotenusaY);

      Console.WriteLine ("Cateto 1: " + Y.getCateto1 ());
      Console.WriteLine ("Cateto 2: " + Y.getCateto2());
      Console.WriteLine ("Hipotenusa: " + Y.getHipotenusa());
      Console.WriteLine ("Area do Triangulo: " + Y.calculaArea());

     // Comparação de Objetos (Uses the DefaultInvariant Comparer).
     if(Comparer.DefaultInvariant.Compare(X.calculaArea(), Y.calculaArea()) == 0 )
         Console.WriteLine("\nA maior área do triangulo é : {0} ", Y.calculaArea());
           else{
             if(Comparer.DefaultInvariant.Compare(X.calculaArea(), Y.calculaArea()) < 0 )
              Console.WriteLine("\nA maior área do triangulo é : {0} ", Y.calculaArea());
           } 
           
   }/*main*/ 

  }/*Triangulo*/

}/*namespace*/
