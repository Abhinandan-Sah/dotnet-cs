using System.ComponentModel;

namespace day4.ConsAdd
{
    public class Add
    {
        #region Decleration
        public int a {get; set;}
        public int b {get; set;}
        public int result {get;}
        #endregion

        #region Initialization of constructor
        public Add(int a, int b){
            this.a=a;
            this.b=b;
            result = a+b; // only in constructor get propery can set the values.
        }
        #endregion

        #region method decleartion and initialization
        // public int add()
        // {
        //     return a+b;
        // }
        #endregion        
    }
}