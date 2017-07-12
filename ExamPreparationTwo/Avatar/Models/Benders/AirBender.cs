public class AirBender : Bender
{
    public AirBender(string name, int power, double secondaryParameter) 
        : base(name, power, secondaryParameter)
    {
    }

    public override string ToString()
    {
        return $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.SecondaryParameter:f2}";
    }
}

