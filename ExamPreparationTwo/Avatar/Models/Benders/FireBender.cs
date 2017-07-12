public class FireBender : Bender
{
    public FireBender(string name, int power, double secondaryParameter) 
        : base(name, power, secondaryParameter)
    {
    }

    public override string ToString()
    {
        return $"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.SecondaryParameter:f2}";
    }
}

