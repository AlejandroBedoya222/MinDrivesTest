using System;
using System.Collections.Generic;
using System.Text;

namespace MinDrivesTest
{
    /// <summary>
    /// Helper entity to easily store the Used and Total properties within the same container
    /// </summary>
    public class HardDrive
    {
        /// <summary>
        /// Used space on disk
        /// </summary>
        public int Used { get; set; }
        /// <summary>
        /// Total space on disk
        /// </summary>
        public int Total { get; set; }
    }
}
