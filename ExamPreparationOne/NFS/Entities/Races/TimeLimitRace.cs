using System;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public int GoldTime
    {
        get { return goldTime; }
        set { goldTime = value; }
    }


    public TimeLimitRace(int length, string route, int prizePool, int goldTime) 
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public override void AddParticipant(Car car)
    {
        if (this.participants.Count == 0)
        {
            base.AddParticipant(car);
        }
    }

    public override void CalculatePoints()
    {
        foreach (var car in this.participants)
        {
            car.CarPoints = this.length * ((car.Horsepower / 100) * car.Acceleration);
        }
    }

    public override string GetWinnersPrintout()
    {
        StringBuilder result = new StringBuilder();
        var prize = 0;
        var earnedTime = String.Empty;

        var car = this.participants[0];

        if (car.CarPoints <= this.goldTime)
        {
            prize = this.prizePool * 100 / 100;
            earnedTime = "Gold";
        }
        else if (car.CarPoints <= this.goldTime + 15)
        {
            prize = this.prizePool * 50 / 100;
            earnedTime = "Silver";
        }
        else
        {
            prize = this.prizePool * 30 / 100;
            earnedTime = "Bronze";
        }

        result.Append($"{this.route} - {this.length}\n");
        result.Append($"{car.Brand} {car.Model} - {car.CarPoints} s.\n");
        result.Append($"{earnedTime} Time, ${prize}.\n");

        return result.ToString();
    }
}

