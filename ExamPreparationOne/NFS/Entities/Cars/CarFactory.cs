using System.ComponentModel;

public static class CarFactory
{
    public static Car MakeCar(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car car = null;

        switch (type.ToLower())
        {
            case "performance": car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "show": car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
        }

        return car;
    }
}

