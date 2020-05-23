using System;

namespace DataStructureOneToMany
{
    public class Demo01Demo : RunBase
    {
        protected override int DemoNumber { get; } = 1;
        protected override void Implementation()
        {
            var k1 = Key.Create();
                var k2 = Key.Create();
                var equality = k1.Equals(k2);
                Console.WriteLine("adasdasdsadsad");
                Console.WriteLine($"Compare Keys: result={equality}");
                //Console.ReadLine();
        }

    }
}