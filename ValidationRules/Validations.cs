using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationRnD.ValidationRules
{
    public static class Validations
    {
        public static string AlphaAndSpace = @"^[a-zA-Z\s]*$";
        public static string AlphaNumericOnly = @"^[a-zA-Z0-9]*$";
        public static string Numeric = @"^[0-9]*$";
        public static string Email = @"^[a-zA-Z0-9.@\s]*$";
    }
}
