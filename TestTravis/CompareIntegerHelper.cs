using System;

namespace TestTravis
{
    ///<summary>
    ///Just a test class of Travis
    ///</summary>
    public class CompareIntegerHelper
    {
        ///<summary>
        ///Compare the parameter with zero
        ///</summary>
        ///<param name="number">Number which will be compared</param>
        ///<returns>
        ///<c>True</c> if the number is zero, <c>False</c> otherwise
        ///</returns>
        public bool IsZero(int number)
        {
            return number == 0;
        }
    }
}
