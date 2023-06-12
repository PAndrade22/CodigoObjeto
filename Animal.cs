using System;
namespace Animais
{
  public class Animal
  {
    public string NomeAnimal { get; set; } 

    public void Acordar()
    {
      Console.WriteLine($"{NomeAnimal} acordou.");
    }
     public void Comer()
    {
     Console.WriteLine($"{NomeAnimal} está comendo");
    }
    public void Dormir()
    {
      Console.WriteLine($"{NomeAnimal} está dormindo");
    }
    
  }
  public class Mamifero : Animal
  {
    public void Mamar()
    {
      Console.WriteLine($"{NomeAnimal} está mamando.");
    }
  }
  public class Morcego : Mamifero
  {
    public void Voar()
    {
      Console.WriteLine($"{NomeAnimal} está voando.");
    }
  }
  public class Baleia : Mamifero
  {
    public void Nadar()
    {
      Console.WriteLine($"{NomeAnimal} está nadando.");
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Animal animal = new Animal { NomeAnimal = "Animal"};
      animal.Acordar();
      animal.Comer();
      animal.Dormir();
      Console.WriteLine();

      Mamifero mamifero = new Mamifero { NomeAnimal = "Mamífero"};
      mamifero.Acordar();
      mamifero.Comer();
      mamifero.Dormir();
      mamifero.Mamar();
      Console.WriteLine();

      Morcego morcego = new Morcego { NomeAnimal = "Morcego"};
      morcego.Acordar();
      morcego.Comer();
      morcego.Dormir();
      morcego.Mamar();
      morcego.Voar();
      Console.WriteLine();

      Baleia baleia = new Baleia { NomeAnimal = "Baleia"};
      baleia.Acordar();
      baleia.Comer();
      baleia.Dormir();
      baleia.Mamar();
      baleia.Nadar();
      Console.WriteLine();
    }
  }
}
