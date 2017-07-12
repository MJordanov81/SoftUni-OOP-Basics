using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine();

        CarManager manager = new CarManager();

        while (input != "Cops Are Here")
        {
            var commandTokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim())
                .ToArray();

            CommandInterpreter.InterpreteCommand(commandTokens, manager);

            input = Console.ReadLine();
        }
    }
}

