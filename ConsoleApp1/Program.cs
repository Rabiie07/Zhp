using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is my first app
            Console.WriteLine("Hello World");

            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Minvalue= {0} Maxvalue= {1}", flMin, flMax);

            float flVar = 1F / 3;
                double dlVar = 1D/ 3;
                decimal dcVar =  1M / 3;
            Console.WriteLine("\nfloat value ={0} \ndouble value ={1} \ndecimal value = {2}" , flVar , dlVar , dcVar );
               
                Console.ReadKey();
            
            



        }

        
        
    }
}
