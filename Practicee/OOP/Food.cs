namespace Practicee.OOP
{
    interface IOrderable
    {
        void Order();
    }

    internal class Food : IOrderable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = (value < 0) ? 0 : value; }
        }

        public Food(string name, double price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
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

    class Menu
    {
        private List<Food> foods = new List<Food>();

        public void AddFood(IEnumerable<Food> foodsToAdd)
        {
            foods.AddRange(foodsToAdd);
        }

        public void ShowFoods()
        {
            for (int i = 0; i < foods.Count; i++)
            {
                var food = foods[i];
                string status = food.Price > 0 ? "Available" : "Not Available";
                Console.WriteLine($"Item {i + 1} -- {food.Type} {food.Name} --- {food.Price} [{status}]");
            }
        }
        public int Count => foods.Count;
        public Food this[int index] => foods[index];
    }


    class Pizza : Food
    {
        public string Size { get; set; }

        public Pizza(string name, double price, string size)
            : base(name, price, "Pizza") // ✅ pass type
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
        public Salad(string name, double price)
            : base(name, price, "Salad") { }

        public override void Serve()
        {
            Console.WriteLine($"Serving a fresh and healthy {Name}");
        }

        public override void Order()
        {
            Console.WriteLine($"Salad ordered: {Name} for {Price}");
        }
    }

    class Burger : Food
    {
        public Burger(string name, double price)
            : base(name, price, "Burger") { }

        public override void Serve()
        {
            Console.WriteLine($"Serving a juicy {Name} with fries.");
        }

        public override void Order()
        {
            Console.WriteLine($"Burger ordered: {Name} for {Price}");
        }
    }
}
