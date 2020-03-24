using System;

namespace cw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj sciezke do pliku z danymi .csv");
            string pathData = Console.ReadLine();

            Console.WriteLine("Podaje adres sciezki docelowej:");
            string pathOut = Console.ReadLine();

            Console.WriteLine("Podaj format w jakim sa przekazane dane:");
            string dataFormat = Console.ReadLine();

            ReadData readData = new ReadData(pathData, pathOut, dataFormat);
        }
    }
}
