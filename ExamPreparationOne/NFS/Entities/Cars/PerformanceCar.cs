using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.horsepower += base.horsepower * 50 / 100;
        this.suspension -= base.suspension * 25  / 100;
        this.addOns = new List<string>();
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine(base.ToString());

        if (this.addOns.Count == 0)
        {
            result.AppendLine($"Add-ons: None");
        }
        else
        {
            result.AppendLine($"Add-ons: {string.Join(", ", this.addOns)}");
        }

        return result.ToString().Trim();
    }

    public override void TuneCar(int tuneIndex, string addOn)
    {
        base.TuneCar(tuneIndex, addOn);

        this.addOns.Add(addOn);
    }
}

