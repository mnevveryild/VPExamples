using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma3
{
    internal class Program
    {
        class Bread
        {
            public int counter;
        }

        static class Butter
        {
            public static int counter;
        }
        static void Main(string[] args)
        {
            
            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);    // örnek gerekli

           
            Butter.counter = 7;
            Console.WriteLine("Butter: " + Butter.counter); // örnek gerekmez

        }
    }
}
