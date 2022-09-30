namespace Semaine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exer1();
            exer2();
        }
        static void exer1()
        {
            int ctndwn = 0;

            Console.WriteLine("Give me a number and I shall count down to 0 :");
            int.TryParse(Console.ReadLine(), out ctndwn);

            while(ctndwn > 0)
            {
                ctndwn--;
                Console.WriteLine(ctndwn);
                Thread.Sleep(1000);
            }
        }
        static void exer2()
        {
            int[] Vals = { };
            int Val = 0;

            Console.WriteLine("Give me numbers and I shall count how " +
                              "many negatives and positives are there :");

            int.TryParse(Console.ReadLine(), out Val);
            
        }
    }
}