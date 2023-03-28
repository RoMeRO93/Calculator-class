using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Introduceti primul numar:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti al doilea numar:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti operatiunea(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Adunare:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Scadere:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Inmultire:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Impartire:" + res);
                        break;
                    default:
                        Console.WriteLine("Operatiune gresita!");
                        break;
                }
                Console.ReadLine();
                Console.Write("Vrei sa continui(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}