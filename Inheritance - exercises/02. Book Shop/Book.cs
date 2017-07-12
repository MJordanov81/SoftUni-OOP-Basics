using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get { return price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                else
                {
                    price = value;
                }
            }
        }


        public string Author
        {
            get { return author; }
            protected set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value) && value.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Length > 1 && char.IsDigit(value.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                else
                {
                    author = value;
                }
            }
        }

        public string Title
        {
            get { return title; }
            protected set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else
                {
                    title = value;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
