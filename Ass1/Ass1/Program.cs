using System;
using Ass1.Components.Algorithms;
using Ass1.Components;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            var data = parser.Parse(',', @"./Data/WineData.csv");

        //<!--------------------------!>
            //hier kunnen de interations & clusters gewijzigd worden.
            var iterations = 300;
            var clusters = 5;
        //<!--------------------------!>

            var kMeans = new Kmeans(data, iterations, clusters);
            kMeans.Run();
            kMeans.Print();

            Console.Read();
        }
    }
}
