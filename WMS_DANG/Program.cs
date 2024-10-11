using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_DANG
{ 
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (process.MainModule.FileName
                    == current.MainModule.FileName)
                    {
                        MessageBox.Show("程序已经运行！", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            //bool Exist = false;//定义一个bool变量，用来表示是否已经运行
            ////创建Mutex互斥对象
            //System.Threading.Mutex newMutex = new System.Threading.Mutex(true, "仅一次", out Exist);
            //if (Exist)//如果没有运行
            //{
            //    newMutex.ReleaseMutex();//运行新窗体
            //}
            //else
            //{
            //    // MessageBox.Show("本程序一次只能运行一个！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示信息
            //    System.Environment.Exit(0);//关闭当前窗体
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 登录界面());
        }
    }
}
