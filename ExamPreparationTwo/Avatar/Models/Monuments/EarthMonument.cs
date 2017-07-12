public class EarthMonument : Monument
{
    public EarthMonument(string name, int earthAffinity) 
        : base(name, earthAffinity)
    {
    }

    public override string ToString()
    {
        return $"###Earth Monument: {this.Name}, Earth Affinity: {this.Affinity}";
    }
}

