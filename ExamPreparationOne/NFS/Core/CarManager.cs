using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        var car = CarFactory.MakeCar(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        cars.Add(id, car);
    }

    public string Check(int id)
    {
        var currentCar = cars[id];
        var result = currentCar.ToString();
        return result;
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        var race = RaceFactory.MakeRace(id, type, length, route, prizePool);
        races.Add(id, race);
    }

    public void Open(int id, string type, int length, string route, int prizePool, int extraParameter)
    {
        var race = RaceFactory.MakeRace(id, type, length, route, prizePool, extraParameter);
        races.Add(id, race);
    }

    public void Participate(int carId, int raceId)
    {
        var currentCar = this.cars[carId];
        var currentRace = this.races[raceId];

        if (!this.garage.ParkedCars.Contains(currentCar))
        {
            currentRace.AddParticipant(currentCar);                  
        }
    }

    public string Start(int id)
    {
        var result = String.Empty;

        if (this.races[id].Participants.Count <= 0)
        {
            result = "Cannot start the race with zero participants.\n";
        }
        else
        {
            this.races[id].CalculatePoints();
            result = this.races[id].GetWinnersPrintout();
            this.races.Remove(id);
        }

        return result;
    }

    public void Park(int id)
    {
        var currentCar = this.cars[id];

        bool carIsNotParticipant = true;

        foreach (var race in this.races)
        {
            if (race.Value.Participants.Contains(currentCar))
            {
                carIsNotParticipant = false;
                break;
            }
        }

        if (carIsNotParticipant)
        {
            this.garage.ParkedCars.Add(currentCar);
        }
    }

    public void Unpark(int id)
    {
        var currentCar = this.cars[id];

        if (this.garage.ParkedCars.Contains(currentCar))
        {
            this.garage.ParkedCars.Remove(currentCar);
        }

    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.garage.ParkedCars.Count > 0)
        {
            foreach (var car in this.garage.ParkedCars)
            {
                car.TuneCar(tuneIndex, addOn);
            }
        }
    }
}

