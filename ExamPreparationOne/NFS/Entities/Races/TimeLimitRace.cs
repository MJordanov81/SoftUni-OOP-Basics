public class TimeLimitRace : Race
{
    private int goldTime;

    public int GoldTime
    {
        get { return goldTime; }
        set { goldTime = value; }
    }


    public TimeLimitRace(int length, string route, int prizePool, int goldTime) 
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }
}

