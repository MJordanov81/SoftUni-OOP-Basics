using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine(base.ToString());

        result.AppendLine($"{this.stars} *");

        return result.ToString().Trim();
    }

    public override void TuneCar(int tuneIndex, string addOn)
    {
        base.TuneCar(tuneIndex, addOn);

        this.stars += tuneIndex;
    }
}

