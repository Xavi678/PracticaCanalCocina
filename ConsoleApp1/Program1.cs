using CanalCocina3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            CanalCocina cl = new CanalCocina();
            List<Program> p = new List<Program>();
            DateTime day = DateTime.Now;
            p=cl.Get(day);

            p.ForEach(i=> Console.Write("{0}\n {1}\n {2}\n {3}\n {4}\n", i.Title,i.Category,i.Chapter,i.Start,i.Desc));
            Console.ReadKey();
        }
    }
}
