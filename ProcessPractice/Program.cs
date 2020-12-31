using System;
using System.Diagnostics;

namespace ProcessPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Details:"+ Process.GetCurrentProcess().Id);
            ProcessModuleCollection pmCollection  = Process.GetProcessById(Process.GetCurrentProcess().Id).Modules;
            foreach(ProcessModule pm in pmCollection){
                Console.WriteLine("ModuleName => " + pm.ModuleName);
                
            }
            foreach(ProcessThread pt in Process.GetProcessById(Process.GetCurrentProcess().Id).Threads){
                    Console.WriteLine("Thread name => "+ pt.ThreadState);
            }
            Console.ReadLine();
        }

        private static void Line(string v)
        {
            throw new NotImplementedException();
        }
    }
}
