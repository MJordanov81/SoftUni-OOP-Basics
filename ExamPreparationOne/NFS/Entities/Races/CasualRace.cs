using System.Collections.Generic;
using System.Linq;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override void CalculatePoints()
    {
        foreach (var car in this.participants)
        {
            car.CarPoints = car.Horsepower / car.Acceleration + car.Suspension + car.Durability;
        }
    }
}

