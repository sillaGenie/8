using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/2018/log.txt";
            if (!File.Exists(path))
                File.Create(path);
            StreamWriter sw = new StreamWriter(path);
            
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.WriteLine(" {0} ", array[i]);
                }
               sw.Close();
            int S = 0;
            using StreamReader sr = new StreamReader(path);
            {
                int[] array2 = new int[10];
                
                for (int i = 0; i < 10; i++)
                {
                    array2[i] = Convert.ToInt32(sr.ReadLine());
                    S += array[i];
                }
            }
            Console.WriteLine(S);
        }
    }
}

