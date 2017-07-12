using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Horsepower += base.Horsepower * 50 / 100;
        this.Suspension -= base.Suspension * 25  / 100;
        this.AddOns = new List<string>();
    }

    public List<string> AddOns
    {
        get { return addOns; }
        set { addOns = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine(base.ToString());

        if (this.AddOns.Count == 0)
        {
            result.AppendLine($"Add-ons: None");
        }
        else
        {
            result.AppendLine($"Add-ons: {string.Join(", ", this.AddOns)}");
        }

        return result.ToString().Trim();
    }
}

