using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS_DANG.通用基础;

namespace WMS_DANG
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }


        #region 退出设计
        private void 退出按钮_Click_1(object sender, EventArgs e)
        {
            系统软键盘.HideInputPanel();
            button1_Click(0, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出按钮_MouseEnter(object sender, EventArgs e)
        {
            退出按钮.Image = Properties.Resources.关闭1;
        }

        private void 退出按钮_MouseLeave(object sender, EventArgs e)
        {
            退出按钮.Image = Properties.Resources.关闭2; 
        }
        #endregion

        #region 打开键盘
        private void 键盘_Click(object sender, EventArgs e)
        {
            系统软键盘.HideInputPanel();
            系统软键盘.ShowInputPanel();
        }
        #endregion

        #region 登录设计
        private void 登录按钮_Click(object sender, EventArgs e)
        {
          
            
                int MM = (Convert.ToInt32(DateTime.Now.Year) + Convert.ToInt32(DateTime.Now.Month) + Convert.ToInt32(DateTime.Now.Day)) * Convert.ToInt32(DateTime.Now.Day);

               
                if ((账号输入框.Text.Trim() == "DANG" && 密码输入框.Text == "DANG") || (账号输入框.Text.Trim() == "WMS" && 密码输入框.Text == Convert.ToString(MM)))
                {
                    //系统软键盘.HideInputPanel();
                    DANG_Main DANG_Main = new DANG_Main();
                    DANG_Main.Show();
                    this.Hide();
                    
            }
                else
                {
                    提示.Visible = true;
                    账号输入框.Text = "";
                    密码输入框.Text = "";
                    密码输入框.SelectAll();
                    //密码输入框.Focus();
                }  
        }
        #endregion

        #region 界面设计
        private void 登录按钮_MouseEnter(object sender, EventArgs e)
        {
            登陆输入框.BackColor = Color.White;
        }

        private void 登录按钮_MouseLeave(object sender, EventArgs e)
        {
            登陆输入框.BackColor = Color.Black;
        }

        private void 登录按钮_MouseDown(object sender, MouseEventArgs e)
        {
            账号输入框.BackColor = Color.Gray;
            密码输入框.BackColor = Color.Gray;
        }

        private void 登录按钮_MouseUp(object sender, MouseEventArgs e)
        {
            账号输入框.BackColor = Color.White;
            密码输入框.BackColor = Color.White;
        }
       
        private void 登录界面_Click(object sender, EventArgs e)
        {
            提示.Visible = false;
            密码输入框.SelectAll();
            //密码输入框.Focus();
        }
        #endregion

    }
}
