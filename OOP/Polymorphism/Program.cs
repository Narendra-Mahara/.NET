// Polymorphism means many forms which allows methods to do different things based on the object it is acting upon. It means that a single function or method can behave differently based on the object that it is called on.
// We should use virtual (in the base class) and override (in the derived class) keywords to achieve polymorphism in C#.
// We should use polymorphism when we want to define a method in a base class and then provide specific implementations in derived classes.

namespace Polymorphism
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal is making sound");
        }
    }


    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat says: meow meow ");
        }
    }
    class Cow : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cow says: mow mow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism example in C#");

            Animal myAnimal = new Animal();
            myAnimal.Sound();
            Animal myCat = new Cat();
            myCat.Sound();

            Animal myCow = new Cow();
            myCow.Sound();
        }
    }

}