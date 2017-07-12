using System.Text;

public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
            
        }

        public override string ExplainMyself()
        {
            var output = new StringBuilder();
            output.Append(base.ExplainMyself() + "\n");
            output.Append("MEEOW");
            return output.ToString();
        }
    }
