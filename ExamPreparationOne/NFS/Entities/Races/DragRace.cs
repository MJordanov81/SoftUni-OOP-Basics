using System.Collections.Generic;
using System.Linq;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override void CalculatePoints()
    {
        foreach (var car in this.participants)
        {
            car.CarPoints = car.Horsepower / car.Acceleration;
        }
    }
}

