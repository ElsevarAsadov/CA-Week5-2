namespace IDK2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * isGreedy parametri Regex deki 'g' - flagina uygun gelir.
             * 
             * default olaraq greedy kimi yoxlamir.
             * 
             */


            //TASK1
            Console.WriteLine("Salam BB206, necəsiniz BB206əhli ".MatchWordCount("BB206", false));
            Console.WriteLine("Salam BB206, necəsiniz BB206əhli ".MatchWordCount("BB206", true) == 2);

            Console.WriteLine("BB206 BB206 fgfgfgfgBB206gfgfgf gfgfgBB206  BB206 ".MatchWordCount("BB206", true) == 5);

            //TASK2
            Console.WriteLine(3553.IsPolindrom() == true);
            Console.WriteLine(1553.IsPolindrom() == false);

            //TASK3
            Console.WriteLine("BB206 is a codder team".HasAnyDigit() == true);
            Console.WriteLine("Alex is a codder".HasAnyDigit() == false);

        }
    }
}