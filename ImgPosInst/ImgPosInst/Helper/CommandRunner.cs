using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgPosInst.Helper
{
    public class CommandRunner
    {
        public static string ExecCommand(string command)
        {
            Process process = new Process();
            string line;
            string result = "";

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            process.StartInfo.Verb = "runas";
            process.Start();

            while ((line = process.StandardOutput.ReadLine()) != null)
            {

                if (line.Trim() == "")
                {
                    continue;
                }

                result += line.Trim() + ";";
            }

            process.WaitForExit();

            return result.Substring(0, result.Length - 1);
        }
    }
}
