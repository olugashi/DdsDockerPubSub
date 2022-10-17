using System;

namespace DDSSubscriber
{
    internal class Program
    {
        static readonly int Domain = 45;
        static readonly int SampleCount = 1000;
        static void Main(string[] args)
        {

            Console.WriteLine($"Running HelloWorldSubscriber on domain {Domain}");
            HelloWorldSubscriber.RunSubscriber(Domain, SampleCount);
        }
    }
}
