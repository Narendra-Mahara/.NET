// Access Modifiers are the rules which determines the accessibility of class,field, methods
// 4 major types 👍:
// 1.Private (default if not specified): 	The code is only accessible within the same class
// 2.Public : The code is accessible for all classes
// 3.Protected : The code is accessible within the same class, or in a class that is inherited from that class.
// 4. Internal : The code is only accessible within its own assembly, but not from another assembly.

namespace AccessModifiers
{
    class Student
    {
        public string name = "Narendra";
        public int age = 23;
        private int[] marks = [23, 25, 39, 29, 29];
        public void ShowDetails()
        {
            Console.WriteLine($"Name:{name}\nAge:{age}");
        }
        protected void ShowMarks()  // protected so that only inherited classes can access
        {
            Console.WriteLine("Marks:");
            foreach (int mark in marks)
            {
                Console.WriteLine($"{mark}");

            }
        }
    }

    class Parents : Student  // class Parents is inherited from student class
    {
        public void ParentTest()
        {
            Console.WriteLine("Parents Access:");
            ShowDetails(); // can access - public method
            ShowMarks(); // can access - protected method (inherited)
        }
    }

    class Neighbors
    {
        public void NeighborTest()
        {
            Console.WriteLine("\nNeighbor Access:");
            Student student = new Student(); // Create an instance first
            student.ShowDetails(); // Now can access - public method through instance
            // student.ShowMarks(); // Still can't access - protected method (not inherited)
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Parents father = new Parents();
            father.ParentTest();

            Neighbors ram = new Neighbors();
            ram.NeighborTest(); // Demonstrate limited access

        }
    }
}

