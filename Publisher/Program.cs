using System;

namespace DDSPublisher
{
    internal class Program
    {
        static readonly int Domain = 45;
        static readonly int SampleCount = 1000;
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Running HelloWorldPublisher on domain {Domain}");
            HelloWorldPublisher.RunPublisher(Domain, SampleCount);
        }
    }
}
