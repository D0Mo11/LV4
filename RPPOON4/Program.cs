using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("file.csv");
            Analyzer3rdParty analyze = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyze);

            Console.WriteLine("Average po stupcima:");
            double[] cols = adapter.CalculateAveragePerColumn(data);
            foreach (double col in cols)
            {
                Console.WriteLine(col);
            }

            Console.WriteLine("Average po redovima:");
            double[] rows = adapter.CalculateAveragePerRow(data);
            foreach (double row in rows)
            {
                Console.WriteLine(row);
            }
        }
    }
}
