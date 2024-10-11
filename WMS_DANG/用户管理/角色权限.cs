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
    public partial class 角色权限 : Form
    {
        public 角色权限()
        {
            InitializeComponent();
        }

        private void 退出_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 角色权限_Load(object sender, EventArgs e)
        {
            标题.Text = this.Text;
        }
    }
}
