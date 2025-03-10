namespace StringManipulation1;

public class StringManipulationTests
{
    [TestCase("Hello", "ell")]
    [TestCase("Hola", "ol")]
    [TestCase("ol", "ol")]
    public void RemoveFirstAndLastCharacterFromString(string input, string expected)
    {
        Solution solution = new Solution();
        string result = solution.Remove(input);
        Assert.That(expected, Is.EqualTo(result));
    }
}