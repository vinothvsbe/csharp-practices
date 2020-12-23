using System;

namespace SwitchCasePatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            // BasicPatternMatching();
            AdvancedPatternMatchinWithTuples();
        }

        private static void AdvancedPatternMatchinWithTuples()
        {
            Console.WriteLine("Pick the values for symptoms in comma seperated");
            Console.WriteLine("[1] => Cold");
            Console.WriteLine("[2] => Fever");
            Console.WriteLine("[3] => AbdomenPain");
            Console.WriteLine("[4] => Headache");
            Console.WriteLine("[5] => EyePain");
            Console.WriteLine("[6] => BodySweating");
            Console.WriteLine("[7] => HighHeartBeat");
            string[] symptomArray = {"Cold","Fever","AbdomenPain","Headache","EyePain","BodySweating","HighHeartBeat"};
            var symptoms= Console.ReadLine();
            string[] selectedSymptom = symptoms.Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
            string[] convertedSelectedSymptoms=new string[2];
            for( int i=0;i<selectedSymptom.Length;i++){
                convertedSelectedSymptoms[i]=symptomArray[int.TryParse(selectedSymptom[i], out int c1)? c1-1:0];
            }
            Console.WriteLine(convertedSelectedSymptoms[0]+" , "+ convertedSelectedSymptoms[1]);
            string problem = (convertedSelectedSymptoms[0],convertedSelectedSymptoms[1]) switch {
                ("Cold","Fever")=> "Viral Infection through Throat",
                ("AbdomenPain","Fever")=> "Food Poison",
                ("Headache","EyePain")=> "Stress",
                ("BodySweating","HighHeartBeat")=> "High BP",
                (_,_)=>"Not there in list"
            };
            Console.WriteLine(problem);
            Console.ReadLine();
        }

        static void BasicPatternMatching()
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
