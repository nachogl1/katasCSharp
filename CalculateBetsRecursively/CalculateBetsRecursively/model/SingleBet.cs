namespace CalculateBetsRecursively.model;

public class SingleBet(double stake, double odds) : IBet
{
    private double Stake { get; } = stake;
    private double Odds { get; } = odds;

    public double GetWinnings()
    {
        return stake * Odds;
    }
}