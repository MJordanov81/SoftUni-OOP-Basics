using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warsList;
    private int warsCount;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation("Air")},
            {"Water", new Nation("Water")},
            {"Fire", new Nation("Fire")},
            {"Earth", new Nation("Earth")}
        };
        this.warsList = new List<string>();
        this.warsCount = 1;
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondaryParameter = double.Parse(benderArgs[3]);

        var bender = BenderFactory.MakeBender(type, name, power, secondaryParameter);

        this.nations[type].Benders.Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        var monument = MonumentFactory.MakeMonument(type, name, affinity);

        this.nations[type].Monuments.Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        return this.nations[nationsType].ToString(nationsType);
    }

    public void IssueWar(string nationsType)
    {
        Battle battle = new Battle(this.nations);

        var winner = battle.GetWinnerType();

        foreach (var nation in this.nations)
        {
            if (nation.Key != winner)
            {
                nation.Value.Benders.Clear();
                nation.Value.Monuments.Clear();
            }
        }

        this.warsList.Add($"War {warsCount} issued by {nationsType}");
        warsCount++;
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();

        if (this.warsList.Count > 0)
        {
            foreach (var war in this.warsList)
            {
                sb.AppendLine(war);
            }
        }

        return sb.ToString().Trim();
    }
}

