using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            List<List<string>> groupedAnagrams = GroupAnagrams(strs);
            foreach (List<string> anagramGroup in groupedAnagrams)
            {
                Console.WriteLine(string.Join(", ", anagramGroup));

            }
                Console.ReadLine();
        }

        static List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();
            foreach (string word in strs)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedWord = new string(charArray);
                if (anagramDict.ContainsKey(sortedWord))
                {
                    anagramDict[sortedWord].Add(word);
                }
                else
                {
                    List<string> group = new List<string> { word };
                    anagramDict.Add(sortedWord, group);
                }
            }
            List<List<string>> groupedAnagrams = new List<List<string>>(anagramDict.Values);

            return groupedAnagrams;
        }
    }
}
    
