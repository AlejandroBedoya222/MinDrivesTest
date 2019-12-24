using System;

namespace MinDrivesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var used = new int[] { 1, 200, 200, 199, 200, 200 };
            var total = new int[] { 1000, 200, 200, 200, 200, 200 };
            Console.WriteLine("*****************Expected output is '1'*****************");
            Console.WriteLine($"MinDrivesLinq -> {DiskSpace.MinDrivesLinq(used, total)}");
            Console.WriteLine($"MinDrives -> {DiskSpace.MinDrives(used, total)}");
            Console.WriteLine(Environment.NewLine);

            used = new int[] { 750, 800, 850, 900, 950 };
            total = new int[] { 800, 850, 900, 950, 1000 };
            Console.WriteLine("*****************Expected output is '5'*****************");
            Console.WriteLine($"MinDrivesLinq -> {DiskSpace.MinDrivesLinq(used, total)}");
            Console.WriteLine($"MinDrives -> {DiskSpace.MinDrives(used, total)}");
            Console.WriteLine(Environment.NewLine);

            used = new int[] { 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49 };
            total = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            Console.WriteLine("*****************Expected output is '49'*****************");
            Console.WriteLine($"MinDrivesLinq -> {DiskSpace.MinDrivesLinq(used, total)}");
            Console.WriteLine($"MinDrives -> {DiskSpace.MinDrives(used, total)}");
            Console.Read();
        }
    }
}