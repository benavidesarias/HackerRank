using System.Linq;

namespace Solutions
{
    public class WarmUpChallenges
    {
        //problem #1
        public static int SockMerchant(int n, int[] ar)
        {
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] == ar[j] && ar[j] != -1)
                    {
                        c++;
                        ar[i] = -1;
                        ar[j] = -1;
                        break;
                    }
                }

            }

            return c;
        }

        //Problem #2
        public static int CountingValleys(int n, string s)
        {
            var level = 0;
            var c = 0;

            foreach (var step in s)
            {
                if (step == 'D')
                {
                    level--;
                }
                else
                {
                    if (level + 1 == 0)
                    {
                        c++;
                    }

                    level++;
                }

            }

            return c;
        }

        //Problem #3
        public static int JumpingOnClouds(int[] c)
        {
            int n = c.Length;
            int s = 0;

            for (int i = 0; i < n;)
            {
                if (i + 2 < n && c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }
                s++;
            }

            return s - 1;
        }

        //Problem #4
        public static long RepeatedString(string s, long n)
        {
            long total = 0;
            long length = s.Length;

            if (n > length)
            {
                long count = s.Count(x => x == 'a');
                long integerPart = n / length;
                long numberOfGroup = count * integerPart;

                long rest = n - integerPart * length;
                string subS = s.Substring(0, (int)rest);
                long countSub = subS.Count(x => x == 'a');

                total = numberOfGroup + countSub;
            }
            else
            {
                total = s.Substring(0, (int)n).Count(x => x == 'a');
            }

            return total;
        }
    }
}
