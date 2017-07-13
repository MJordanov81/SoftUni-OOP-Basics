using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    protected int horsepower;
    private int acceleration;
    protected int suspension;
    private int durability;
    private int carPoints;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public int Durability
    {
        get { return durability; }
    }

    public virtual int Suspension
    {
        get { return suspension; }
    }

    public int Acceleration
    {
        get { return acceleration; }
    }

    public virtual int Horsepower
    {
        get { return horsepower; }
    }

    public string Model
    {
        get { return model; }
    }

    public string Brand
    {
        get { return brand; }
    }

    public int CarPoints
    {
        get { return this.carPoints; }
        set { this.carPoints = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        result.AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s");
        result.AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

        return result.ToString().Trim();
    }

    public virtual void TuneCar(int tuneIndex, string addOn)
    {
        this.horsepower += tuneIndex;
        this.suspension += tuneIndex / 2;
    }

    public void DecreaseDurability(int decrease)
    {
        this.durability -= decrease;
    }
}

