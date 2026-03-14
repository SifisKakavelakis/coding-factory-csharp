using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractApp
{
    internal abstract class AbstractAnimal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Age { get; set; }

        public abstract override string ToString();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

    }
}