using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName;

            Console.WriteLine("Please enter the file name.");

            FileName = Console.ReadLine();

            if (File.Exists(FileName))
            {
                int TempInput;

                Console.WriteLine("File exists.");
                Console.WriteLine("Please enter a temperature threshold.");

                TempInput = int.Parse(Console.ReadLine());

                using (StreamReader sr = File.OpenText(FileName))
                {
                    string line = sr.ReadLine();
                    int Temp;
                    int SumTemps = 0;
                    int TempCount = 0;
                    int TempAbove = 0;
                    int TempBelow = 0;
                    int AverageTemp;

                    while (line != null)
                    {
                        Temp = int.Parse(line);

                        SumTemps += Temp;

                        TempCount += 1;

                        if (Temp >= TempInput)
                        {
                            TempAbove += 1;
                        }

                        else
                        {
                            TempBelow += 1;
                        }
                    }

                    AverageTemp = SumTemps / TempCount;

                    Console.WriteLine("Number of temperatures above the input threshold: " + TempAbove);
                    Console.WriteLine("Number of temperatures below the input threshold: " + TempBelow);
                    Console.WriteLine("Average temperature: " + AverageTemp);


                }
            }

            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}
