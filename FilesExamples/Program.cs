using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"Sample1.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Enter the text");
                Console.WriteLine("Enter EOF to end the file");
                string s = null;
                while (s != "EOF")
                {
                    s = Console.ReadLine();
                    if (s != "EOF")
                        sw.WriteLine(s);
                }
            }
            using (FileStream fs1 = new FileStream(@"Sample1.txt", FileMode.Open))
            using (StreamReader sr = new StreamReader(fs1))
            {
                Console.WriteLine($"Reading contents to Sample.txt :{sr.ReadToEnd()}");
            }
        }
    }
}