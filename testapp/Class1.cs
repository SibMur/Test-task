
namespace testapp
{
    public static class Server
    {
        private static int _count = 0;

        public static void AddToCount(int value)
        {
            Interlocked.Add(ref _count, value);           
        }

        public static int GetCount()
        {
            return _count;
        }
    }
}
