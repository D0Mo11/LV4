using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> List = new List<IRentable>();
            List.Add(new Video("The Godfather"));
            List.Add(new Book("Lovac u žitu"));
            RentingConsolePrinter printer= new RentingConsolePrinter();
            printer.DisplayItems(List);
            List.Add(new HotItem(new Book("Nova hit knjiga")));
            List.Add(new HotItem(new Video("Novi hit film")));
            printer.DisplayItems(List); //U ovom ispisu dodaje se Trending: ispred novododanih objekata i povecava im se cijena
        } 
    }
}
