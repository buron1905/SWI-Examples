namespace SWI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDemo demo = new DemeterViolation();
            demo.RunExample();
        }
    }
}