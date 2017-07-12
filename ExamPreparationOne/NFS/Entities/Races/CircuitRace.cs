public class CircuitRace : Race
{
    private int laps;

    public int Laps
    {
        get { return laps; }
        set { laps = value; }
    }

    public CircuitRace(int length, string route, int prizePool, int laps) 
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }
}

