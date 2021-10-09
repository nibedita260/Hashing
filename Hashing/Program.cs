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
                Console.WriteLine("Choose 1.FrequencyOfWordsInSentence 2.FrequencyOfWordsInSentence");
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
                        MyMapNode<string, int> hashObj = new MyMapNode<string, int>(5);
                        string[] Paragraph;
                        string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        Paragraph = input.Split(' ');
                        int counts = 1;
                        foreach (string i in Paragraph)
                        {
                            counts = hashObj.CheckHash(i);
                            if (counts > 1)
                            {
                                hashObj.Add(i, counts);
                            }
                            else
                            {
                                hashObj.Add(i, 1);
                            }
                        }
                        Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
                        IEnumerable<string> distinct = Paragraph.Distinct<string>();
                        foreach (var i in distinct)
                        {
                            hashObj.Display(i);
                        }
                        break;
                    default:
                        Console.WriteLine("Choose valid options");
                        break;
                }
            }
           

        }
    }
}
