using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string,int>();
            string text = "Вот дом, Который построил Джек. А это пшеница, " +
                " Кото­рая в темном  чулане хранится В доме, Который построил Джек." +
                " А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в " +
                " темном чулане хранится В доме, Который построил Джек.";
            string buf="";
            //for(int i = 0; i < text.Length; i++)
            //{
            //    Console.Write((int)text[i]+ "  ");
            //}
            int j = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if( (text[i]>='А' && text[i] <= 'я') || text[i]=='-')
                {
                    buf += text[i];
                }
                else
                {                    
                    try
                    {
                        map.Add(buf, 1);
                        buf = "";
                        j++;
                    }
                    catch
                    {
                        map[buf]++;
                        buf = "";
                        j++;
                    }
                    buf = "";
                }
            }           
            Console.WriteLine(map.Count);

                    foreach(string p in map.Keys)
            {
                Console.WriteLine(p);
            }

                    foreach(int p in map.Values)
            {
                Console.WriteLine(p);
            }
           
        }
    }
}
