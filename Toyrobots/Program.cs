using System;

namespace Toyrobots
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyRobotResult output;


            output = new ToyRobotResult();
            string[] inputs = { "PLACE 1,2,EAST",
                "MOVE",
                "MOVE",
                "LEFT",
                "MOVE",
                "REPORT",
                "MOVE",
                "MOVE",
                "RIGHT",
                "MOVE",
                "REPORT" };
            foreach (var input in inputs) {
                output.Add(input);
            }
            Console.WriteLine(output.ToString());
            Console.WriteLine("--- Press Enter to Finish ---");
            Console.ReadLine();
        }

    }
}
