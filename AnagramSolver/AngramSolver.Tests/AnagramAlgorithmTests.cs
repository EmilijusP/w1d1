using AnagramSolver.BusinessLogic.Services;
using AnagramSolver.Contracts.Interfaces;
using AnagramSolver.Contracts.Models;
using FluentAssertions;

namespace AnagramSolver.BusinessLogic.Tests;

public class AnagramAlgorithmTests
{
    private readonly IAnagramAlgorithm _anagramAlgorithm;

    public AnagramAlgorithmTests()
    {
        _anagramAlgorithm = new AnagramAlgorithm();
    }

    public static IEnumerable<object[]> GetAnagramTestData()
    {
        yield return new object[] 
        { 
            1, 
            new List<List<string>> 
            { 
                new List<string> { "estt" } 
            } 
        };
        yield return new object[] 
        { 
            2, 
            new List<List<string>> 
            { 
                new List<string> { "estt" }, 
                new List<string> { "est",  "t" },
                new List<string> { "es", "tt" } 
            } 
        };
        yield return new object[] 
        { 
            0, 
            new List<List<string>> 
            { 
                new List<string> { } 
            } 
        };
    }

    [Theory]
    [MemberData(nameof(GetAnagramTestData))]
    public void FindKeyCombinations(int maxWords, List<List<string>> expectedResult)
    {
        //arrange
        var dummyTargetLetters = new Dictionary<char, int>
        {
            ['t'] = 2,
            ['e'] = 1,
            ['s'] = 1
        };

        var dummyCharCount = new Dictionary<char, int>
        {
            ['e'] = 1,
            ['s'] = 1,
            ['t'] = 2
        };

        var dummyPossibleAnagrams = new List<Anagram>
        {
            new Anagram { Key = "estt", KeyCharCount = new Dictionary<char, int> {['e']=1, ['s']=1, ['t']=2} },
            new Anagram { Key = "est", KeyCharCount = new Dictionary<char, int> {['e']=1, ['s']=1, ['t']=1} },
            new Anagram { Key = "es", KeyCharCount = new Dictionary<char, int> {['e']=1, ['s']=1} },
            new Anagram { Key = "tt", KeyCharCount = new Dictionary<char, int> {['t']=2} },
            new Anagram { Key = "t", KeyCharCount = new Dictionary<char, int> {['t']=1} }
        };

        //act
        var result = _anagramAlgorithm.FindKeyCombinations(dummyTargetLetters, maxWords, dummyPossibleAnagrams);

        //assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}
