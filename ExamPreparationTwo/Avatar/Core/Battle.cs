using System.Collections.Generic;
using System.Linq;

public class Battle
{
    private Dictionary<string, Nation> nations;

    public Battle(Dictionary<string, Nation> nations)
    {
        this.nations = nations;
    }

    public string GetWinnerType()
    {
        var maxPower = 0.0;
        var winnerType = string.Empty;
        var count = 0;

        foreach (var nation in this.nations.Values.ToList())
        {
            var nationsPower = nation.CalcNationPower();

            if (count == 0)
            {
                maxPower = nationsPower;
                winnerType = nation.Name;
                count++;
            } 

            else
            {
                if (nationsPower > maxPower)
                {
                    maxPower = nationsPower;
                    winnerType = nation.Name;
                }
            }
        }

        return winnerType;
    }
}

