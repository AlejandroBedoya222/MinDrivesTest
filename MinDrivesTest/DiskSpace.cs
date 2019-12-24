using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MinDrivesTest
{
    /// <summary>
    /// Main class to perform system requirements
    /// </summary>
    public class DiskSpace
    {
        /// <summary>
        /// The LINQ version is built in using the latest techniques and the power of lambda expressions
        /// </summary>
        /// <param name="used"></param>
        /// <param name="total"></param>
        /// <returns>Return the minimum number of hard drives needed to store the data after the consolidation is complete</returns>
        public static int MinDrivesLinq(int[] used, int[] total)
        {
            int totalUsed = used.Sum();
            int count = 0;

            var sortedListDisk = total.OrderByDescending(x => x).ToList();
            while (totalUsed > 0)
            {
                totalUsed -= sortedListDisk.ElementAt(count);
                count++;
            }
            return count;
        }

        /// <summary>
        /// The “” version is just a raw implementation using the basic arrays and loops available on any languages.
        /// </summary>
        /// <param name="used"></param>
        /// <param name="total"></param>
        /// <returns>Return the minimum number of hard drives needed to store the data after the consolidation is complete</returns>
        public static int MinDrives(int[] used, int[] total)
        {
            int length = used.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (total[j] > total[i])
                    {
                        var temp = total[j];
                        total[j] = total[i];
                        total[i] = temp;
                    }
                }
            }
            int totalUsed = 0;
            foreach (var item in used)
            {
                totalUsed += item;
            }
            int count = 0;
            while (totalUsed > 0)
            {
                totalUsed -= total[count];
                count++;
            }
            return count;
        }
    }
}
