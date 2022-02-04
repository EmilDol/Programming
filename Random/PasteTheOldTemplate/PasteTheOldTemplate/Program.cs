using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace PasteTheOldTemplate
{
    class Program
    {
        static string path;
        static void Main()
        {
            
            
            Process[] processes = Process.GetProcesses();
            string name = "sad";
            string dir = "sad";


            for (int i = 0; i < processes.Length; i++)
            {
                processes = processes.OrderBy(x => x.ProcessName).ToArray();
                Console.WriteLine(processes[i].MainWindowTitle);
                if (processes[i].MainWindowTitle.Contains("Microsoft Visual Studio") && processes[i].MainWindowTitle.Contains("PasteTheOldTemplate") == false)
                {
                    name = processes[i].MainWindowTitle;
                    
                }
            }
            int index = name.LastIndexOf('-') - 1;
            string gud = name.Substring(0, index);

            //finding the folder
            
            Queue<string> queue = new Queue<string>();
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> temp = new List<string>();
            for (int i = 0;i < drives.Length; i++)
            {
                temp.Add(drives[i].Name);
            }
            temp.ForEach(x => queue.Enqueue(x));

        }
    }
}