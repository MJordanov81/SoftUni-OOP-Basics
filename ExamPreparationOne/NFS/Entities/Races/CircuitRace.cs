using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public int Laps
    {
        get { return laps; }
    }

    public CircuitRace(int length, string route, int prizePool, int laps) 
        : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public void DecreaseDurability()
    {
        foreach (var car in this.participants)
        {
            car.DecreaseDurability(this.laps * this.length * this.length);
        }
    }


    public override void CalculatePoints()
    {
        foreach (var car in this.participants)
        {
            car.CarPoints = car.Horsepower / car.Acceleration + car.Suspension + car.Durability;

            for (int i = 0; i < this.Laps; i++)
            {
                car.CarPoints -= this.length * this.length;
            }
        }
    }

    public override string GetWinnersPrintout()
    {
        StringBuilder result = new StringBuilder();
        var firstPrize = (this.prizePool * 40) / 100;
        var secondPrize = (this.prizePool * 30) / 100;
        var thirdPrize = (this.prizePool * 20) / 100;
        var fourthPrize = (this.prizePool * 10) / 100;

        var place = 1;

        result.Append($"{this.route} - {this.length * this.laps}\n");

        foreach (var car in this.participants
            .OrderByDescending(x => x.CarPoints)
            .Take(4))
        {
            if (place == 1)
            {
                result.Append($"1. {car.Brand} {car.Model} {car.CarPoints}PP - ${firstPrize}\n");
            }
            else if (place == 2)
            {
                result.Append($"2. {car.Brand} {car.Model} {car.CarPoints}PP - ${secondPrize}\n");
            }
            else if (place == 3)
            {
                result.Append($"3. {car.Brand} {car.Model} {car.CarPoints}PP - ${thirdPrize}\n");
            }
            else
            {
                result.Append($"4. {car.Brand} {car.Model} {car.CarPoints}PP - ${fourthPrize}\n");
            }

            place++;
        }

        this.DecreaseDurability();
        return result.ToString();
    }
}

