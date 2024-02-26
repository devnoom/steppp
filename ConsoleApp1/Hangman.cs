using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hangman
    {
        public  List<string> list = new List<string>()
            {
                "giorgi",
                "mate",
                "whatsup"
            };
        public  List<string> body = new List<string>()
        {
            "Head",
            "Body",
            "firstHang",
            "SecondHang",
            "FirstLeg",
            "SecondLeg"
        };
        public  string EnterRandomWord()
        {
            Random random = new Random();

            int count = list.Count;
            Console.WriteLine(count);
            int rn = random.Next(0, count);
            Console.WriteLine(rn);
            string ran = list[rn];
            Console.WriteLine(ran);
            int stringlength = ran.Length - 1;
            Console.WriteLine(stringlength);
            return ran.ToLower();
        }
        public  string StringToTire(string str)
        {
            string val = "";
            int count = str.Length;
            for(int i = 0; i < count; i++)
            {
                val += "-";
            }
            return val;
        }
        public  void PrintTiresArray(char[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }

        }
        public  void ChangeToChar()
        {
            string str1 = EnterRandomWord();
            char[] toTire = StringToTire(str1).ToCharArray();
            while (body.Count > 0)
            {


                if (body.Count == 0)
                {
                    Console.WriteLine("shen waage");
                    break;
                }
                if (!toTire.Contains('-'))
                {
                    Console.WriteLine("moige");
                    break;
                }
                Console.WriteLine("Shemoitanet aso a  dan z is chatvlit");
                PrintTiresArray(toTire);
                Console.WriteLine();
                char t = char.Parse(Console.ReadLine());

                List<int> indexs = new List<int>();
                if (str1.Contains(t))
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] == t)
                        {
                            indexs.Add(i);
                        }
                    }
                    foreach (var item in indexs)
                    {
                        toTire[item] = str1[item];

                    }
                    Console.WriteLine(toTire);
                    indexs.Clear();
                }
                else
                {
                    Console.WriteLine(body.Count);
                    Console.WriteLine("araswori info");
                    Console.WriteLine($"personajs mosdzvra {body[0]}");
                    body.RemoveAt(0);

                    Console.WriteLine(body.Count());
                }
                //for(int i = 0;i < str1.Length; i++)
                //{
                //    if (str1[i] == t)
                //    {
                //        indexs.Add(i);
                //    }
                //}
                //foreach (var item in indexs)
                //{
                //    toTire[item] = str1[item];

                //}
                //Console.WriteLine(toTire);
                //indexs.Clear();
            }

        }
    }
}
