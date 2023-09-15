namespace firstLoopTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; 
            for (int i = 1;i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    count++;
                    Console.Write(count + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}