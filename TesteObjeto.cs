//Sintaxe para POO
using System;
namespace SintaxePOO
{
  public class Saldo
  {
  //Declaração dos atributos
  public int numero;
  public string nome;
  public double saldo; 

    //construtor
    Saldo(int numero, string nome, double saldo)
   {

    this.numero = numero;
    this.nome = nome;
    this.saldo = saldo;

    }

    //Destrutor
    ~Saldo()
    {

    }
    public static void Main(string[] args)
    {
      Saldo c = new Saldo(2, "Pedro", 100.0);
      Console.WriteLine("{0}, {1}, {2}", c.numero, c.nome, c.saldo);

    }
    
  }
}
