using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionWithThrow.Do();

            // ExceptionWithThrow.Do(); 
            // Preserve the stack trace
            // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //     at ExceptionTest.Bar.Do(Int32 b) in C:\Users\USER\src\dotnet\ExceptionTest\Bar.cs:line 8
            //     at ExceptionTest.ExceptionWithThrow.Do() in C:\Users\USER\src\dotnet\ExceptionTest\ExceptionWithThrow.cs:line 14
            //     at ExceptionTest.Program.Main(String[] args) in C:\Users\USER\src\dotnet\ExceptionTest\Program.cs:line 9

            //ExceptionWithThrowEx.Do();
            // With throw ex you lose the stack trace
            // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //     at ExceptionTest.ExceptionWithThrowEx.Do() in C:\Users\USER\src\dotnet\ExceptionTest\ExceptionWithThrowEx.cs:line 19
            //     at ExceptionTest.Program.Main(String[] args) in C:\Users\USER\src\dotnet\ExceptionTest\Program.cs:line 9
            
        }
    }
}
