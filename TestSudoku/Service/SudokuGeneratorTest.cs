using SudokuApp.Service;

namespace TestSudoku.Service;

[TestClass]
public class SudokuGeneratorTest
{
    [TestMethod]
    public void TestCtor()
    {
        new SudokuGenerator().Generate();
    }
}
