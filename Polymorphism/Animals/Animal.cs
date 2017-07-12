
public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual string ExplainMyself()
    {
        return string.Format($"I am {this.Name} and my favourite food is {this.FavouriteFood}");
    }
}
