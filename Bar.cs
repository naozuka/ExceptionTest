namespace ExceptionTest
{
    public static class Bar
    {
        public static void Do(int b)
        {
            int a = 1;
            int c = a/b;  // Generate divide by zero exception.
        }
    }
}