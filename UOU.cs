using System;
namespace UordiofUorcrefiti
{
  public abstract class Heroi 
  {
    private string nomeHeroi;
    private float pontosDeVida;
    private double utHeroi;
    private string magia;

    //Construtor Herói
       Heroi(string nomeHeroi, float pontosDeVida, double utHeroi, string magia)
        {
            this.nomeHeroi = nomeHeroi;
            this.pontosDeVida = pontosDeVida;
            this.utHeroi = utHeroi = 7;
            this.magia = magia;
        }
           //Método Get
            public string getnomeHeroi(){
            return (nomeHeroi);
          }
            public float getpontosDeVida(){
            return (pontosDeVida);
          }
            public double getutHeroi(){
            return (utHeroi);
           }
           public string getmagia(){
            return (magia);
           }
              //Método Set
                public void setnomeHeroi(string nomeHeroi){
                this.nomeHeroi = nomeHeroi;
                }
                   public void setpontosDeVida(float pontosDeVida){
                   this.pontosDeVida = pontosDeVida;
                }
                   public void setutHeroi(double utHeroi){
                   this.utHeroi = utHeroi;
                }
                public void setmagia(string magia){
                  this.magia = magia;
                }
    //Classe Magia
    public class Magia
    {
      private string nomeMagia;
      private int custoUT;
      private int danoMagia;
  
        //Construtor Magia 
          Magia(string nomeMagia, int custoUT, int danoMagia)
        {
             this.nomeMagia = nomeMagia;
             this.custoUT = custoUT;
             this.danoMagia = danoMagia;
        }
               //Método Get Magia
                public string getnomeMagia(){
                return (nomeMagia);
              }
              public int getcustoUT(){
                return (custoUT);
              }
              public int getdanoMagia(){
                return (danoMagia);
              }
                 //Método Set Magia
                 public void setnomeMagia(string nomeMagia){
                  this.nomeMagia = nomeMagia;
                 }
                 public void setcustoUT(int custoUT){
                  this.custoUT = custoUT;
                 }
                 public void setdanoMagia(int danoMagia){
                  this.danoMagia = danoMagia;
                 }
                   //Método Dano da Magia
                   public class DanoDaMagia
                   {

                   }
                   //Método Lançar magia
                   //public double lancarMagia(int danoMagoa)
                   //{
                    
                   //}

    //}
    //Método Lançar Magia 
    //public abstract class LancarMagia()
    //{

    //}
    //Método Atacar com Arma
    //public abstract class AtacarComArma()
    //{

    //}
    //Método Reduzir pontos de vida
    //public double reduzirVida(float pontosDeVida)
   // {
    //  int reduzirPontosDeVida = 5;
    //  this.pontosDeVida -= reduzirPontosDeVida;
     // return pontosDeVida;
   // }
    // public double aumentarVida(float pontosDeVida)
   // {
    //  int aumentarPontosDeVida = 8;
     // this.pontosDeVida += aumentarPontosDeVida;
      //return pontosDeVida;
   // }
    //Classe Herói da Aliança
    public class HeroiAlianca : Heroi
   {
     //Construtor
     HeroiAlianca(string nomeHeroi, float pontosDeVida, string magia) : base (nomeHeroi, pontosDeVida, magia)
     {
     this.nomeHeroi = nomeHeroi;
     this.pontosDeVida = pontosDeVida;
     this.magia = magia;
    }
    // public double reduzirVida(float pontosDeVida)
    //{ 
     // float bonus = 0.2f;
      //int reduzirPontosDeVida = 5;
      //this.pontosDeVida -= reduzirPontosDeVida + bonus;
      //return pontosDeVida;
   // }
    // public double aumentarVida(int pontosDeVida)
    //{
     // float bonus = 0.2f;
      //int aumentarPontosDeVida = 8;
      //this.pontosDeVida += aumentarPontosDeVida + bonus;
      //return pontosDeVida;
   // }
   // public class HeroiDaHorda : Heroi
    //{
     // HeroiDaHorda(string nomeHeroi, float pontosDeVida) : base (nomeHeroi, pontosDeVida)
      //{
       // this.nomeHeroi = nomeHeroi;
        //this.pontosDeVida = pontosDeVida;
     // }
     //public double reduzirVida(float pontosDeVida)
    //{ 
     // float bonus = 0.14f;
      //int reduzirPontosDeVida = 5;
      //this.pontosDeVida -= reduzirPontosDeVida + bonus;
      //return pontosDeVida;
   // }
    
   //  public double aumentarVida(int pontosDeVida)
    //{
     // float bonus = 0.14f;
      //int aumentarPontosDeVida = 8;
      //this.pontosDeVida += aumentarPontosDeVida + bonus;
      //return pontosDeVida;
    // }

    
    //public class ProgramaPrincipal
    //{ 
  
   // public static void Main(string[] args)
    //{
     // string nomeHeroi = "";
      //float pontosDeVida = 100.0f;

      //Heroi Hero = new Heroi(nomeHeroi = "Zymmax", pontosDeVida);
      //Console.WriteLine("O nome do herói é {0}", Hero.getnomeHeroi());
      //Console.WriteLine("Os pontos de vida do 'Herói' {0} é {1} pontos ", Hero.getnomeHeroi(), Hero.getpontosDeVida());
      
      //Hero.reduzirVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Heóri' foi reduzido para {0}", Hero.getpontosDeVida());
      //Hero.aumentarVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Herói' foi aumentado para {0}.", Hero.getpontosDeVida());
      //Console.WriteLine("");

      
      //HeroiAlianca HeroAlianca = new HeroiAlianca(nomeHeroi = "Zadur", pontosDeVida);
      //Console.WriteLine("O nome do herói é {0}", HeroAlianca.getnomeHeroi());
      //Console.WriteLine("Os pontos de vida do 'Herói' {0} é {1} pontos ", HeroAlianca.getnomeHeroi(), HeroAlianca.getpontosDeVida());
      
      //HeroAlianca.reduzirVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Heóri' foi reduzido para {0}", HeroAlianca.getpontosDeVida());
      //HeroAlianca.aumentarVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Herói' foi aumentado para {0}.", HeroAlianca.getpontosDeVida());
      //Console.WriteLine("");
      
      //HeroiDaHorda HeroHorda = new HeroiDaHorda(nomeHeroi = "Zadur", pontosDeVida);
      //Console.WriteLine("O nome do herói é {0}", HeroHorda.getnomeHeroi());
      //Console.WriteLine("Os pontos de vida do 'Herói' {0} é {1} pontos ", HeroHorda.getnomeHeroi(), HeroHorda.getpontosDeVida());
      
      //HeroHorda.reduzirVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Heóri' foi reduzido para {0}", HeroHorda.getpontosDeVida());
      //HeroHorda.aumentarVida(pontosDeVida);
      //Console.WriteLine("Os pontos de vida do 'Herói' foi aumentado para {0}.", HeroHorda.getpontosDeVida());
    //   }
     // }
     }
    }
   } 
 }
