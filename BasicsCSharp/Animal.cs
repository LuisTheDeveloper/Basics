using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsCSharp
{
    // Abstract class defines the base class, which is a class that has the most basic definitions.
    abstract class Animal
    {
        public abstract void animalSound();
        public virtual void sleep() // This method cannot be changed by the child class
        {
            Console.WriteLine("zzz");
        }

    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("barking");
        }
    }
}
