namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeConverter timeConverter= new();
            try { timeConverter.startProgram(); }
            catch (TimeFormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}