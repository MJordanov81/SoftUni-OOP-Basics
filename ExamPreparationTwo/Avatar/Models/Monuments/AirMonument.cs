public class AirMonument : Monument
{
    public AirMonument(string name, int airAffinity) 
        : base(name, airAffinity)
    {
    }

    public override string ToString()
    {
        return $"###Air Monument: {this.Name}, Air Affinity: {this.Affinity}";
    }
}

