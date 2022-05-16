using System.Collections.Generic;

namespace leetcode.csharp
{
    public class Solution76
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> target = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();
            foreach (var c in t)
            {
                dicAdd(target,c);
            }

            foreach (var q in target.Keys)
            {
                System.Console.WriteLine(q);
            }

            int left = 0, right = 0;
            int valid = 0;
            int start = 0, len = int.MaxValue;
            while (right < s.Length)
            {
                char c = s[right];
                right++;

                if (target.ContainsKey(c))
                {
                    dicAdd(window,c);
                    if (target[c] == window[c])
                    {
                        valid++;
                    }
                }

                while (valid == target.Count)
                {
                    if (right - left < len)
                    {
                        start = left;
                        len = right - left;
                    }
                    char d = s[left];
                    left++;
                    if (target.ContainsKey(d))
                    {
                        if (target[d] == window[d])
                        {
                            valid--;
                        }
                        window[d]--;
                    }

                }
            }


            return len == int.MaxValue ? "" : s.Substring(start, len);
        }

        private void dicAdd(Dictionary<char, int> dic, char key)
        {
            if (dic.ContainsKey(key))
            {
                dic[key]++;
            }
            else
            {
                dic.Add(key, 1);
            }
        }

        // static void Main(string[] args)
        // {
        //     Solution76 sol = new();
        //     string s = "ADOBECODEBANC";
        //     string t = "ABC";

        //     string res = sol.MinWindow(s, t);
        //     System.Console.WriteLine(res);

        // }
    }
}