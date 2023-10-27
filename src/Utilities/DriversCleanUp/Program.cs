using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversCleanUp
{
    class Program
    {
        static void Main()
        {
            if (Process.GetProcessesByName("chromedriver").Length == 0)
            {
                Console.WriteLine("No chromedriver processes found!");
            }

            else
            {
                foreach (var process in Process.GetProcessesByName("chromedriver"))
                {
                    Console.WriteLine("Killing the chromedriver process with id: " + process.Id);
                    process.Kill();
                }

                Console.WriteLine("\nAll chromedriver processes are killed!");
            }

            Console.ReadLine();
        }
    }
}
