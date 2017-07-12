public static class BenderFactory
{
    public static Bender MakeBender(string type, string name, int power, double secondaryParameter)
    {
        Bender bender = null;
        switch (type)
        {
            case "Air":
                bender = new AirBender(name, power, secondaryParameter);
                break;

            case "Water":
                bender = new WaterBender(name, power, secondaryParameter);
                break;

            case "Fire":
                bender = new FireBender(name, power, secondaryParameter);
                break;

            case "Earth":
                bender = new EarthBender(name, power, secondaryParameter);
                break;
        }

        return bender;
    }
}

