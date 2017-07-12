public static class MonumentFactory
{
    public static Monument MakeMonument(string type, string name, int affinity)
    {
        Monument monument = null;

        switch (type)
        {
            case "Air":
                monument = new AirMonument(name, affinity);
                break;

            case "Water":
                monument = new WaterMonument(name, affinity);
                break;

            case "Fire":
                monument = new FireMonument(name, affinity);
                break;

            case "Earth":
                monument = new EarthMonument(name, affinity);
                break;
        }

        return monument;
    }
}

