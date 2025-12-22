using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace day4.Validation
{
    public class EmployeeValidation
    {
        private int id;
        private string? name;
        private string? rank;

        #region id validation
        public int Id
        {
            set{
                if (value <= 0)
                {
                    throw new ArgumentException("Id cannot be less than or equal to 0");
                }
                else
                {
                    id=value;
                }
            }
        }
        #endregion

        #region id validation
        public string Name
        {
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Name Cannot be empty");
                }
                else if (value.Any(char.IsDigit))
                {
                   throw new ArgumentException ("Name cannot have number");
                }
                else if (value.ToLower().Contains("dumb"))
                {
                    throw new ArgumentException("dumb cannot be a name");
                }
                else
                {
                    name = value;
                }
            }
        }
        #endregion

        #region id validation
        public string Rank
        {
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Rank/Designaion cannot be empty");
                }
                else if (value.Any(char.IsDigit))
                {
                   throw new ArgumentException ("Rank/Designation cannot have number");
                }
                else
                {
                    rank=value;
                }
            }
        }
        #endregion
    }
}

