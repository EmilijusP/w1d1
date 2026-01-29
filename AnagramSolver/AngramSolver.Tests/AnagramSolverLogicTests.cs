using AnagramSolver.BusinessLogic.Data;
using AnagramSolver.BusinessLogic.Services;
using AnagramSolver.Contracts.Interfaces;
using AnagramSolver.Contracts.Models;
using Moq;

namespace AngramSolver.Tests
{
    public class AnagramSolverLogicTests
    {
        [Theory]
        [InlineData ("labas", "balas")]
        [InlineData ("visma praktika", "praktikavimas")]
        public void GetAnagrams_ValidInput_ReturnsOneWordAnagrams(string inputWord, string expectedAnagram)
        {
            //arrange
            var wordSet = new HashSet<WordModel>();
            wordSet.Add(new WordModel { Word = expectedAnagram});

            var mockRepository = new Mock<IWordRepository>();
            mockRepository.Setup(repository => repository.GetWords()).Returns(wordSet);

            var anagramSolver = new AnagramSolverLogic(1, mockRepository.Object);

            //act
            var result = anagramSolver.GetAnagrams(inputWord);

            //assert
            Assert.Contains(expectedAnagram, result);
        }
    }
}