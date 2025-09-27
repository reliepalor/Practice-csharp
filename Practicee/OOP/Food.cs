using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.OOP
{
    interface Iorderable
    {
        void Order();
    }
    internal class Food : Iorderable
    {
        private double price;

        public string Name { get; set; }
        public double Price
        {
            get { return price; }
            set { price = (value < 0) ? 0 : value; }
        }
        public Food(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Serve()
        {
            Console.WriteLine("Serving your food...");
        }

        public virtual void Order()
        {
            Console.WriteLine($"You ordered {Name} for {Price}");
        }
    }

    class Pizza : Food 
    { 
        public string Size { get; set; }

        public Pizza(string name, double price, string size) : base(name, price)
        {
            Size = size; 
        }

        public override void Serve()
        {
            Console.WriteLine($"Serving a hot {Size} {Name} with extra cheese!");
        }

        public override void Order()
        {
            Console.WriteLine($"Pizza ordered: {Size} {Name} for {Price}");
        }
    }

    class Salad : Food
    {
        public Salad(string name, double price) : base(name, price){ }

        public override void Serve()
        {
            Console.WriteLine($"Serving a fresh and healthy {Name}");
        }

        public override void Order()
        {
            Console.WriteLine($"Pizza ordered: {Name} for {Price}");
        }
    }

    class Burger : Food 
    {
        public Burger(string name, double price) : base(name, price) { }

        public override void Serve()
        {
            Console.WriteLine($"Serving a juicy {Name} with fries.");
        }

        public override void Order()
        {
            Console.WriteLine($"Pizza ordered: {Name} for {Price}");
        }
    }
}
