using System;


namespace  ClassAndObject
{
    class Car 
  {
    string color = "Red"; //it is field
    string model = "Mahindra"; // it is field

    public void Start() // it is a method
    {
      Console.WriteLine("The car 🚗 is starting 💨");
    }
  static void Main(string[] args)
    {
      Car myCar = new Car();
      Console.WriteLine($"My 🚗 color is : {myCar.color} ");
      Console.WriteLine($"My 🚗 model is : {myCar.model} ");
      myCar.Start();
    }
  }
}

