using System;

namespace Alpha_Records_WPF.Utils
{
    public static class Validator
    {
        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
