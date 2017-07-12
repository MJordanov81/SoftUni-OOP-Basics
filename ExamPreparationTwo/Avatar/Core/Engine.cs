using System;

public class Engine
{
    public static void RunEngine()
    {
        NationsBuilder nb = new NationsBuilder();
        CommandInterpreter interpreter = new CommandInterpreter(nb);
        var input = Console.ReadLine();

        while (input != "Quit")
        {
            var commandArgs = input.Split(' ');
            interpreter.InterpreteCommand(commandArgs);

            input = Console.ReadLine();
        }


        interpreter.InterpreteCommand(input.Split());
    }
}

