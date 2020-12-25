using System;

namespace InterfaceDefaultImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.NumberOfSides = 5;
            sq.SideLength=15;
            Console.WriteLine($"Permieter of Square is {((IRegularPointy)sq).Perimeter}");
            Console.WriteLine($"Aread of Square is {((IRegularPointy)sq).area()}");
        }
    }

    interface IRegularPointy{
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;
        int area(){return (SideLength*SideLength);}
    }

    class Square : IRegularPointy
    {
        public void Draw(){
            Console.WriteLine($"Drawing Square");
        }
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }

}
