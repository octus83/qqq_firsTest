using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBay.Utils
{
    /// <summary>
    /// Holds various String-Utilities to modify Strings.
    /// </summary>
    public static class StringUtil
    {
        /// <summary>
        /// Extract a String from a given String in between to Strings.
        /// Throws ArgumentNullExeption, ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="firstTag">The Beginning of the String to search for. </param>
        /// <param name="lastTag">The Ending of the String to search for. </param>
        /// <param name="source">The String to extract from. </param>
        /// <returns>The String between the two given Strings (excluded). </returns>
        public static String GetStringBetween(String firstTag, String lastTag, String source)
        {
            if(String.IsNullOrWhiteSpace(firstTag))
            {
                throw new ArgumentNullException("firstTag");
            }

            if(String.IsNullOrWhiteSpace(lastTag))
            {
                throw new ArgumentNullException("secondTag");
            }

            if(String.IsNullOrWhiteSpace("source"))
            {
                throw new ArgumentNullException("source");
            }

            return "somethinggg";
        }
    }
}
