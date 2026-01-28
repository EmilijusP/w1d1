using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AnagramSolver.BusinessLogic.Services;

namespace AnagramSolver.Cli
{
    public class UserInterface
    {
        public List<string> userWords = new List<string>();
        private readonly int _minWordLength;
        private InputValidation _wordsValidation;

        public UserInterface(int minWordLength, InputValidation wordsValidation)
        {
            _minWordLength = minWordLength;
            _wordsValidation = wordsValidation;
        }

        public List<string> ReadInput()
        {
            do
            {
                Console.WriteLine($"Enter the word/words containing {_minWordLength} letters or more: ");
                var input = Console.ReadLine();
                if (_wordsValidation.IsValidInput(input, _minWordLength))
                {
                    userWords = input.Split().ToList();
                    break;
                }

            } while (true);

            return userWords;
        }
    }
}
