using System;
using System.Collections;

namespace YieldMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            YieldMagic yieldMagic=new YieldMagic();
            IEnumerator value = yieldMagic.GetEnumerator();
            Console.WriteLine(value.Current);
            while (value.MoveNext()){
                Console.WriteLine(value.Current);
            }
            Console.ReadLine();
        }
    }
    class YieldMagic: IEnumerable{
        int[] integerArray = {1,2,3,4,5,6};
        public IEnumerator GetEnumerator(){
            throw new Exception("This wont get called!");
            return ApplyEnumeration();
            IEnumerator ApplyEnumeration(){
                foreach(var i in integerArray){
                    Console.WriteLine("Inside Yield");
                    yield return i;
                }
            }
            
            
        }
    }
}
