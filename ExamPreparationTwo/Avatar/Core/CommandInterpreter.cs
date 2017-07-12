using System;
using System.Linq;

public class CommandInterpreter
{
    private NationsBuilder nationsBuilder;

    public CommandInterpreter(NationsBuilder nationsBuilder)
    {
        this.nationsBuilder = nationsBuilder;
    }

    public void InterpreteCommand(string[] commandArgs)
    {
        string command = commandArgs[0];

        switch (command)
        {
            case "Bender":
                nationsBuilder.AssignBender(commandArgs.Skip(1).ToList());               
                break;

            case "Monument":
                nationsBuilder.AssignMonument(commandArgs.Skip(1).ToList());
                break;

            case "Status":
                Console.WriteLine(nationsBuilder.GetStatus(commandArgs[1]));
                break;

            case "War":
                nationsBuilder.IssueWar(commandArgs[1]);
                break;

            default:
                Console.Write(nationsBuilder.GetWarsRecord());
                break;
        }
    }
}

