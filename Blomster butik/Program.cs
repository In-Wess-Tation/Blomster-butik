namespace Blomster_butik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            Console.WriteLine(o1.ToString());

            Order o2 = new Order();
            Console.WriteLine(o2.ToString());

            Order o3 = new Order();
            Console.WriteLine(o3.ToString());

            Order o4 = new Order();
            Console.WriteLine(o4.ToString());



            Console.ReadKey();
        }
    }
}
