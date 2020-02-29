using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Common
{
    /// <summary>
    /// Convertion from One Data Type to Another
    /// </summary>
    public class TypeConvertion
    {
        /// <summary>
        /// return trim string
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ToString(string val)
        {
            return val.ToString().Trim();
        }
        /// <summary>
        /// string to double with round of 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="round"></param>
        /// <returns></returns>
        public static double ToDouble(string  val,int round)
        {
            return Math.Round(Convert.ToDouble(val), round);
        }
        /// <summary>
        /// string to int32
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static Int32 ToInt(string val)
        {
            return Convert.ToInt32(val);
        }
    }
}