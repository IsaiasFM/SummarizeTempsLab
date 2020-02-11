using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int SumTemps = 0;
            int numAbove = 0;
            int numBelow = 0;
            int TempCount = 0;
            string FileName;
            // temperature data is in temps.txt


            //write out prompt to the console
            Console.WriteLine("Enter filename.");

            //Read the filename from the console
            FileName = Console.ReadLine();
            // Test whether file exists

            //If the file exists
            if (File.Exists(FileName))
            {
                Console.WriteLine("File exists.");
                //ask the user to enter the temp. threshold
                Console.WriteLine("Please enter the temperature threshold.");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                //open the file and create StreamReader
                //read a line into a string variable
                using (StreamReader sr = File.OpenText(FileName))
                {
                    string line = sr.ReadLine();

                    //While the line is not null
                    while (line != null)
                    {
                        //Convert (parse) into an integer variable
                        temp = int.Parse(line);
                       
                        //Add the temp. to my summing variable
                        SumTemps += temp;

                        TempCount += 1;

                        //If the current temp value >= theshold
                        if (temp >= threshold)
                        {
                            //increment "above" counter by 1
                           numAbove += 1;
                        }

                        //else (temp. is below)
                        else
                        {
                           //increment the "below" counter by 1
                           numBelow += 1;
                        }

                        line = sr.ReadLine();
                    }
                    Console.WriteLine("Temperatures above = " + numAbove);
                    Console.WriteLine("temperatures below = " + numBelow);
                    int average = SumTemps / TempCount;

                    Console.WriteLine("Average Temp = " + average);
                }
                //Print out Temperaturs above the threshold
            }
            else
            {
                Console.WriteLine("file does not exists.");
            }
        }
    }
}
