namespace M1_Practice
{
    public class MaxLoginException: ApplicationException
    {
        public MaxLoginException(string msg): base(msg){}
    }
    class LoginSystem
    {
        public static void Main()
        {
            int attempts = 0;

            // TODO:
            // 1. Allow only 3 login attempts
            // 2. Create and throw custom exception after limit
            // 3. Handle exception and terminate application

            try
            {
                for(int i=0; i<5; i++)
                {
                    if (attempts > 3)
                    {
                        throw new MaxLoginException("Max Login attempted");
                    }
                    attempts++;
                }
            }
            catch (MaxLoginException ex)
            {
                Console.WriteLine(ex.Message+". Access denied.");
            }
        }
    }
}