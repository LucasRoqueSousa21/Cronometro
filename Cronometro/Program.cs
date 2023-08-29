using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();            
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("---------Menu do Crônometro---------");
            Console.WriteLine("");
            Console.WriteLine("S = Segundos. Ex: 10s = 10 segundos");
            Console.WriteLine("M = Minutos. Ex: 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja cronometrar?: ");

            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1)) ;

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);

            
        }

        static void PreStart(int time)
        {

            Console.Clear();

            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);

            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            
            Console.WriteLine("Fogooooooooooooo!!!!!");
            Thread.Sleep(2000);

            Cronometro(time);
        }

        static void Cronometro(int time)
        {
            Console.Clear();

           
            int currentTime = 0;

            while(currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);      
;                
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(3000);

            Menu();
        }

    }
}
