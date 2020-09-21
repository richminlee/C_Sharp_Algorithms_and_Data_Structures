using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            Dictionary<char, int> paraKeyVal = new Dictionary<char, int>();
            paraKeyVal.Add('(', 1);
            paraKeyVal.Add('{', 2);
            paraKeyVal.Add('[', 3);
            paraKeyVal.Add(')', -1);
            paraKeyVal.Add('}', -2);
            paraKeyVal.Add(']', -3);
            List<int> tempList = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if(paraKeyVal[s[i]] > 0)
                {
                    tempList.Add(paraKeyVal[s[i]]);
                }
                else if(paraKeyVal[s[i]] < 0 && tempList.Count > 0)
                {
                    if (tempList[tempList.Count - 1] + paraKeyVal[s[i]] != 0) return false;
                    
                    tempList.RemoveAt(tempList.Count - 1);
                }
                else
                {
                    return false;
                }
            }
            if (tempList.Count > 0)
            {
                return false;
            }
            return true;

            //if (s.Length % 2 != 0) return false;
            //Dictionary<char, int> paraVal = new Dictionary<char, int>();
            //paraVal.Add('(', 1);
            //paraVal.Add('{', 2);
            //paraVal.Add('[', 3);
            //paraVal.Add(')', -1);
            //paraVal.Add('}', -2);
            //paraVal.Add(']', -3);
            //List<int> result = new List<int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (paraVal[s[i]] > 0)
            //    {
            //        result.Add(paraVal[s[i]]);
            //    }
            //    else if(paraVal[s[i]] < 0 && result.Count > 0)
            //    {
            //        if (result[result.Count - 1] + paraVal[s[i]] != 0) return false;
            //        result.RemoveAt(result.Count - 1);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //if (result.Count > 0) return false;
            //return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
        }
    }
}
