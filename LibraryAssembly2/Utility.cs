namespace LibraryAssembly2
{
    public class Utility
    {
        public static string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("O");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
