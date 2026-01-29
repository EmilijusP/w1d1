using AnagramSolver.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramSolver.BusinessLogic.Services
{
    public class WordProcessor : IWordProcessor
    {
        public Dictionary<char, int> CreateCharCount(string stringToProcess)
        {
            var charDictionary = new Dictionary<char, int>();

            foreach (var character in stringToProcess)
            {
                if (!charDictionary.ContainsKey(character))
                    charDictionary[character] = 0;
                charDictionary[character]++;
            }

            return charDictionary;
        }

        public string SortString(string unsortedString)
        {
            char[] arr = unsortedString.ToCharArray();
            Array.Sort(arr);
            string sortedString = new string(arr);
            return sortedString;
        }

        public string RemoveWhitespace(string stringToProcess)
        {
            return stringToProcess.Replace(" ", "");
        }
    }
}
