namespace ScienceLib
{
    public class ScienceOperations
    {
        public int AeroDensity(int altitude)
        {
            return 101325 - (altitude * 12); // Simplified formula
        }
    }
}
