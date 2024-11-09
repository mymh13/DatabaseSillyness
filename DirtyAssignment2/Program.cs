namespace DirtyAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuDB.MenuChoices();

            ShutdownProgram();
        }
        
        static void ShutdownProgram()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
