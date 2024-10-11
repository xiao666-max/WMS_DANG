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
    public partial class 用户仓库 : Form
    {
        public 用户仓库()
        {
            InitializeComponent();
        }

        private void 退出_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 用户仓库_Load(object sender, EventArgs e)
        {
            标题.Text = this.Text;
        }
    }
}
