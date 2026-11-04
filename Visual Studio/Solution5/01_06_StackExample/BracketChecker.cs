using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample;

internal class BracketChecker : IChecker
{


    const string Open = "([{";
    const string Close = ")]}";

    public bool Check(string input)
    {
        var stack = new Stack<char>();
        foreach (char ch in input)
        {
            int openIndex = Open.IndexOf(ch);
            if (openIndex >= 0)
            {
                stack.Push(ch);
                continue;
            }
            int closeIndex = Close.IndexOf(ch);
            if (closeIndex >= 0)
            {
                if (stack.Count == 0) return false;
                
                char lastOpen = stack.Pop();
                if (lastOpen != Open[closeIndex])
                    return false;

            }

        }
        return stack.Count == 0;

    }
}



