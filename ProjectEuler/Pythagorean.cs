using System.Collections.Generic;
using System.IO;

namespace ProjectEuler
{
    public class Triplets
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
    }

    public static class Pythagorean
    {
        public static List<Triplets> GetTriplets(int n)
        {
            List<Triplets> result = new List<Triplets>();

            double a2, b2, c2;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    for (int k = j + 1; k <= n; k++)
                    {
                        a2 = i * i;
                        b2 = j * j;
                        c2 = k * k;

                        if (a2 + b2 == c2)
                        {
                            Triplets t = new Triplets();
                            t.a = i;
                            t.b = j;
                            t.c = k;

                            WriteTriplets(t);
                        }
                    }
                }
            }

            return result;
        }

        public static int FindPythagoreanTripletsProduct(int n)
        {
            List<Triplets> Triplets = GetTripletsFromFile(); //GetTriplets(n);
            foreach (var t in Triplets)
            {
                if (t.a + t.b + t.c == 1000)
                {
                    return t.a * t.b * t.c;
                }
            }

            return 0;
        }

        private static void WriteTriplets(Triplets t, string fileName = @"C:\dev\pythagoreanTriplets.txt")
        {
            using (StreamWriter file = new StreamWriter(fileName, true))
            {
                file.WriteLine(t.a + "," + t.b + "," + t.c);
            }
        }

        private static List<Triplets> GetTripletsFromFile(string fileName = @"C:\dev\pythagoreanTriplets.txt")
        {
            List<Triplets> result = new List<Triplets>();

            string[] lines = File.ReadAllLines(fileName);

            // Display the file contents by using a foreach loop.
            //Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                // Console.WriteLine("\t" + line);
                char[] separator = new char[] { ',' };

                string[] s = line.Split(separator);
                Triplets t = new Triplets();
                t.a = int.Parse(s[0]);
                t.b = int.Parse(s[1]);
                t.c = int.Parse(s[2]);

                result.Add(t);
            }

            return result;
        }
    }
}