using System;

namespace Második
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine(Caesar(S, X));
        }
        static string Caesar(string S, int X)
        {
            string karakterek = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string irasjelek = "-.?! ,";
            string eredmeny = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (irasjelek.Contains(S[i]))
                {
                    eredmeny += S[i];
                }
                else
                {
                    for (int j = 0; j < karakterek.Length; j++)
                    {
                        if (char.ToUpper(S[i]) == karakterek[j])
                        {
                            if (j + X < karakterek.Length)
                            {
                                if (char.IsLower(S[i]))
                                {
                                    eredmeny += char.ToLower(karakterek[j + X]);
                                }
                                else
                                {
                                    eredmeny += (karakterek[j + X]);
                                }
                            }
                            else
                            {
                                if (char.IsLower(S[i]))
                                {
                                    eredmeny += char.ToLower(karakterek[j + X - karakterek.Length]);
                                }
                                else
                                {
                                    eredmeny += (karakterek[j + X - karakterek.Length]);
                                }

                            }
                        }

                    }
                }

            }
            return eredmeny;
        }
    }
}
