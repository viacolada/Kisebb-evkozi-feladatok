using System;

namespace Harmadik
{
    class Convert
    {
        int hossz;
        string result;
        int[] segments;


        public string toInt(string[] input)
        {
            hossz = input[0].Length;
            segments = new int[hossz / 3];

            for (int k = 0; k < 3; k++)
            {
                string sor = input[k];

                for (int i = 0; i < hossz; i += 3)
                {
                    int j = i / 3;
                    if (k == 0 && sor[i] == ' ' && sor[i + 1] == '_' && sor[i + 2] == ' ')
                    {
                        segments[j] += 1000000;
                    }
                    else if (k == 1 && sor[i] == ' ' && sor[i + 1] == ' ' && sor[i + 2] == '|')
                    {
                        segments[j] += 10;
                    }
                    else if (k == 1 && sor[i] == ' ' && sor[i + 1] == '_' && sor[i + 2] == '|')
                    {
                        segments[j] += 11;
                    }
                    else if (k == 1 && sor[i] == '|' && sor[i + 1] == '_' && sor[i + 2] == '|')
                    {
                        segments[j] += 100011;
                    }
                    else if (k == 1 && sor[i] == '|' && sor[i + 1] == '_' && sor[i + 2] == ' ')
                    {
                        segments[j] += 100001;
                    }
                    else if (k == 1 && sor[i] == '|' && sor[i + 1] == ' ' && sor[i + 2] == '|')
                    {
                        segments[j] += 100010;
                    }
                    else if (k == 2 && sor[i] == ' ' && sor[i + 1] == ' ' && sor[i + 2] == '|')
                    {
                        segments[j] += 100;
                    }
                    else if (k == 2 && sor[i] == ' ' && sor[i + 1] == '_' && sor[i + 2] == '|')
                    {
                        segments[j] += 1100;
                    }
                    else if (k == 2 && sor[i] == '|' && sor[i + 1] == '_' && sor[i + 2] == '|')
                    {
                        segments[j] += 11100;
                    }
                    else if (k == 2 && sor[i] == '|' && sor[i + 1] == '_' && sor[i + 2] == ' ')
                    {
                        segments[j] += 11000;
                    }
                }
            }

            for (int i = 0; i < hossz / 3; i++)
            {
                if (segments[i] == 0000110) { result += "1"; }
                else if (segments[i] == 1011011) { result += "2"; }
                else if (segments[i] == 1001111) { result += "3"; }
                else if (segments[i] == 0100111) { result += "4"; }
                else if (segments[i] == 1101101) { result += "5"; }
                else if (segments[i] == 1111101) { result += "6"; }
                else if (segments[i] == 1000110) { result += "7"; }
                else if (segments[i] == 1111111) { result += "8"; }
                else if (segments[i] == 1101111) { result += "9"; }
                else if (segments[i] == 1111110) { result += "0"; }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = null;
            input = new string[3];

            for (int i = 0; i < 3; i++)
            {
                string sor = Console.ReadLine();
                input[i] = sor;
            }

            Convert convert = new Convert();
            Console.WriteLine(convert.toInt(input));
        }
    }
}
    
