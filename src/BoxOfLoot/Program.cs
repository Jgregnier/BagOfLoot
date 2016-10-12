using System;
using BoxOfLoot.Bags;

namespace BoxOfLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bag BagOLoot = new Bag();

            while (true)
            {
                string input = Console.ReadLine();

                string[] inputArray = input.Split(new char[] { ' ' });

                if (inputArray[0] == "add")
                {
                    BagOLoot.Add(inputArray[1], inputArray[2]);
                    Console.WriteLine($"You Added {inputArray[1]} and gave them the toy {inputArray[2]} \r\n");
                }
                else if (inputArray[0] == "ls")
                {
                    BagOLoot.listChildren();
                    Console.Write("\r\n");
                }
                else if(inputArray[0] == "remove")
                {
                    BagOLoot.removeChild(inputArray[1]);
                    Console.Write("\r\n");
                }
                else
                {
                    Console.WriteLine("I'm sorry thats not an available command, the available commands are add, remove, and ls");
                }
            }
        }
    }
}
