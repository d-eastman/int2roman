using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace int2roman.lib
{
    public static class int2roman
    {
        /// <summary>
        /// Convert an integer to its Roman Numeral representation using the standard I, V, X, L, C, D, and M
        /// Roman Numeral symbols and using the standard four of the same symbol in a row subtraction notation
        /// substitutions (e.g., change four ones [IIII] into five minus one [IV]).
        /// </summary>
        /// <param name="integer">The integer to convert</param>
        /// <returns>String representing the integer value in Roman Numeral notation</returns>
        public static string ToRoman(this int integer)
        {
            //Integer must be positive
            if (integer < 1)
            {
                throw new ArgumentException("Only positive integers can be converted to Roman numerals.");
            }

            //Define integer value to Roman Numeral value conversions
            Dictionary<int, char> romanNumerals = new Dictionary<int, char>();
            romanNumerals.Add(1000, 'M');
            romanNumerals.Add(500, 'D');
            romanNumerals.Add(100, 'C');
            romanNumerals.Add(50, 'L');
            romanNumerals.Add(10, 'X');
            romanNumerals.Add(5, 'V');
            romanNumerals.Add(1, 'I');

            //Convert integer to equivalent Roman Numeral symbols without any subtraction notation substitutions
            //The value at this point may have strings of four or more of the same Roman Numeral symbol in a row
            //Loop goes from largest value Roman Numeral symbol (M) to smallest (I)
            int remainder = integer;
            StringBuilder ret = new StringBuilder();
            foreach (KeyValuePair<int, char> kvp in romanNumerals.OrderByDescending(x => x.Key))
            {
                if (remainder >= kvp.Key)
                {
                    int numUnits = remainder / kvp.Key;
                    ret.Append(new String(kvp.Value, numUnits));
                    remainder = remainder % kvp.Key; //Or is this better?  remainder = remainder - numUnits * kvp.Key;
                }
            }

            //The remainder should always be zero at this point, but if for some odd reason it is not, then let user know there's an unanticipated problem.
            if (remainder != 0)
            {
                throw new InvalidOperationException(String.Format("Unable to convert integer {0} to Roman Numeral! {1} is as far as we got and we still have a remainder of {2}.", 
                    integer, ret.ToString(), remainder));
            }

            //Do subtractive notation to remove strings of four of the same character in a row (except for M since there's nothing higher)
            //4:    IIII -> IV
            //9:   VIIII -> IX
            //40:   XXXX -> XL
            //90:  LXXXX -> XC
            //400:  CCCC -> CD
            //900: DCCCC -> CM
            //They need to be done in the correct order, VIIII before IIII and LXXXX before XXXX and DCCCC before CCCC, but other than that
            //order does not matter.  Substituting IIII before doing the VIIII substitution could lead to problems such as
            //29 (aka XXVIIII) being converted to XXVIV (incorrect) instead of XXIX (correct)
            Dictionary<string, string> substitutions = new Dictionary<string, string>();
            substitutions.Add("VIIII", "IX"); //5+4 goes to 10-1
            substitutions.Add("LXXXX", "XC"); //50+10 goes to 100-10
            substitutions.Add("DCCCC", "CM"); //500+400 goes to 1000-1000
            substitutions.Add("IIII", "IV"); //4 goes to 5-1
            substitutions.Add("XXXX", "XL"); //40 goes to 50-10
            substitutions.Add("CCCC", "CD"); //400 goes to 500-100
            foreach (KeyValuePair<string, string> kvp in substitutions.OrderByDescending(x => x.Key.Length)) //OrderByDescending ensures correct ordering
            {
                ret.Replace(kvp.Key, kvp.Value);
            }

            return ret.ToString();
        }
    }
}