using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS_DANG.基础设置;
using WMS_DANG.用户管理;
using WMS_DANG.通用基础;
using WMS_DANG.货位管理;

namespace WMS_DANG
{
    public partial class DANG_Main : Form
    {
        public DANG_Main()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);
        public 修改密码 修改密码;
        public 用户信息 用户信息;
        public 角色信息 角色信息;
        public 用户角色 用户角色;
        public 角色权限 角色权限;
        public 用户仓库 用户仓库;

        public 仓库信息 仓库信息;
        public 存储策略 存储策略;
        public 区域信息 区域信息;
        public 设备信息 设备信息;
        public 托盘标签打印 托盘标签打印;
        public 托盘格子设置 托盘格子设置;
        public 物料类别 物料类别;
        public 物料信息 物料信息;
        public 巷道信息 巷道信息;
        public 计量单位 计量单位;
        public 物料配套 物料配套;
        public 托盘信息 托盘信息;
        public 货位初始化 货位初始化;
        public 货位状态管理 货位状态管理;
        public 空货位查询 空货位查询;




        #region 页面功能设计

        private void 注销登录_Click(object sender, EventArgs e)
        {
            登录界面 登录界面 = new 登录界面();
            登录界面.Show();
            this.Hide();
            //this.Close();
        }

        private void 退出系统_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void 导航栏显示状态(object sender, EventArgs e)
        {
            导航栏.Visible = 子窗体通用.主窗体导航栏;
            系统菜单.Size = new Size(130, 126);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //时间显示
            时分秒.Text = DateTime.Now.ToLongTimeString().ToString();
            年月日.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void 系统菜单_MouseEnter(object sender, EventArgs e)
        {
            系统菜单.Size = new Size(260, 126);

        }

        private void 系统管理_DoubleClick(object sender, EventArgs e)
        {

            MessageBox.Show("研发单位：沈阳航大智能装备有限公司\n系统名称：定制版库房管理系统\n版  本  号：WMS V1.0", "关于", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 时分秒_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region 业务窗口开启——用户管理
        private void 密码修改_Click(object sender, EventArgs e)
        {
            // 打开新的子窗体
            修改密码 = new 修改密码();
            修改密码.ShowDialog();
        }


        private void DANG_Main_Load(object sender, EventArgs e)
        {
            子窗体通用.主窗体导航栏 = true;
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (用户信息 == null || 用户信息.IsDisposed)
            {
                // 打开新的子窗体
                用户信息 = new 用户信息();
                用户信息.TopLevel = false;
                用户信息.Dock = DockStyle.Fill;
                //设备监控.MdiParent = this;
                用户信息.Parent = this.身;
                //或者是 this.panel1.Controls.Add(设备监控);
                用户信息.Show();
                SetParent((int)用户信息.Handle, (int)this.身.Handle);
            }
            else
            {
                用户信息.Activate();
                SetParent((int)用户信息.Handle, (int)this.身.Handle);
            }
        }

        private void 角色信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (角色信息 == null || 角色信息.IsDisposed)
            {
                // 打开新的子窗体
                角色信息 = new 角色信息();
                角色信息.TopLevel = false;
                角色信息.Dock = DockStyle.Fill;
                角色信息.Parent = this.身;
                角色信息.Show();
                SetParent((int)角色信息.Handle, (int)this.身.Handle);
            }
            else
            {
                角色信息.Activate();
                SetParent((int)角色信息.Handle, (int)this.身.Handle);
            }
        }

        private void 用户角色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (用户角色 == null || 用户角色.IsDisposed)
            {
                // 打开新的子窗体
                用户角色 = new 用户角色();
                用户角色.TopLevel = false;
                用户角色.Dock = DockStyle.Fill;
                用户角色.Parent = this.身;
                用户角色.Show();
                SetParent((int)用户角色.Handle, (int)this.身.Handle);
            }
            else
            {
                用户角色.Activate();
                SetParent((int)用户角色.Handle, (int)this.身.Handle);
            }
        }

        private void 角色权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (角色权限 == null || 角色权限.IsDisposed)
            {
                // 打开新的子窗体
                角色权限 = new 角色权限();
                角色权限.TopLevel = false;
                角色权限.Dock = DockStyle.Fill;
                角色权限.Parent = this.身;
                角色权限.Show();
                SetParent((int)角色权限.Handle, (int)this.身.Handle);
            }
            else
            {
                角色权限.Activate();
                SetParent((int)角色权限.Handle, (int)this.身.Handle);
            }
        }

