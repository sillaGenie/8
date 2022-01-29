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
            string path = "D:/dota/Dota 2";
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < dirs.Length; i++)
                if (Directory.Exists(dirs[i]))
                {
                    Console.WriteLine(dirs[i]);
                    string[] sfiles = Directory.GetFiles(dirs[i]);
                    foreach (string f in sfiles)
                    {
                        Console.WriteLine(f);
                    }
                    string[] subdirs = Directory.GetDirectories(dirs[i]);
                    foreach (string s in subdirs)
                    {
                        Console.WriteLine(s);
                        string[] stfiles = Directory.GetFiles(s);
                        foreach (string f in stfiles)
                        {
                            Console.WriteLine(f);
                        }
                    }
                }
 
            
        }

    }
}
