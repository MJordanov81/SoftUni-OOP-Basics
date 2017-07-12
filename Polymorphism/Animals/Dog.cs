using System.Text;

public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base (name, favouriteFood)
        {
            
        }

        public override string ExplainMyself()
        {
            var output = new StringBuilder();
            output.Append(base.ExplainMyself() + "\n");
            output.Append("DJAAF");
            return output.ToString();
        }
    }