        private void 用户仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (用户仓库 == null || 用户仓库.IsDisposed)
            {
                // 打开新的子窗体
                用户仓库 = new 用户仓库();
                用户仓库.TopLevel = false;
                用户仓库.Dock = DockStyle.Fill;
                用户仓库.Parent = this.身;
                用户仓库.Show();
                SetParent((int)用户仓库.Handle, (int)this.身.Handle);
            }
            else
            {
                用户仓库.Activate();
                SetParent((int)用户仓库.Handle, (int)this.身.Handle);
            }
        }



        #endregion

        #region 业务窗口开启——基础设置
        private void 仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (仓库信息 == null || 仓库信息.IsDisposed)
            {
                // 打开新的子窗体
                仓库信息 = new 仓库信息();
                仓库信息.TopLevel = false;
                仓库信息.Dock = DockStyle.Fill;
                仓库信息.Parent = this.身;
                仓库信息.Show();
                SetParent((int)仓库信息.Handle, (int)this.身.Handle);
            }
            else
            {
                仓库信息.Activate();
                SetParent((int)仓库信息.Handle, (int)this.身.Handle);
            }
        }

        private void 区域信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (区域信息 == null || 区域信息.IsDisposed)
            {
                // 打开新的子窗体
                区域信息 = new 区域信息();
                区域信息.TopLevel = false;
                区域信息.Dock = DockStyle.Fill;
                区域信息.Parent = this.身;
                区域信息.Show();
                SetParent((int)区域信息.Handle, (int)this.身.Handle);
            }
            else
            {
                区域信息.Activate();
                SetParent((int)区域信息.Handle, (int)this.身.Handle);
            }
        }

        private void 设备信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (设备信息 == null || 设备信息.IsDisposed)
            {
                // 打开新的子窗体
                设备信息 = new 设备信息();
                设备信息.TopLevel = false;
                设备信息.Dock = DockStyle.Fill;
                设备信息.Parent = this.身;
                设备信息.Show();
                SetParent((int)设备信息.Handle, (int)this.身.Handle);
            }
            else
            {
                设备信息.Activate();
                SetParent((int)设备信息.Handle, (int)this.身.Handle);
            }
        }

        private void 巷道信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (巷道信息 == null || 巷道信息.IsDisposed)
            {
                // 打开新的子窗体
                巷道信息 = new 巷道信息();
                巷道信息.TopLevel = false;
                巷道信息.Dock = DockStyle.Fill;
                巷道信息.Parent = this.身;
                巷道信息.Show();
                SetParent((int)巷道信息.Handle, (int)this.身.Handle);
            }
            else
            {
                巷道信息.Activate();
                SetParent((int)巷道信息.Handle, (int)this.身.Handle);
            }
        }

        private void 物料类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (物料类别 == null || 物料类别.IsDisposed)
            {
                // 打开新的子窗体
                物料类别 = new 物料类别();
                物料类别.TopLevel = false;
                物料类别.Dock = DockStyle.Fill;
                物料类别.Parent = this.身;
                物料类别.Show();
                SetParent((int)物料类别.Handle, (int)this.身.Handle);
            }
            else
            {
                物料类别.Activate();
                SetParent((int)物料类别.Handle, (int)this.身.Handle);
            }
        }

        private void 物料信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (物料信息 == null || 物料信息.IsDisposed)
            {
                // 打开新的子窗体
                物料信息 = new 物料信息();
                物料信息.TopLevel = false;
                物料信息.Dock = DockStyle.Fill;
                物料信息.Parent = this.身;
                物料信息.Show();
                SetParent((int)物料信息.Handle, (int)this.身.Handle);
            }
            else
            {
                物料信息.Activate();
                SetParent((int)物料信息.Handle, (int)this.身.Handle);
            }
        }

        private void 托盘格子设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (托盘格子设置 == null || 托盘格子设置.IsDisposed)
            {
                // 打开新的子窗体
                托盘格子设置 = new 托盘格子设置();
                托盘格子设置.TopLevel = false;
                托盘格子设置.Dock = DockStyle.Fill;
                托盘格子设置.Parent = this.身;
                托盘格子设置.Show();
                SetParent((int)托盘格子设置.Handle, (int)this.身.Handle);
            }
            else
            {
                托盘格子设置.Activate();
                SetParent((int)托盘格子设置.Handle, (int)this.身.Handle);
            }
        }

        private void 存储策略ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (存储策略 == null || 存储策略.IsDisposed)
            {
                // 打开新的子窗体
                存储策略 = new 存储策略();
                存储策略.TopLevel = false;
                存储策略.Dock = DockStyle.Fill;
                存储策略.Parent = this.身;
                存储策略.Show();
                SetParent((int)存储策略.Handle, (int)this.身.Handle);
            }
            else
            {
                存储策略.Activate();
                SetParent((int)存储策略.Handle, (int)this.身.Handle);
            }
        }

        private void 托盘标签打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (托盘标签打印 == null || 托盘标签打印.IsDisposed)
            {
                // 打开新的子窗体
                托盘标签打印 = new 托盘标签打印();
                托盘标签打印.TopLevel = false;
                托盘标签打印.Dock = DockStyle.Fill;
                托盘标签打印.Parent = this.身;
                托盘标签打印.Show();
                SetParent((int)托盘标签打印.Handle, (int)this.身.Handle);
            }
            else
            {
                托盘标签打印.Activate();
                SetParent((int)托盘标签打印.Handle, (int)this.身.Handle);
            }
        }
        

        private void 计量单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (计量单位 == null || 计量单位.IsDisposed)
            {
                // 打开新的子窗体
                计量单位 = new 计量单位();
                计量单位.TopLevel = false;
                计量单位.Dock = DockStyle.Fill;
                计量单位.Parent = this.身;
                计量单位.Show();
                SetParent((int)计量单位.Handle, (int)this.身.Handle);
            }
            else
            {
                计量单位.Activate();
                SetParent((int)计量单位.Handle, (int)this.身.Handle);
            }
        }

        private void 物料配套ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (物料配套 == null || 物料配套.IsDisposed)
            {
                // 打开新的子窗体
                物料配套 = new 物料配套();
                物料配套.TopLevel = false;
                物料配套.Dock = DockStyle.Fill;
                物料配套.Parent = this.身;
                物料配套.Show();
                SetParent((int)物料配套.Handle, (int)this.身.Handle);
            }
            else
            {
                物料配套.Activate();
                SetParent((int)物料配套.Handle, (int)this.身.Handle);
            }
        }



        private void 托盘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (托盘信息 == null || 托盘信息.IsDisposed)
            {
                // 打开新的子窗体
                托盘信息 = new 托盘信息();
                托盘信息.TopLevel = false;
                托盘信息.Dock = DockStyle.Fill;
                托盘信息.Parent = this.身;
                托盘信息.Show();
                SetParent((int)托盘信息.Handle, (int)this.身.Handle);
            }
            else
            {
                托盘信息.Activate();
                SetParent((int)托盘信息.Handle, (int)this.身.Handle);
            }
        }
        #endregion

        private void 货位初始化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (货位初始化 == null || 货位初始化.IsDisposed)
            {
                // 打开新的子窗体
                货位初始化 = new 货位初始化();
                货位初始化.TopLevel = false;
                货位初始化.Dock = DockStyle.Fill;
                货位初始化.Parent = this.身;
                货位初始化.Show();
                SetParent((int)货位初始化.Handle, (int)this.身.Handle);
            }
            else
            {
                货位初始化.Activate();
                SetParent((int)货位初始化.Handle, (int)this.身.Handle);
            }
        }

        private void 货位状态管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (货位状态管理 == null || 货位状态管理.IsDisposed)
            {
                // 打开新的子窗体
                货位状态管理 = new 货位状态管理();
                货位状态管理.TopLevel = false;
                货位状态管理.Dock = DockStyle.Fill;
                货位状态管理.Parent = this.身;
                货位状态管理.Show();
                SetParent((int)货位状态管理.Handle, (int)this.身.Handle);
            }
            else
            {
                货位状态管理.Activate();
                SetParent((int)货位状态管理.Handle, (int)this.身.Handle);
            }
        }

        private void 空货位查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (空货位查询 == null || 空货位查询.IsDisposed)
            {
                // 打开新的子窗体
                空货位查询 = new 空货位查询();
                空货位查询.TopLevel = false;
                空货位查询.Dock = DockStyle.Fill;
                空货位查询.Parent = this.身;
                空货位查询.Show();
                SetParent((int)空货位查询.Handle, (int)this.身.Handle);
            }
            else
            {
                空货位查询.Activate();
                SetParent((int)空货位查询.Handle, (int)this.身.Handle);
            }
        }
    }
}
