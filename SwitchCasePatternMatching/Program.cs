using System;

namespace SwitchCasePatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Language choice");
            Console.WriteLine("1 => Python");
            Console.WriteLine("2 => C#");
            Console.WriteLine("3 => GoLang");
            Console.WriteLine("4 => Haskel");
            var userInput = Console.ReadLine();
            object userChoice = int.TryParse(userInput.ToString(), out int val)?val:userInput;
            switch(userChoice){
                case int i when i==1:
                case string s when s.ToLower()=="python":
                    Console.WriteLine("Selected Python");
                break;
                case int i when i==2:
                case string s when s.ToLower()=="c#":
                    Console.WriteLine("Selected C#");
                break;
                case int i when i==3:
                case string s when s.ToLower()=="golang":
                    Console.WriteLine("Selected GoLang");
                break;
                case int i when i==4:
                case string s when s.ToLower()=="haskel":
                    Console.WriteLine("Selected Haskel");
                break;
                default:
                    Console.WriteLine("Selected language not in the list");
                break;
            }
            Console.ReadKey(true);
        }
    }
}
