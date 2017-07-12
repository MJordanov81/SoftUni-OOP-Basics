public abstract class Monument 
{
    private string name;
    private int affinity;

    protected Monument(string name, int affinity)
    {
        this.name = name;
        this.Affinity = affinity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Affinity
    {
        get { return affinity; }
        set { affinity = value; }
    }

    public override string ToString()
    {
        return "";
    }
}

