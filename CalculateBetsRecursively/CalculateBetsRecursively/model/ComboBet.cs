namespace CalculateBetsRecursively.model;

public class ComboBet(List<IBet> bets) : IBet
{
    private List<IBet> Bets { get; set; } = bets;
    public double GetWinnings()
    {
        return bets.Sum(bet => bet.GetWinnings());
    }
}