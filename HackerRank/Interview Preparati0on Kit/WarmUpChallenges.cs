using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparati0on_Kit
{
    public static class WarmUpChallenges
    {

        #region https://www.hackerrank.com/challenges/sock-merchant/problem
        public static int sockMerchant(int n, int[] arr)
        {
            int res = 0;

            var noOfColours = arr.Distinct();

            foreach (var item in noOfColours)
            {
                var noOfPairs = arr.Where(x => x == item).Count() / 2;
                res += noOfPairs;
            }

            return res;
        }
        #endregion https://www.hackerrank.com/challenges/sock-merchant/problem

        #region https://www.hackerrank.com/challenges/counting-valleys/problem
        public static int countingValleys(int n, string s)
        {
            int noOfValleys = 0;
            int seaLevel = 0;

            foreach (var item in s.ToCharArray())
            {
                if (item == 'D')
                    seaLevel--;
                else if (item == 'U')
                {
                    seaLevel++;
                    if (seaLevel == 0)
                        noOfValleys++;
                }
            }

            return noOfValleys;
        }
        #endregion https://www.hackerrank.com/challenges/counting-valleys/problem
    }
}
