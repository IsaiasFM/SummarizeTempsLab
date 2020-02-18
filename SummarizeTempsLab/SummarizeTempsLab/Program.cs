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
                int UserInput;

                Console.WriteLine("File exists.");
                Console.WriteLine("Please enter a temperature threshold.");

                UserInput = int.Parse(Console.ReadLine());
                using (StreamReader sr = File.OpenText(FileName))
                {

                }
            }

            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}
