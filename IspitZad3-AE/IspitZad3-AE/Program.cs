using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZad3_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod Brod = new Brod();
            Zrakoplov Avion = new Zrakoplov();
            Console.WriteLine("Brod: ");
            Brod.KudaVozi();
            Console.WriteLine("Avion: ");
            Avion.KudaVozi();
            Console.ReadKey();

        }
    }
}
