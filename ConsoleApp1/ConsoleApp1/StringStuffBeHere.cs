using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class StringStuffBeHere
    {
        public static string ReverseIt(this string str)
        {
            int strLen = str.Length;

            var sb = new StringBuilder
            {
                Length = strLen
            };

            for (int i = str.Length - 1; i > -1; i--)
            {
                sb[strLen - 1 - i] = str[i];
            }

            return sb.ToString();
        }

        public static string ReverseItSpecial(this string str)
        {
            int strLen = str.Length;

            var sb = new StringBuilder
            {
                Length = strLen
            };

            int left = 0;
            int right = strLen - 1;

            do
            {
                if (left == right)
                {
                    sb[left] = str[right];
                    left++;
                }
                else if (!MoveMe(str[left]) && !MoveMe(str[right]))
                {
                    sb[left] = str[left];
                    sb[right] = str[right];
                    left++;
                    right--;
                }
                else if (MoveMe(str[left]) && MoveMe(str[right]))
                {
                    sb[left] = str[right];
                    sb[right] = str[left];
                    left++;
                    right--;
                }
                else if (MoveMe(str[left]))
                {
                    sb[right] = str[right];
                    right--;
                }
                else
                {
                    sb[left] = str[left];
                    left++;
                }

            } while (left <= right);

            return sb.ToString();
        }

        private static bool MoveMe(char c)
        {
            var rgx = new Regex(@"[A-Z0-9]", RegexOptions.IgnoreCase);

            return rgx.IsMatch(c.ToString());
        }
    }
}
