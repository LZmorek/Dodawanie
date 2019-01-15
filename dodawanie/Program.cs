using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstNumber = "";
            String SecondNumber = "";
            int Sum;
            Console.WriteLine("Witamy w dodwaniu");
            Start:
            Console.WriteLine("Podaj Pierwsza Liczbe 0-10: ");
            
            FirstNumber =Console.ReadLine();
            int FirstNum = int.Parse(FirstNumber);

             if (FirstNum > 10 || FirstNum < 0)
                {
                    Console.WriteLine("nie Poprawana liczba sprobuj ponownie");
                    goto Start;
                }

             Start2:

            Console.WriteLine("Podaj druga liczbe 0-10: ");
            SecondNumber=Console.ReadLine();
            int SecondNum = int.Parse(SecondNumber);
            
                if (SecondNum > 10 || SecondNum < 0)
                {
                    Console.WriteLine("nie Poprawana liczba sprobuj ponownie");
                    goto Start2;
                }
            
                
            Sum = FirstNum + SecondNum;
            Console.WriteLine("Wynik dodawania to : " + Sum + "");
            Console.ReadKey();
        }
    }
}
