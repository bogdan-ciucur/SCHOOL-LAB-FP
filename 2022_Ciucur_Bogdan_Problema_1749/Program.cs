using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace lab_fundamente
{
    public class P1749
    {
        public static void Main(string[] args)
        {
            string pl = Console.ReadLine();
            int n = int.Parse(pl.Split(' ')[0]);
            int z = int.Parse(pl.Split(' ')[1]);
            int[,] a = new int[n, n];
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = Console.ReadLine();
                string[] local = buffer.Split(' ');
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(local[j]);
            }

            int sN = 0;
            int sE = 0;
            int sS = 0;
            int sW = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if ((i < j) && ((i + j) < (n - 1)))
                        sN += a[i, j];
                    if ((i < j) && ((i + j) > (n - 1)))
                        sE += a[i, j];
                    if ((i > j) && ((i + j) > (n - 1)))
                        sS += a[i, j];
                    if ((i > j) && ((i + j) < (n - 1)))
                        sW += a[i, j];
                }

            switch (z)
            {
                case 1: Console.Write(sN); break;
                case 2: Console.Write(sE); break;
                case 3: Console.Write(sS); break;
                case 4: Console.Write(sW); break;
            }

            Console.ReadKey();
        }
    }
}