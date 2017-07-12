using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public List<string> Data
    {
        get { return data; }
        set { data = value; }
    }

    public void Push(string item)
    {
        this.Data.Insert(0, item);
    }

    public string Pop()
    {
        return this.Data.Take(1).ToList()[0];
    }

    public string Peek()
    {
        var result =  this.Data.Take(1).ToList()[0];
        this.Data.RemoveAt(0);

        return result;
    }

    public bool IsEmpty()
    {
        return this.Data.Count == 0;
    }

}

