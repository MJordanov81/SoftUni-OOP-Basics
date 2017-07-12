using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private string name;
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation(string name)
    {
        this.name = name;
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public string Name
    {
        get { return this.name; }
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
    }

    public List<Monument> Monuments
    {
        get { return this.monuments; }
    }

    public string ToString(string nationsType)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{nationsType} Nation");

        if (this.benders.Count > 0)
        {
            sb.AppendLine($"Benders:");
            foreach (var bender in this.benders)
            {
                sb.AppendLine(bender.ToString());
            }
        }
        else
        {
            sb.AppendLine($"Benders: None");
        }

        if (this.monuments.Count > 0)
        {
            sb.AppendLine($"Monuments:");
            foreach (var monument in monuments)
            {
                sb.AppendLine(monument.ToString());
            }
        }
        else
        {
            sb.AppendLine($"Monuments: None");
        }

        return sb.ToString().Trim();
    }

    public double CalcNationPower()
    {
        double bendersPower = this.Benders.Sum(x => x.CalcPower());

        int monumentsPower = this.Monuments.Sum(x => x.Affinity);

        return bendersPower + bendersPower / 100 * monumentsPower;
    }
}

