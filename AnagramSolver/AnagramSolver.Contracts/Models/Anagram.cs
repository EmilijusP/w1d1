namespace AnagramSolver.Contracts.Models
{
    public class Anagram
    {
        public string? Key { get; set; }  

        public Dictionary<char, int>? KeyCharCount { get; set; }

        public List<string>? Words { get; set; }

    }
}
