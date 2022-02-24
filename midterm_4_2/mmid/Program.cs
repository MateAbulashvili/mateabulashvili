using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace mid_4_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create files with Content");
            string[] names = new string[3];
            Console.WriteLine("Please enter the number and we will generate the input for the specific name");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("name for file number {0}: ", i + 1);
                string name = Console.ReadLine();
                names[i] = name;
                FileStream fs = new FileStream(path + "\\" + name + ".txt", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("secre text for{0}" + name);
                sw.Flush();
                sw.Close();

            }
            Reader(names, path);

        }
        public static void Reader(string[] names, string path)
        {

            List<Task> tasks = new List<Task>();
            foreach (string item in names)
            {
                Task SomeTask = Task.Run(() =>
                {
                    String line = File.ReadAllText(path + "\\" + item + ".txt");
                    Console.WriteLine("File Name : {0}.txt,   text inside : {1}", item, line);

                });


            }



        }
    }
}
