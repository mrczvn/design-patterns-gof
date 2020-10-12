using System;

namespace abstract_factory.Domain.Util
{
    public class IgnoreCase
    {
        public static bool equalIgnoreCase(string text, string textToCompare)
        {
            return string.Equals(text, textToCompare, StringComparison.OrdinalIgnoreCase);
        }
    }
}