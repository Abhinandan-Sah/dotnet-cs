namespace M1_Practice
{
    /// <summary>
    /// Custom exeption for robot saftey errors
    /// </summary>
    public class RobotSafetyException: Exception
    {
        // public NotAValidArmPrecision how to make this method
        /// <summary>
        /// takes error messge and pass to base class
        /// </summary>
        public RobotSafetyException(string msg): base(msg)
        {
            
        }
    }
    
    /// <summary>
    /// calculates hazard risk for robot operations
    /// </summary>
    public class RobotHazardAuditor
    {
        /// <summary>
        /// calcuates hazard risk score based on robot paramters
        /// </summary>
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            // check if arm precison is in valid range
            if(armPrecision<0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            }

            // validate worker density count
            if(workerDensity <1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }

            // check machinery state is one of the allowed values
            if(machineryState !="Worn" && machineryState != "Faulty" && machineryState != "Critical")
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }

            // assign risk factor based on machinery conditon
            double machineRiskFactor = machineryState switch
            {
                "Worn"=>1.3,
                "Faulty"=> 2.0,
                "Critical"=>3.0,
                _ => 1.0
            };

            // calculate final hazard risk score
            double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
            return hazardRisk;
        }

        /// <summary>
        /// entry point - gets user input and calculates risk
        /// </summary>
        public static void Main()
        {
            RobotHazardAuditor robotHazardAuditor = new RobotHazardAuditor();

            double armPrecision;
            int workerDensity;
            string machineryState;

            // get arm precison from user
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0): ");
            while(!double.TryParse(Console.ReadLine(), out armPrecision))
            {
                Console.WriteLine("Invalid input. Enter Arm Precision (0.0 - 1.0): ");
            }
            
            // get worker density from user
            Console.WriteLine("Enter Worker Density (1 - 20): ");
            while(!int.TryParse(Console.ReadLine(), out workerDensity))
            {
                Console.WriteLine("Invalid input. Enter Worker Density (1 - 20):  ");
            }
            
            // get machinery state
            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical): ");
            machineryState = Console.ReadLine() ?? "";

            // calculate risk and handle any errors
            try
            {
                double hazardRisk = robotHazardAuditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);
                Console.WriteLine("Robot Hazard Risk Score: "+hazardRisk);
            }catch(RobotSafetyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}