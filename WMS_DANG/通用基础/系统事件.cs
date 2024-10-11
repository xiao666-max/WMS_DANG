using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WMS_DANG.通用基础
{
    class 系统事件
    {
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
        public static extern int ExitWindowsEx(int uFlags, int dwReserved);

        public static void 注销系统()
        {
            ExitWindowsEx(0, 0);//注销计算机

        }

        public static void 关闭系统()
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";//启动cmd命令
            myProcess.StartInfo.UseShellExecute = false;//是否使用系统外壳程序启动进程
            myProcess.StartInfo.RedirectStandardInput = true;//是否从流中读取
            myProcess.StartInfo.RedirectStandardOutput = true;//是否写入流
            myProcess.StartInfo.RedirectStandardError = true;//是否将错误信息写入流
            myProcess.StartInfo.CreateNoWindow = true;//是否在新窗口中启动进程
            myProcess.Start();//启动进程
            myProcess.StandardInput.WriteLine("shutdown -s -t 0");//执行关机命令
                                                                  // Process.Start("Shutdown.exe", " -s -t 0");
        }

        public static void 重启系统()
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";//启动cmd命令
            myProcess.StartInfo.UseShellExecute = false;//是否使用系统外壳程序启动进程
            myProcess.StartInfo.RedirectStandardInput = true;//是否从流中读取
            myProcess.StartInfo.RedirectStandardOutput = true;//是否写入流
            myProcess.StartInfo.RedirectStandardError = true;//是否将错误信息写入流
            myProcess.StartInfo.CreateNoWindow = true;//是否在新窗口中启动进程
            myProcess.Start();//启动进程
            myProcess.StandardInput.WriteLine("shutdown -r -t 0");//执行重启计算机命令
                                                                  // Process.Start("Shutdown.exe", " -r -t 0");
        }

        public static string CPUID()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
                string sCPUSerialNumber = "";
                foreach (ManagementObject mo in searcher.Get())
                {
                    sCPUSerialNumber = mo["ProcessorId"].ToString().Trim();
                    break;
                }
                return sCPUSerialNumber;
            }
            catch
            {
                return "";
            }
        }
        public static string BIOSID()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
                string sBIOSSerialNumber = "";
                foreach (ManagementObject mo in searcher.Get())
                {
                    sBIOSSerialNumber = mo.GetPropertyValue("SerialNumber").ToString().Trim();
                    break;
                }
                return sBIOSSerialNumber;
            }
            catch
            {
                return "";
            }
        }
    }
}
