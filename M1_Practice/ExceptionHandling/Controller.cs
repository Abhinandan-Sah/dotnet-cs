namespace M1_Practice
{
    class Controller
    {
        static void Main()
        {
            // TODO:
            // Call Service method
            // Service service = new Service();
            try
            {
            Service.Process();
                
            }
            // Handle exception here
            catch (MethodAccessException ex)
            {
                Console.WriteLine(ex.Message + " Main");
            }
        }
    }

    class Service
    {
        public static void Process()
        {
            // TODO:
            // Call Repository method
            try
            {
            Repository.GetData();
                
            }
            
            // Catch, log and rethrow exception
            catch (MethodAccessException ex)
            {
                Console.WriteLine(ex.Message + " Service");
                throw;
            }
        }
    }

    class Repository
    {
        public static void GetData()
        {
            // TODO:
            // Throw an exception here
            throw new MethodAccessException("Cannot Access Get");
        }
    }
}