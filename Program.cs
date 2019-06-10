using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;



namespace kata3._2
{
    class Program
    {
        static void Main(string[] args)

        {
           
            //var expectedNumberOfAnagrams = 20683;
            var allLines = File.ReadAllLines("Listadepalabra.txt");
            var word = allLines.Where(x => x != string.Empty).ToArray();

            List<anagramList> Implementations = new List<anagramList>();
            {
                //new anagramListParralellelGrouping_Customs();
                Console.WriteLine("Hello World!");
            }
        }
    }
    }
