using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramSolver.BusinessLogic.Services
{
    public class InputValidation
    {
        public bool IsValidInput(string input, int minWordLength)
        {
            bool isValid = true;
            foreach (string word in input.Split())
            {
                if (word.Length < minWordLength)
                    isValid = false;
            }

            return isValid;
        }
    }
}
