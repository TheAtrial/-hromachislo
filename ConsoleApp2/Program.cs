using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const int n = 6;
            int i, j;
            //int[,] mi = new int[n,n];
            int[,] mi = {
                     { 0, 1, 0, 1, 1, 0},
                     { 1, 0, 1, 1, 0, 0},
                     { 0, 1, 0, 1, 1, 1},
                     { 1, 1, 1, 0, 1, 0},
                     { 1, 0, 1, 1, 0, 1},
                     { 0, 0, 1, 0, 1, 0}
            };

            for (i = 0; i < mi.GetLength(0); ++i)
            {
                for (j = 0; j < mi.GetLength(1); ++j)
                {
                    Console.Write("{0}\t", mi[i, j]);
                    
                }
                Console.WriteLine("");
            }
            int[] col = new int[n];
            for(i = 0; i<n; ++i)
                col[i] = 1; 
            for(i = 0; i<n; ++i)
                for(j = i + 1; j<n - 1; ++j)
                    if(mi[i,j] == 1 && col[j] == col[i])
                        col[j] = col[i] + 1;
            int max = col[0];
            for(j = 1; j<n; ++j)
                if(max<col[j])
                    max = col[j];
            
            Console.WriteLine("Хроматическое число графа равно: {0}", max);
            Console.ReadLine();
            //string q = Console.ReadLine();
            //return 0;
        }
    }
}
