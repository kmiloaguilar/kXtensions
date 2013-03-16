using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kXtensions
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string input)
        {
            const string numberPattern = @"^(0|[1-9][0-9]*)$";

            return Regex.Match(input, numberPattern).Success;
        }

        public static bool IsEmailAddress(this string input)
        {
            const string emailAddressPattern = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";

            return Regex.Match(input, emailAddressPattern).Success;
        }
    }

}
