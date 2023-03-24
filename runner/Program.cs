using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var blockedList = new List<string>(args);
            var transformed = new List<string>();
            bool isBlockingMode = args[args.Length - 1].Contains("Block") ? true : false;
            foreach (var blocked in blockedList)
            {
                if (blocked.Contains("Block") || blocked.Contains("Unblock")) continue;
                transformed.Add($"127.0.0.1 {blocked}");
                Console.WriteLine($"127.0.0.1 {blocked}");
            }
            EditHostsFile(transformed, isBlockingMode);
        }

        public static void EditHostsFile(List<string> blockList, bool isBlockingMode)
        {
            if (isBlockingMode)
            {
                string path = @"C:\WINDOWS\system32\drivers\etc\hosts";

                File.AppendAllLines(path, blockList);
            }
            else
            {
                string path = @"C:\WINDOWS\system32\drivers\etc\hosts";
                string[] lines = File.ReadAllLines(path);

                File.WriteAllLines(path, lines.Take(lines.Length - blockList.Count).ToArray());
            }
        }
    }
}
