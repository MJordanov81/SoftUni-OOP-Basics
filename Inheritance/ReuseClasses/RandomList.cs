
using System;
using System.Collections;

public class RandomList : ArrayList
{
    public string RandomString()
    {
        Random random = new Random();
        var index = random.Next(this.Count - 1);

        var result = this[index].ToString();

        RemoveAt(index);

        return result;
    }
}

