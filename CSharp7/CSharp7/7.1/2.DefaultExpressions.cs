﻿using System.Linq;
using static System.Console;

namespace CSharp7
{
    public sealed class DefaultExpressions
    {
        public DefaultExpressions()
        {
            int? DoSomeWorkAndGetResult(int a = default, string s = default)
            {
                if (s == default || s is default)
                {
                    return default;
                }

                switch(a)
                {
                    case (default): break;
                    default: break;
                }

                int? result = default;

                var array = new[] { default, a, s.Length };
                if (array.Sum() > 0)
                {
                    result = array.Sum();
                }

                return result;
            }

            WriteLine(DoSomeWorkAndGetResult(default, string.Empty));
        }
    }
}
