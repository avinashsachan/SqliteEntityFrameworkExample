using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleCSharp
{
    class Program
    {
      
        static void Main(string[] args)
        {

            using (var context = new SqLiteDbContext())
            {
                foreach (var r in context.Table1s.ToList())
                {
                    Console.WriteLine($"{r.ID} - {r.Name}");
                }

            }

            Console.WriteLine("Exit");
            Console.ReadKey();
        }
    }
}
