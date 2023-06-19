using System;
namespace UordiofUorcrefiti
{
    public abstract class Heroi 
  {
    private string nomeHeroi;
    private float pontosDeVida;
    private int utHeroi;
    private string magia;

        //Construtor Herói
          Heroi(string nomeHeroi, float pontosDeVida, int utHeroi, string magia)
       {
           this.nomeHeroi = nomeHeroi;
           this.pontosDeVida = pontosDeVida;
           this.utHeroi = utHeroi;
           this.magia = magia;
       }
           //Método Get
              public string getnomeHeroi(){
              return (nomeHeroi);
          }
              public float getpontosDeVida(){
              return (pontosDeVida);
          }
              public int getutHeroi(){
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
                 public void setutHeroi(int utHeroi){
                    this.utHeroi = utHeroi = 7;
                 }
                 //Método aumentar valor atributo
                 public int aumentarUT(int utHeroi)
                 {
                   int aumentarUTHeroi = 2;
                   utHeroi += aumentarUTHeroi;
                   return utHeroi;
                 }
                 //Método diminuir valor atributo
                 public int diminuirUT(int utHeroi, int custoUT)
                 {
                    int reduzirUTHeroi = custoUT;
                    utHeroi -= reduzirUTHeroi;
                    return utHeroi;
                 }
                 public void setmagia(string magia){
                    this.magia = magia;
                 }

   /********************************************************************************/
   /********************************************************************************/

    public class Magia
     {
       private string nomeMagia;
       private int valorDano;
       private int custoUT; //Custo de tempo

         //Construtor Magia
           Magia(string nomeMagia, int valorDano, int custoUT)
         {
            this.nomeMagia = nomeMagia;
            this.valorDano = valorDano;
            this.custoUT = custoUT;
         }
          //Método Get Magia
            public string getnomeMagia(){
            return (nomeMagia);
         }
            public int getvalorDano(){
            return (valorDano);
         }
           public int getcustoUT(){
           return (custoUT);
        }
           public void setnomeMagia(string nomeMagia){
           this.nomeMagia = nomeMagia;
        }
           public void setvalorDano(int valorDano){
           this.valorDano = valorDano;
         }
 
     /********************************************************************************/
     /********************************************************************************/

    public class HeroiAlianca : Heroi
    {
      HeroiAlianca(string nomeHeroi, float pontosDeVida, int utHeroi, string magia) : base (nomeHeroi, pontosDeVida, utHeroi, magia)
      {
         this.nomeHeroi = nomeHeroi;
         this.pontosDeVida = pontosDeVida;
         this.utHeroi = utHeroi;
         this.magia = magia;
      }
     
    }
    public class HeroiHorda : Heroi
    {
      HeroiHorda(string nomeHeroi, float pontosDeVida, int utHeroi, string magia) : base (nomeHeroi, pontosDeVida, utHeroi, magia)
      {
         this.nomeHeroi = nomeHeroi;
         this.pontosDeVida = pontosDeVida;
         this.utHeroi = utHeroi;
         this.magia = magia;
      }
      
     }
    }
    public class Programa
    {
        public static void Main(string[] args)
        {
            string nomeHeroi = "", nomeMagia = "";
            float pontosDeVida = 100.0f;
            int utHeroi, custoUT, valorDano;
        }
    }
  }
} 
