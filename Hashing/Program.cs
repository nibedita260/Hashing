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
                Console.WriteLine("Choose 1.FrequencyOfWordsInSentence 2.FrequencyOfWordsInSentence 3.RemovalOfWords");
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
                    case 3:
                        MyMapNode<string, int> hashObj1 = new MyMapNode<string, int>(5);
                        string[] Paragraph1;
                        string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        Paragraph1 = input1.Split(' ');
                        int count = 1;
                        foreach (string i in Paragraph1)
                        {
                            count = hashObj1.CheckHash(i);
                            if (count > 1)
                            {
                                hashObj1.Add(i, count);
                            }
                            else
                            {
                                hashObj1.Add(i, 1);
                            }
                        }
                        IEnumerable<string> unique = Paragraph1.Distinct<string>();
                        foreach (var i in unique)
                        {
                            hashObj1.Display(i);
                        }
                        Console.WriteLine("\nEnter the word which you want to remove in paragraph");
                        string removeWord = Console.ReadLine();
                        hashObj1.Remove(removeWord);
                        foreach (var i in unique)
                        {
                            hashObj1.Display(i);
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