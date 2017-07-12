namespace _01.Define_a_Class_Person
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
            :this (1, "No name")
        {
        }

        public Person (int age)
            : this (age, "No name")
        {

        }

        public Person (int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
