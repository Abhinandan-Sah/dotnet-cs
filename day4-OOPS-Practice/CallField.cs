namespace day4.fieldInOop
{
    /// <summary>
    /// Learning field in OOPs
    /// </summary>
    public class Employee
    {
        private int id;

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id=value;
                }
                else
                {
                    id=0;
                    throw new ArgumentException("Id cannot be less than zero or equal to zero");
                }
            }
        }

        public string DisplayEmpDetails()
        {
            return $"Employee Id is {id}";
        }
    }
}

