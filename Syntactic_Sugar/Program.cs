using System;
using System.Collections.Generic;

namespace Syntactic_Sugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var caterpillarPreds = new List<string> { "Birds", "Groundhogs" };
            var caterpillarPrey = new List<string> { "Leaves", "Microscopic bois" };
            var caterpillar = new Bug("Squirmy", "Caterpillar",  caterpillarPreds, caterpillarPrey);
            Console.WriteLine(caterpillar.FormalName);
            Console.WriteLine(caterpillar.PreyList());
            Console.WriteLine(caterpillar.PredatorList());
            Console.WriteLine(caterpillar.Eat("Leaves"));
            Console.ReadLine();            
        }
    }
    
}
