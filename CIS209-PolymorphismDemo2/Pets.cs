using System;

namespace CIS209_PolymorphismDemo2
{
    // Pet is the parent class and
    // is declared abstract so it can not be instantiated
    abstract class Pet
    {
        // These properties are set by the constructor
        // and are read-only thereafter
        public string Name { get; }
        public string Type { get; }
        public DateTime TimeStamp { get; }

        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
            TimeStamp = DateTime.Now;
        }
    }

    // Fish is a child class of Pet
    class Fish : Pet
    {
        // Class the constructor in the parent class
        public Fish(string name) : base(name, "fish")
        {
        }
    }

    // Bird is a child class of Pet
    class Bird : Pet
    {
        // Class the constructor in the parent class
        public Bird(string name) : base(name, "bird")
        {
        }
    }
}
