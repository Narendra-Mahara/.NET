using System;


namespace  ClassAndObject
{
    class Car 
  {
    string color = "Red";
    string model = "Mahindra";
  static void Main(string[] args)
    {
      Car myCar = new Car();
      Console.WriteLine($"My 🚗 color is : {myCar.color} ");
      Console.WriteLine($"My 🚗 model is : {myCar.model} ");
    }
  }
}

