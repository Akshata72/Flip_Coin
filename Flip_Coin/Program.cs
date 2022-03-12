
namespace FlipCoin
{
    class FlipCoin
    {
        public static void Main(string[] args)
        {
            int Tail = 0;
            int Head = 0;

            Console.WriteLine("Enter Number of Times to FlipCoin:");
            int NumFlipCoin = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumFlipCoin; i++)
            {

                Random random = new Random();

                double test = random.NextDouble();


                if (test < 0.5)
                {
                    Tail++;
                }
                else
                {
                    Head++;
                }


            }
            Console.WriteLine("Number of Time Tails:" + Tail);
            Console.WriteLine("Number of Time Heads:" + Head);

            double Percentage_Of_Head = (double)Head / NumFlipCoin * 100;
            Console.WriteLine("Percentage of head:" + Percentage_Of_Head);

            double Percentage_Of_Tail = (double)Tail / NumFlipCoin * 100;
            Console.WriteLine("Percentage of Tail:" + Percentage_Of_Tail);
            

        }

    }
}

