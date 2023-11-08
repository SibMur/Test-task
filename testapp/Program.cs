
namespace testapp
{
    public class Programm
    {
        public static void Main()
        {
            Parallel.For(0, 100, i =>
            {
                if (i == 5 || i == 98 || i == 56)
                    Server.AddToCount(5);
                Console.WriteLine(i + " " + Server.GetCount());
            }            
            
            );
        }
    }
}