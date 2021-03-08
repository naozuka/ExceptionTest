using System;

namespace ExceptionTest
{
    public static class ExceptionWithThrowEx
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
            catch (DivideByZeroException ex)
            {
                //log message and rethrow...
                throw ex;
            }
        }
    }
}