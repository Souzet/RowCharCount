using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowCharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett filnamn:  "); // ‪C:\Users\souzet\Documents\exempelfil-sv.txt
            string fileName = Console.ReadLine();
            Console.WriteLine("Öppnar: {0}",fileName );
            // Från: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
            // Read file using StreamReader. Reads file line by line    
            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                //int charnum = 0;
                //int wordnum = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                    //charnum = charnum + ln.Length; // Fixa radslutstecken...
                    //var punctuation = ln.Where(Char.IsPunctuation).Distinct().ToArray();
                    //var words = ln.Split().Select(x => x.Trim(punctuation));
                    //wordnum = wordnum + words.Count();
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                //Console.WriteLine($"File has {wordnum} words.");
                //Console.WriteLine($"File has {charnum} chars.");

            }
        }
    }
}
