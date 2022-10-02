using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Helpers
{
    public static class EmailHelper
    {
        /// <summary>
        /// Remove all the character '.' before '@' and remove all the character between character '+' and '@'
        /// </summary>
        /// <param name="email">Email address to normalize</param>
        /// <returns></returns>
        public static string NormalizeEmail(string email)
        {
            var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);

            aux[0] = aux[0].Replace(".", "");

            aux[0] = atIndex < 0 ? aux[0] : aux[0].Remove(atIndex);

            return string.Join("@", new string[] { aux[0], aux[1] });
        }
    }
}
