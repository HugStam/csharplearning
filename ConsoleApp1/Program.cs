namespace consoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
             var random = new Random();
             for (var i = 0; i < 10; i++) 
                Console.Write((char)('a' + random.Next(0,26)));
            
        }
    
    }



}
