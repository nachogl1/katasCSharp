namespace EvenOrOdd;

public class Checker
{
    public string CheckNumber(int input)
    {
        return input % 2 == 0 ? "Even" : "Odd";
    }
}