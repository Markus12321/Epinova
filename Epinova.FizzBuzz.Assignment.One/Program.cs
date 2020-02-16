namespace Epinova.FizzBuzz.Assignment.One
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = new Service(100);
            service.Process();
            service.Print();
        }
    }
}