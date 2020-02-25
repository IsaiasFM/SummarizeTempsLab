using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName;
            int RunFileAgain = 1;

            Console.WriteLine("Please enter the file name.");

            FileName = Console.ReadLine();

            while (RunFileAgain == 1)
            {


                if (File.Exists(FileName))
                {
                    int TempInput;
                    int UserChoice = 1;
                    int Temp;
                    int SumTemps = 0;
                    int TempCount = 0;
                    int TempAbove = 0;
                    int TempBelow = 0;
                    int AverageTemp;

                    Console.WriteLine("File exists.");

                    while (UserChoice == 1)
                    {
                        Console.WriteLine("Please enter a temperature threshold.");

                        TempInput = int.Parse(Console.ReadLine());

                        using (StreamReader sr = File.OpenText(FileName))
                        {
                            string line = sr.ReadLine();


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

                                line = sr.ReadLine();
                            }

                            AverageTemp = SumTemps / TempCount;

                            Console.WriteLine("Number of temperatures above the input threshold: " + TempAbove);
                            Console.WriteLine("Number of temperatures below the input threshold: " + TempBelow);
                            Console.WriteLine("Average temperature: " + AverageTemp);


                        }
                        Console.WriteLine();

                        using (StreamWriter sw = new StreamWriter("output.txt"))
                        {
                            sw.WriteLine(System.DateTime.Now.ToString());
                            sw.WriteLine("Chosen threshold: " + TempInput);
                            sw.WriteLine("Temperatures above: " + TempAbove);
                            sw.WriteLine("Temperatures below: " + TempBelow);
                            sw.WriteLine("Average tempurature: " + AverageTemp);
                            sw.WriteLine();

                        }

                        Console.WriteLine("Would you like to continue with a new temperature threshold in this same file?");
                        Console.WriteLine("1 - Yes");
                        Console.WriteLine("2 - No");

                        UserChoice = int.Parse(Console.ReadLine());
                    }
                }

                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
        }
    }
}
