using System;
using System.Collections.Generic;
using System.Linq;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashing table");
            bool isExit = false;
            int options;
            while (!isExit)
            {
                Console.WriteLine("Choose 1.FrequencyOfWordsInSentence 2.FrequencyOfWordsInSentence 3.RemovalOfWord");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                        hash.Add("0", "To");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash5 = hash.Get("5");
                        Console.WriteLine("5th index value: " + hash5);
                        break;
                    case 2:
                        MyMapNode<int, string> hashObj = new MyMapNode<int, string>(5);
                        string[] Paragraph;
                        string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        Paragraph = input.Split(' ');
                        int count = 1;
                        foreach(string i in Paragraph)
                        {
                            count++;
                            hashObj.Add(count,i);
                        }
                        
                        Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
                        IEnumerable<string> distinct = Paragraph.Distinct<string>();
                        foreach (var i in distinct)
                        {
                            //hashObj.Get(i);
                        }
                        break;
                    case 3:
                        MyMapNode<string, string> hash1 = new MyMapNode<string, string>(5);
                        hash1.Add("0", "To");
                        hash1.Add("1", "be");
                        hash1.Add("2", "or");
                        hash1.Add("3", "not");
                        hash1.Add("4", "to");
                        hash1.Add("5", "be");
                        hash1.Remove("3");
                        string res = hash1.Get("3");
                        Console.WriteLine("3th index value: " + res);
                        break;
                    default:
                        Console.WriteLine("Choose valid options");
                        break;
                }
            }
           

        }
    }
}
