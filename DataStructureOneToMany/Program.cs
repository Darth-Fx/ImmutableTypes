using System;

namespace DataStructureOneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var k1 = Key.Create();
            var k2 = Key.Create();
            Console.WriteLine($"Compare Keys: result={k1.Equals(k2)}");
            Console.ReadLine();
        }
    }
}
