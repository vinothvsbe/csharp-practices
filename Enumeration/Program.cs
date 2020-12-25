using System;
using System.Collections;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------IEnumerator----------");
            Garage carLot=new Garage();
            foreach (Car car in carLot)
            {
                Console.WriteLine(car.CarName);
            }
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string CarName { get; set; }
        public int Speed { get; set; }
        public Car(string carName, int speed)
        {
            CarName = carName;
            Speed = speed;
        }         
    }

    public class Garage: IEnumerable
    {
        public Car[] carArray = new Car[5];
        public Garage()
        {
            carArray[0]=new Car("Magnite", 140);
            carArray[1]=new Car("Kwid", 130);
            carArray[2]=new Car("Nexon", 130);
            carArray[3]=new Car("Innova", 180);
            carArray[4]=new Car("XUV", 170);
        }
        public IEnumerator GetEnumerator(){
            return carArray.GetEnumerator();
        }
    }
}
