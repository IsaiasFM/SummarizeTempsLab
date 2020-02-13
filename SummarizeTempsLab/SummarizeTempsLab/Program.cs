using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName;

            FileName = Console.ReadLine();

            if (File.Exists(FileName))
            {

            }

            else
            {
                Console.WriteLine("File does not exist.")
            }
        }
    }
}
