using System;

namespace ExceptionTest
{
    public static class ExceptionWithThrow
    {
        public static void Do()
        {
            try
            {                   
                Bar.Do(3);
                Bar.Do(2);
                Bar.Do(1);
                Bar.Do(0);
            }
            catch (DivideByZeroException)
            {
                //log message and rethrow...
                throw;
            }
        }
    }
}