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
        /// The LINQ version is built in using the latest techniques and the power of lambda expressions,this version 
        /// also uses a collection(List) of class “HardDrive” as a helper to easily store the Used and Total properties
        /// within the same container for further uses instead of having to handle two separated arrays.
        /// </summary>
        /// <param name="used"></param>
        /// <param name="total"></param>
        /// <returns>Return the minimum number of hard drives needed to store the data after the consolidation is complete</returns>
        public static int MinDrivesLinq(int[] used, int[] total)
        {
            if (used.Length == 1)
            {
                return 1;
            }
            var sortedHardDrives = total.Select((t, i) => new HardDrive { Used = used[i], Total = t })
                                        .OrderByDescending(t => t.Total).ToList();

            var hardDrives = sortedHardDrives.Select((hd, i) =>
            {
                var available = hd.Total - hd.Used;
                var index = i;
                while (available > 0 && index < sortedHardDrives.Count() - 1)
                {
                    var nextElement = sortedHardDrives.ElementAt(index + 1);
                    if (available > nextElement.Used)
                    {
                        hd.Used = hd.Used + nextElement.Used;
                        nextElement.Used = 0;
                    }
                    else
                    {
                        //hd.Used = hd.Used + available;
                        hd.Used = hd.Used + nextElement.Used - (nextElement.Used - available);
                        nextElement.Used = nextElement.Used - available;
                    }
                    available = hd.Total - hd.Used;

                    index++;
                }
                return hd;
            }).ToList();

            return hardDrives.Where(hd => hd.Used > 0).Count();
        }

        /// <summary>
        /// The “conventional” version is just a raw implementation using the basic arrays and loops available on any languages.
        /// </summary>
        /// <param name="used"></param>
        /// <param name="total"></param>
        /// <returns>Return the minimum number of hard drives needed to store the data after the consolidation is complete</returns>
        public static int MinDrivesConventional(int[] used, int[] total)
        {
            if (used.Length == 1)
            {
                return 1;
            }
            //Sorting descending
            for (int i = 0; i < total.Length - 1; i++)
            {
                for (int j = i + 1; j < total.Length; j++)
                {
                    if (total[j] > total[i])
                    {
                        var temp = total[j];
                        total[j] = total[i];
                        total[i] = temp;

                        temp = used[j];
                        used[j] = used[i];
                        used[i] = temp;
                    }
                }
            }

            //Moving the data
            for (int i = 0; i < total.Length; i++)
            {
                var available = total[i] - used[i];
                var index = i;
                while (available > 0 && index < total.Length - 1)
                {
                    if (available > used[index + 1])
                    {
                        used[i] = used[i] + used[index + 1];
                        used[index + 1] = 0;
                    }
                    else
                    {
                        used[i] = used[i] + used[index + 1] - (used[index + 1] - available);
                        used[index + 1] = used[index + 1] - available;
                    }
                    available = total[i] - used[i];
                    index++;
                }
            }

            //Counting the in use ones
            var count = 0;
            for (int i = 0; i < used.Length; i++)
            {
                if (used[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
