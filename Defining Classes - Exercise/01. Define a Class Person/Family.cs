using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_a_Class_Person
{
    public class Family
    {
        public List<Person> listOfPeople = new List<Person>();

        public void AddMember(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.listOfPeople.OrderByDescending(person => person.age).ToList().FirstOrDefault();
        }

        public List<Person> GetMembersAged30AndMore()
        {
            return this.listOfPeople.Where(person => person.age > 30).OrderBy(person => person.name).ToList();
        }
    }
}
