using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run(); //Section A
            string lines = System.IO.File.ReadAllText("U:/Users/725713/jashan/beowulf.txt");
            p.FindNumberOfBlankSpaces(lines); //(Section B )
            p.ProcessArrayList();

        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/725713/jashan/beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                    Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
                Console.WriteLine($"File has {countSpaces} Blank Spaces.");
                Console.WriteLine($"File has {countletters} Words.");
            }
            return countSpaces;
        }
        public void ProcessArrayList()
        {
            int LineNumber = 0;
            foreach (var line in Beowulf)

            {

                if (!ContainWord(line.ToString().ToLower(), "war") && ContainWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine(line);
                    Console.WriteLine("Line number is {0}", LineNumber);
                    LineNumber++;
                }
            }
            Console.WriteLine(LineNumber);
        }
        public bool ContainWord(string line, string Word)
        {
            if (line.Contains(Word) == true)
            {
                return true;
            }
            return false;
        }

    }
}

