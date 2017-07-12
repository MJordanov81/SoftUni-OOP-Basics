using System;

public static class CommandInterpreter
{
    public static void InterpreteCommand(string[] commandInput, CarManager manager)
    {
        var command = commandInput[0];

        switch (command.ToLower())
        {
            case "register":
                manager.Register(int.Parse(commandInput[1]),
                    commandInput[2],
                    commandInput[3],
                    commandInput[4],
                    int.Parse(commandInput[5]),
                    int.Parse(commandInput[6]),
                    int.Parse(commandInput[7]),
                    int.Parse(commandInput[8]),
                    int.Parse(commandInput[9]));
                break;

            case "check":
                Console.WriteLine(manager.Check(int.Parse(commandInput[1])));
                break;

            case "open":

                if (commandInput.Length == 6)
                {
                    manager.Open(int.Parse(commandInput[1]),
                        commandInput[2],
                        int.Parse(commandInput[3]),
                        commandInput[4],
                        int.Parse(commandInput[5]));
                }
                else
                {
                    manager.Open(int.Parse(commandInput[1]),
                        commandInput[2],
                        int.Parse(commandInput[3]),
                        commandInput[4],
                        int.Parse(commandInput[5]),
                        int.Parse(commandInput[6]));
                }
                break;

            case "participate":
                manager.Participate(int.Parse(commandInput[1]), 
                    int.Parse(commandInput[2]));
                break;

            case "park":
                manager.Park(int.Parse(commandInput[1]));
                break;

            case "unpark":
                manager.Unpark(int.Parse(commandInput[1]));
                break;

            case "start":
                Console.Write(manager.Start(int.Parse(commandInput[1])));
                break;

            case "tune":
                manager.Tune(int.Parse(commandInput[1]), commandInput[2]);
                break;
        }
    }
}

