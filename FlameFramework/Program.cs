namespace FlameFramework
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("HELLO");
            await Task.Delay(100);
            Console.WriteLine("WORLD");
        }
    }
}