using System.Runtime.Serialization;

public abstract class Bender
{
    private string name;
    private int power;
    private double secondaryParameter;

    protected Bender(string name, int power, double secondaryParameter)
    {
        this.Name = name;
        this.Power = power;
        this.SecondaryParameter = secondaryParameter;
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double SecondaryParameter
    {
        get { return secondaryParameter; }
        set { secondaryParameter = value; }
    }

    public double CalcPower()
    {
        return this.Power * this.SecondaryParameter;
    }

    public override string ToString()
    {
        return "";
    }
}

