namespace ExceptionsEnzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionVoorbeeld();
            try
            {
                CodeThatThrowsException();
            }
            catch (ComputerSaysNoException ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        static void ExceptionVoorbeeld()
        {
            int y = 0;
            try
            {
                int x = 100 / y;
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("arithmetic problems: " + ex.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            Console.WriteLine("Rest of the code....");

        }

        static void CodeThatThrowsException()
        {
            throw new ComputerSaysNoException();
        }
    }
}