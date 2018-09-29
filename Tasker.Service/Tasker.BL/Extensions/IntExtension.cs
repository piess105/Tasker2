using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Managers;

namespace Tasker.BL.Extensions
{
    public static class IntExtension
    {
        public static string ToLetter(this int value)
        {
            var letter = ((char)(64 + value)).ToString();

            return letter;
        }

    }
}