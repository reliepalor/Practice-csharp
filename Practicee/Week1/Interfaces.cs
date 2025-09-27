using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Interfaces
    {
        public void Run()
        {
            Console.WriteLine("INTERFACE\n");

            Water water = new Water();
            Soda soda = new Soda();
            Milk milk = new Milk();

            water.Healthy();
            soda.NotHealthy();
            milk.Healthy();
            milk.NotHealthy();
        }
        interface INotHealthy
        {
            void NotHealthy();
        }
        interface IHealthy
        {
            void Healthy();
        }
        class Water : IHealthy
        {
            public void Healthy()
            {
                Console.WriteLine("This water drinks is healthy");
            }
        }
        class Soda : INotHealthy
        {
            public void NotHealthy()
            {
                Console.WriteLine("This soda drinks is not healthy");
            }
        }

        class Milk : IHealthy, INotHealthy
        {
            public void Healthy()
            {
                Console.WriteLine("Sometimes milk is healthy");
            }
            public void NotHealthy()
            {
                Console.WriteLine("sometimes milk is not healthy");
            }
        }
    }
}
