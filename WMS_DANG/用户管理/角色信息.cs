using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_DANG.用户管理
{
    public partial class 角色信息 : Form
    {
        public 角色信息()
        {
            InitializeComponent();
        }

        private void 角色信息_Load(object sender, EventArgs e)
        {
            标题.Text = this.Text;
        }

        private void 退出_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
