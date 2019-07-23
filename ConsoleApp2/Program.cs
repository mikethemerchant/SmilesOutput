using System;
using System.Linq;

namespace SmileOutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" });
            Console.WriteLine($"number of smiles: {count}");
            count = CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" });
            Console.WriteLine($"number of smiles: {count}");
            count = CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" });
            Console.WriteLine($"number of smiles: {count}");
            count = CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" });
            Console.WriteLine($"number of smiles: {count}");
        }


        public static int CountSmileys(string[] smileys)
        {
            int count = 0;
            foreach (var smile in smileys)
            {
                //Console.WriteLine(smile);
                if (smile.Contains(':') || smile.Contains(';'))
                {
                    if (smile.Contains(')') || smile.Contains('D'))
                    {
                        //Console.WriteLine(smile.Length);
                        if (smile.Length == 2)
                        {
                            count++;
                            //Console.WriteLine("counted");
                        }
                        else
                        {
                            if (smile.Contains('~') || smile.Contains('-'))
                            {
                                count++;
                                //Console.WriteLine("counted");
                            }
                        }

                    }
                }
            }

            return count;
        }
    }
}
