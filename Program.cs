using System;

namespace Atv_swicth_break
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int tempo=0;
            char escolha;


            Console.WriteLine("Fortaleza/CE a Rio de janeiro/ RJ");
            Console.WriteLine("Escolha o transporte : [a] Aviao | [c] carro | [o] onibus ");


            escolha = char.Parse(Console.ReadLine());



            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    break;

                case 'c':
                    tempo = 480;
                    break;

                case 'o':
                    tempo = 550;
                    break;

                default:
                    tempo = -1;
                    break;
            }
            
                    if(tempo < 0)
            {
                Console.WriteLine("transporte indisponivel");

            }
            else
            {
                Console.WriteLine("o tempo para o transporte escolhido é: "  + tempo + " minutos " );
            }

          
                 





        
        
        
        
        }
    }
}
