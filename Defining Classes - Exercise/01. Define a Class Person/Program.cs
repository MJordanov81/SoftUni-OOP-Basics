using System;
using System.Reflection;

namespace _01.Define_a_Class_Person
{
    public class Program
    {
        static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();

            var familyMembers = int.Parse(Console.ReadLine());
            for (int i = 0; i < familyMembers; i++)
            {
                var input = Console.ReadLine().Split();

                var currentPerson = new Person();
                currentPerson.name = input[0];
                currentPerson.age = int.Parse(input[1]);

                family.AddMember(currentPerson);
            }

            family.GetMembersAged30AndMore().ForEach(member =>
            {
                Console.WriteLine(member.name + " - " + member.age);
            });
        }
    }
}
