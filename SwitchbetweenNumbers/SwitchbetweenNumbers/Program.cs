namespace SwitchbetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("see arv jääb vahemikku alates(0–100)");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("see arv jääb vahemikku alates(101–200)");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("see arv jääb vahemikku alates(201–300)");
                    break;

                default:
                    Console.WriteLine("see arv jääb vahemikku alates(0–300).");
                    break;
            }
        }
    }
}
