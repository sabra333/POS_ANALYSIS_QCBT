using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ANALYSIS_QCBT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("pos.txt");
            #region knowledge
            Dictionary<string, int> knowledge = new Dictionary<string, int>();
           for (int i = 1; i <= 100; i++)
           {
               string[] line = lines[i].Split(' ');
               //knowledge
               for (int j = 0; j < line.Length; j++)
               {
                   if (knowledge.ContainsKey(line[j]))
                       knowledge[line[j]] += 1;
                   else
                       knowledge[line[j]] = 0;
               }
               
           }
           foreach (var item in knowledge.OrderByDescending(d=>d.Value))
           {
               Console.WriteLine("{0} {1}",item.Key,item.Value);
           }
            #endregion
           Dictionary<string, int> comprehesion = new Dictionary<string, int>();
           for (int i = 101; i <= 200; i++)
           {
               string[] line = lines[i].Split(' ');
               //knowledge
               for (int j = 0; j < line.Length; j++)
               {
                   if (comprehesion.ContainsKey(line[j]))
                       comprehesion[line[j]] += 1;
                   else
                       comprehesion[line[j]] = 0;
               }

           }
           foreach (var item in comprehesion.OrderByDescending(d => d.Value))
           {
               Console.WriteLine("{0} {1}", item.Key, item.Value);
           }
           Console.Read();
        }
    }
}
