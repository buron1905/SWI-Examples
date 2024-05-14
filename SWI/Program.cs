namespace SWI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov substitutability principle");
            IDemo demoLiskov = new LiskovViolation();
            demoLiskov.RunExample();

            Console.WriteLine("Demeter Violation: ");
            IDemo demoDemeter = new DemeterViolation();
            demoDemeter.RunExample();
        }
    }
}