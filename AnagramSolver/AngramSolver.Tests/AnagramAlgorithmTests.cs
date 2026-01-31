using AnagramSolver.BusinessLogic.Services;
using AnagramSolver.Contracts.Interfaces;

namespace AnagramSolver.BusinessLogic.Tests;

public class AnagramAlgorithmTests
{
    private readonly IAnagramAlgorithm _anagramAlgorithm;

    public AnagramAlgorithmTests()
    {
        _anagramAlgorithm = new AnagramAlgorithm();
    }
}
