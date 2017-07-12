public static class RaceFactory
{
    public static Race MakeRace(int id, string type, int length, string route, int prizePool)
    {
        Race race = null;

        switch (type.ToLower())
        {
            case "casual":
                race = new CasualRace(length, route, prizePool);
                break;

            case "drift":
                race = new DriftRace(length, route, prizePool);
                break;

            case "drag":
                race = new DragRace(length, route, prizePool);
                break;
        }

        return race;
    }

    public static Race MakeRace(int id, string type, int length, string route, int prizePool, int extraParameter)
    {
        Race race = null;

        switch (type.ToLower())
        {
            case "circuit":
                race = new CircuitRace(length, route, prizePool, extraParameter);
                break;

            case "timelimit":
                race = new TimeLimitRace(length, route, prizePool, extraParameter);
                break;
        }

        return race;
    }
}

