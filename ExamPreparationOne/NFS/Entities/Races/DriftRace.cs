using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override void CalculatePoints()
    {
        foreach (var car in this.participants)
        {
            car.CarPoints = car.Suspension + car.Durability;
        }
    }
}

