using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

public static class CalculateWinnersAndPrizes
{
    public static string CalculateAndPrintWinnersAndPrizes(Race race)
    {
        var result = new StringBuilder();

        var firstPrize = 0;

        var earnedTime = String.Empty;

        var isRegularRace = true;
        var isCircuitRace = false;

        foreach (var car in race.Participants)
        {
            if (race is CasualRace)
            {
                car.CarPoints = car.Horsepower / car.Acceleration + car.Suspension + car.Durability;
            }
            else if (race is DriftRace)
            {
                car.CarPoints = car.Suspension + car.Durability;
            }
            else if(race is DragRace)
            {
                car.CarPoints = car.Horsepower / car.Acceleration;
            }
            else if (race is TimeLimitRace)
            {
                car.CarPoints = race.Length * ((car.Horsepower / 100) * car.Acceleration);
                isRegularRace = false;

                if (car.CarPoints <= (race as TimeLimitRace).GoldTime)
                {
                    firstPrize = race.PrizePool * 100 / 100;
                    earnedTime = "Gold";
                }
                else if (car.CarPoints <= (race as TimeLimitRace).GoldTime + 15)
                {
                    firstPrize = race.PrizePool * 50 / 100;
                    earnedTime = "Silver";
                }
                else
                {
                    firstPrize = race.PrizePool * 30 / 100;
                    earnedTime = "Bronze";
                }
            }
            else if (race is CircuitRace)
            {
                car.CarPoints = car.Horsepower / car.Acceleration + car.Suspension + car.Durability;

                for (int i = 0; i < (race as CircuitRace).Laps; i++)
                {
                    car.CarPoints -= race.Length * race.Length;
                }
                isCircuitRace = true;
            }
        }

        if (isRegularRace && !isCircuitRace)
        {
            firstPrize = (race.PrizePool * 50) / 100;
            var secondPrize = (race.PrizePool * 30) / 100;
            var thirdPrize = (race.PrizePool * 20) / 100;

            var place = 1;

            result.AppendLine($"{race.Route} - {race.Length}");

            foreach (var car in race.Participants
                .OrderByDescending(x => x.CarPoints)
                .Take(3))
            {
                if (place == 1)
                {
                    result.AppendLine($"1. {car.Brand} {car.Model} {car.CarPoints}PP - ${firstPrize}");
                }
                else if (place == 2)
                {
                    result.AppendLine($"2. {car.Brand} {car.Model} {car.CarPoints}PP - ${secondPrize}");
                }
                else
                {
                    result.AppendLine($"3. {car.Brand} {car.Model} {car.CarPoints}PP - ${thirdPrize}");
                }

                place++;
            }
        }

        else if (isCircuitRace)
        {
            firstPrize = (race.PrizePool * 40) / 100;
            var secondPrize = (race.PrizePool * 30) / 100;
            var thirdPrize = (race.PrizePool * 20) / 100;
            var fourthPrize = (race.PrizePool * 10) / 100;

            var place = 1;

            result.AppendLine($"{race.Route} - {race.Length * (race as CircuitRace).Laps}");

            foreach (var car in race.Participants
                .OrderByDescending(x => x.CarPoints)
                .Take(4))
            {
                if (place == 1)
                {
                    result.AppendLine($"1. {car.Brand} {car.Model} {car.CarPoints}PP - ${firstPrize}");
                }
                else if (place == 2)
                {
                    result.AppendLine($"2. {car.Brand} {car.Model} {car.CarPoints}PP - ${secondPrize}");
                }
                else if (place == 3)
                {
                    result.AppendLine($"3. {car.Brand} {car.Model} {car.CarPoints}PP - ${thirdPrize}");
                }
                else
                {
                    result.AppendLine($"4. {car.Brand} {car.Model} {car.CarPoints}PP - ${fourthPrize}");
                }

                place++;
            }
        }

        else
        {
            var car = race.Participants[0];

            result.AppendLine($"{race.Route} - {race.Length}");
            result.AppendLine($"{car.Brand} {car.Model} - {car.CarPoints} s.");
            result.AppendLine($"{earnedTime} Time, ${firstPrize}.");
        }
        
        return result.ToString().Trim(' ');
    }
}

