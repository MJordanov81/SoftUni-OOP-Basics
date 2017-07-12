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
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    public Garage Garage
    {
        get { return garage; }
        set { garage = value; }
    }

    public Dictionary<int, Race> Races
    {
        get { return races; }
        set { races = value; }
    }

    public Dictionary<int, Car> Cars
    {
        get { return cars; }
        set { cars = value; }
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
        var currentCar = this.Cars[carId];
        var currentRace = this.Races[raceId];

        if (!this.Garage.ParkedCars.Contains(currentCar))
        {
            if (this.Races.ContainsKey(raceId))
            {
                if (currentRace is TimeLimitRace)
                {
                    if (currentRace.Participants.Count == 0)
                    {
                        currentRace.Participants.Add(currentCar);
                    }
                }
                else
                {
                    currentRace.Participants.Add(currentCar);
                }               
            }
        }
    }

    public string Start(int id)
    {
        if (this.Races.ContainsKey(id))
        {
            if (this.Races[id].Participants.Count <= 0)
            {
                return "Cannot start the race with zero participants.\n";
            }
            else
            {
                var result = CalculateWinnersAndPrizes.CalculateAndPrintWinnersAndPrizes(this.Races[id]);

                if (this.Races[id] is CircuitRace)
                {
                    DecreaseDurability(Races[id]);
                }

                this.Races.Remove(id);
                return result;
            }
        }

        return String.Empty;
    }

    public void Park(int id)
    {
        var currentCar = this.Cars[id];

        bool carIsNotParticipant = true;

        foreach (var race in this.Races)
        {
            if (race.Value.Participants.Contains(currentCar))
            {
                carIsNotParticipant = false;
                break;
            }
        }

        if (carIsNotParticipant)
        {
            this.Garage.ParkedCars.Add(currentCar);
        }
    }

    public void Unpark(int id)
    {
        var currentCar = this.Cars[id];

        if (this.Garage.ParkedCars.Contains(currentCar))
        {
            this.Garage.ParkedCars.Remove(currentCar);
        }

    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.Garage.ParkedCars.Count > 0)
        {
            foreach (var car in this.Garage.ParkedCars)
            {
                car.Horsepower += tuneIndex;
                car.Suspension += tuneIndex / 2;

                if (car is ShowCar)
                {
                    (car as ShowCar).Stars += tuneIndex;
                }

                else 
                {
                    (car as PerformanceCar).AddOns.Add(addOn);
                }
            }
        }
    }

    private void DecreaseDurability(Race race)
    {
        foreach (var car in race.Participants)
        {
            car.Durability -= (race as CircuitRace).Laps * race.Length * race.Length;
        }
    }
}

