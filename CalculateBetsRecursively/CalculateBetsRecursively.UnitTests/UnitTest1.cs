using CalculateBetsRecursively.model;

namespace CalculateBetsRecursively.UnitTests;

[TestFixture]
public class Tests
{
    private IBet _bet1;
    private IBet _bet2;
    private IBet _bet3;
    private IBet _comboBet1;
    private IBet _finalBet;

    [SetUp]
    public void Setup()
    {
        _bet1 = new SingleBet(10, 2.0);
        _bet2 = new SingleBet(5, 3.0);
        _bet3 = new SingleBet(8, 1.5);

        _comboBet1 = new ComboBet([_bet2, _bet3]);
        _finalBet = new ComboBet([_bet1, _comboBet1]);
    }

    [Test]
    public void CalculateWinningsForFinalBet()
    {
        Assert.That(_finalBet.GetWinnings(), Is.EqualTo(47d));
    }
}