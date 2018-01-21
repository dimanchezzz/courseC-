using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NonSort
{
    class Non
    {
        string path = @"D:\Nonesort.txt";
        public void Roks()
        {
            Random rand = new Random();
            List<string> list = new List<string>() {"A","B" ,"C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g",
            "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "w", "z" };
            list = list.OrderBy(v => rand.Next()).ToList();
            
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for(int i=0;i<list.Count;i++)
                {
                    sw.Write(list[i] + " ");
                }
                sw.Write(" ");
               
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            

        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Non prime1 = new Non();
            prime1.Roks();
            
           // Console.ReadKey();
        }
    }
}
