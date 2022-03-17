# define Conditie1
# define Conditie
using System;
using System.Data;
using System.Diagnostics;

namespace _05_ExceptionsAndDebugging
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("--------THROW EXCEPTIONS EXAMPLE 1--------\n");
            try
            {
                CheckValue(101);
            }
            catch (ArgumentException exception) 
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine();
            Console.WriteLine("--------THROW EXCEPTIONS EXAMPLE 2 WITH CUSTOM EXCEPTIONS AND RETHROWING--------\n");
            try
            {
                PrintStr();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception message: {exception.Message}\n");
                Console.WriteLine($"Inner exception {exception.InnerException}\n");
                Console.WriteLine($"Stack trace {exception.StackTrace}");

            }
            finally
            { 
            }

            Console.WriteLine();
            Console.WriteLine("--------CONDITIONAL COMPILATION--------\n");
            #if Conditie
            Console.WriteLine("You see this message only if Conditie is active");
            #endif

            
            //Write to debug output window
            DebugToOutputWindow();

        }


        static public void CheckValue(int value1)
        {
            if (value1<0 || value1>100)
            {
                throw new ArgumentException("value not in range");
            }
        }


        static public void PrintStr()
        {
            try
            {
                StrMethod("1litere mici");
            }
            catch (StringTooLong exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (StringTooShort exception)
            {
                Console.WriteLine(exception.Message);
            }

            /* will give directly the message of the proper argument exception, no inner exception
            catch (Exception exception)
            {
                throw;
            }
            */

            //will give the message of the new thrown exception, and keep an inner exception
            catch (ArgumentException exception) 
            {
                throw new Exception("See inner exception for details", exception);
            }

            finally
            {
            }
        }


        static public void StrMethod(string text) 
        {
            
            
            if (text.Length > 20)
                throw new StringTooLong("this text is waaaay too long");

            if (text.Length < 2 && text.Length > 0)
                throw new StringTooShort("this text is tiny");

            if (text.Length == 0)
                throw new ArgumentException("text should not be empty");

            if (Char.IsDigit(text,0))
                throw new ArgumentException("text should start with a letter");
            

            Console.WriteLine(text);
        }

        static public void DebugToOutputWindow() 
        {
            Debug.Indent();
            Debug.WriteLine("Text to be displayed on the debuggin output window\n");
            Debug.Unindent();
           

        }

    }
}
