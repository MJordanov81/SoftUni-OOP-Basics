using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }


    public int Durability
    {
        get { return durability; }
        set { durability = value; }
    }



    public virtual int Suspension
    {
        get { return suspension; }
        set { suspension = value; }
    }


    public int Acceleration
    {
        get { return acceleration; }
        set { acceleration = value; }
    }



    public virtual int Horsepower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }


    public int YearOfProduction
    {
        get { return yearOfProduction; }
        set { yearOfProduction = value; }
    }


    public string Model
    {
        get { return model; }
        set { model = value; }
    }


    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public int CarPoints { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        result.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s");
        result.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return result.ToString().Trim();
    }
}

