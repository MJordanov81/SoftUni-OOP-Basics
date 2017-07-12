public class WaterMonument : Monument
{
    public WaterMonument(string name, int waterAffinity) 
        : base(name, waterAffinity)
    {
    }

    public override string ToString()
    {
        return $"###Water Monument: {this.Name}, Water Affinity: {this.Affinity}";
    }
}

