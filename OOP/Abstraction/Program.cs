// Abstraction in C# is a fundamental concept that allows us to hide complex implementation details and expose only the necessary parts of an object.
// We have to use abstract keyword to define an abstract class or method.
// An abstract class cannot be instantiated (we cannot create an instance of it) directly and can contain abstract methods that must be implemented by derived classes.



abstract class Animal
{
    public abstract void animalSound(); // it does not have a body
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow meow");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Animal dog = new Animal(); //  Cannot create an instance of the abstract type or interface 'Animal'

         Cat cat = new Cat(); // Only accessible through derived class
        cat.animalSound();
    }
}