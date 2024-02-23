using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контрольВыхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Для выхода введите: exit");
                string wordExit = Console.ReadLine();

                if(wordExit == "exit")
                {
                    break;
                }
            }
        }
    }
}
