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
            int FirstNum;
            int SecondNum;
            int Sum;
            int Num = 0;
            
            Console.WriteLine("Witamy w dodawaniu");

            Console.WriteLine("Podaj Pierwsza Liczbe 0-10: ");
            
            FirstNum =PobierzLiczbe(Num);

            Console.WriteLine("Podaj Druga Liczbe 0-10: ");

            SecondNum = PobierzLiczbe(Num);
            
            Sum = FirstNum + SecondNum;
            Console.WriteLine("Wynik dodawania to : " + Sum + "");
            Console.WriteLine("Nacisnij dowolny klawisz aby wyjsc");
            Console.ReadKey();
        }
        static int PobierzLiczbe(int Num)
        {
            String Number = "";
            String con = "";
            do
            {
                try
                {

                    Number = Console.ReadLine();
                    Num = int.Parse(Number);

                    if (Num > 10 || Num < 0)
                    {
                        Console.WriteLine("nie Poprawana liczba ");
                        Console.WriteLine("Wpisz Liczbe Ponownie: ");
                    }
                    else
                        con = "wkoncu";
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (OverflowException OverEx)
                {
                    Console.WriteLine(OverEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (ArithmeticException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Coœ posz³o nie tak");
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
            } while (con != "wkoncu");
            return Num;
        }
    }
}
        






