public class EarthBender : Bender
{
    public EarthBender(string name, int power, double secondaryParameter) 
        : base(name, power, secondaryParameter)
    {
    }

    public override string ToString()
    {
        return $"###Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.SecondaryParameter:f2}";
    }
}

