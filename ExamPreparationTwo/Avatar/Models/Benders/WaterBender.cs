public class WaterBender : Bender
{

    public WaterBender(string name, int power, double secondaryParameter) 
        : base(name, power, secondaryParameter)
    {
    }

    public override string ToString()
    {
        return $"###Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.SecondaryParameter:f2}";
    }
}

