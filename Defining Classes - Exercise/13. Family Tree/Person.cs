using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Family_Tree
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string birthDate;
        private List<Person> parentsList;
        private List<Person> childrenList;


        public List<Person> Children
        {
            get { return childrenList; }
            set { childrenList = value; }
        }

        public List<Person> Parents
        {
            get { return parentsList; }
            set { parentsList = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override string ToString()
        {
            var parentsSb = new StringBuilder();
            foreach (var parent in parentsList)
            {
                parentsSb.Append($"{parent.FirstName} {parent.LastName} {parent.BirthDate}\n");
            }

            var childrenSb = new StringBuilder();
            foreach (var child in childrenList)
            {
                childrenSb.Append($"{child.FirstName} {child.LastName} {child.BirthDate}\n");
            }

            var result = new StringBuilder();

            result.Append($"{this.FirstName} {this.LastName} {this.BirthDate}\n");
            result.Append($"Parents:\n");
            result.Append(parentsSb);
            result.Append($"Children:\n");
            result.Append(childrenSb);
            return result.ToString().Trim();
        }
    }
}
