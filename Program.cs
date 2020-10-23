using System;
using System.Threading;
namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
          string Sair="";
            do
              {
               Console.Clear();
                int S=0;
               double N=0,Notas=0 , media=0 ;
                     
               print("+------------------+",15,0,5,0);
               print("|                  |",15,0,5,1);
               print("+------------------+",15,0,5,2);
               print("Media de 4 Notas\n",6,0,7,1); 

              for (int i = 1; i < 5; )
                {
                  print($"entre valor {i}º nota ",15,0,0,3+i);
                   do
                   {
                     Console.SetCursorPosition(21, 3+i);
                     N=Convert.ToDouble(Console.ReadLine());  
                     if (N < 0 || N >10)
                      { 
                        Console.Beep();
                        print(" Apenas Valores entre 0 e 10 ",0,4,21,3+i); 
                        Thread.Sleep(1000);
                        print("                             ",0,0,21,3+i);
                        S = 0;
                      }
                       else  {Notas = Notas + N; S=1; i++;}
                   } while (S<1);
                }//fECHA fOR
             media= Notas/4;
             print($" media {media:N}",15,0,30,4);
             if (media > 6) {print("-- Aprovado --",0,2,30,5);}
             if (media<5.0) {print("--  Reprovado!  --",0,4,30,5);}
             if (media >= 5  &&  media <= 6) { print("-- Em Recuperação ! --",0,6,30,5);}
             
             print("\n(S)air? ",15,0,3,9);
             Sair=Console.ReadLine().ToUpper();
            } while (Sair !="S");
            Console.Clear();
        }// Fecha Main      
        
          static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
           {
            ConsoleColor CorC = (ConsoleColor)COR_Caracter;
            ConsoleColor CorF = (ConsoleColor)COR_Fundo;
            Console.ForegroundColor = CorC;
            Console.BackgroundColor = CorF;
            Console.SetCursorPosition(X, Y);
            Console.Write(S);
            Console.ResetColor();
           }//fecha print
    }// Fecha Class
}// Fecha namespace