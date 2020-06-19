using System;

namespace ConsoleApp1
{
    public static class StringHelper
    {
        public static int WordCount(this String str)
        {
            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
