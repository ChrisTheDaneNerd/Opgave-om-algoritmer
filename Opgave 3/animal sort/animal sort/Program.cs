using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[28];
            string path = @".\arter.txt";
            try
            {
                //FileInfo fi = new FileInfo(path);
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    animals[i] = line;
                    i++;
                }
                fs.Close();
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File doesn't exist, create file");
            }

            Console.ReadKey();

        }
    }
}
