// Constructor is special method used to initilaize the object. It is automatically called when object is created. It is used to set the initial value of the fields.
// The name of constructor should be same as the class name but without return type (void,int)
namespace Constructors
{
    class Car
    {
        public string color;
        public Car(string carColor)
        {
            color = carColor;
        }
        public void ShowDetails()
        {
            Console.WriteLine("The color of my 🚗 is: "+color);
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("Red");
            // Console.WriteLine(myCar.color);
            myCar.ShowDetails();
        }
    }
}

