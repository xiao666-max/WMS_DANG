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

namespace WMS_DANG.用户管理
{
    public partial class 修改密码 : Form
    {
        public 修改密码()
        {
            InitializeComponent();
        }

        private void 退出按钮_Click(object sender, EventArgs e)
        {
            this.Close();
            系统软键盘.HideInputPanel();
        }

        private void 键盘_Click(object sender, EventArgs e)
        {
            系统软键盘.HideInputPanel();
            系统软键盘.ShowInputPanel();
        }

        private void 退出按钮_MouseEnter(object sender, EventArgs e)
        {
            退出按钮.Image = Properties.Resources.关闭1;
        }

        private void 退出按钮_MouseLeave(object sender, EventArgs e)
        {
            退出按钮.Image = Properties.Resources.关闭2;
        }

        private void 修改按钮_MouseEnter(object sender, EventArgs e)
        {
            修改输入框.BackColor = Color.White;
        }

        private void 修改按钮_MouseLeave(object sender, EventArgs e)
        {
            修改输入框.BackColor = Color.Black;
        }

        private void 修改按钮_MouseDown(object sender, MouseEventArgs e)
        {
            旧密码输入框.BackColor = Color.Gray;
            新密码输入框1.BackColor = Color.Gray;
            新密码输入框2.BackColor = Color.Gray;
        }

        private void 修改按钮_MouseUp(object sender, MouseEventArgs e)
        {
            旧密码输入框.BackColor = Color.White;
            新密码输入框1.BackColor = Color.White;
            新密码输入框2.BackColor = Color.White;
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            提示1.Visible = false;
            提示2.Visible = false;
        }

        private void 修改按钮_Click(object sender, EventArgs e)
        {
            系统软键盘.HideInputPanel();

            提示1.Visible = true;
            提示2.Visible = true;
            旧密码输入框.Text = "";
            新密码输入框1.Text = "";
            新密码输入框2.Text = "";

        }

        private void 修改输入框_MouseDown(object sender, MouseEventArgs e)
        {
            提示1.Visible = false;
            提示2.Visible = false;
        }

        private void 旧密码输入框_MouseDown(object sender, MouseEventArgs e)
        {

            提示1.Visible = false;
            提示2.Visible = false;
        }
    }
}
