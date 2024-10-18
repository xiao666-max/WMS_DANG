
namespace WMS_DANG
{
    partial class DANG_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANG_Main));
            this.头 = new System.Windows.Forms.Panel();
            this.系统菜单 = new System.Windows.Forms.Panel();
            this.密码修改 = new System.Windows.Forms.Label();
            this.退出系统 = new System.Windows.Forms.Label();
            this.系统管理 = new System.Windows.Forms.PictureBox();
            this.注销登录 = new System.Windows.Forms.Label();
            this.时间显示 = new System.Windows.Forms.TableLayoutPanel();
            this.时分秒 = new System.Windows.Forms.Label();
            this.年月日 = new System.Windows.Forms.Label();
            this.角色 = new System.Windows.Forms.Label();
            this.导航栏 = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.巷道信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.托盘信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.托盘格子设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.托盘标签打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存储策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.物料类别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计量单位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料配套ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户角色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录人 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.身 = new System.Windows.Forms.Panel();
            this.货位管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货位初始化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货位状态管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空货位查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.头.SuspendLayout();
            this.系统菜单.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.系统管理)).BeginInit();
            this.时间显示.SuspendLayout();
            this.导航栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // 头
            // 
            this.头.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.头.Controls.Add(this.系统菜单);
            this.头.Controls.Add(this.时间显示);
            this.头.Controls.Add(this.角色);
            this.头.Controls.Add(this.导航栏);
            this.头.Controls.Add(this.登录人);
            this.头.Dock = System.Windows.Forms.DockStyle.Top;
            this.头.ForeColor = System.Drawing.Color.White;
            this.头.Location = new System.Drawing.Point(0, 0);
            this.头.Name = "头";
            this.头.Size = new System.Drawing.Size(1920, 126);
            this.头.TabIndex = 2;
            this.头.MouseEnter += new System.EventHandler(this.导航栏显示状态);
            // 
            // 系统菜单
            // 
            this.系统菜单.Controls.Add(this.密码修改);
            this.系统菜单.Controls.Add(this.退出系统);
            this.系统菜单.Controls.Add(this.系统管理);
            this.系统菜单.Controls.Add(this.注销登录);
            this.系统菜单.Dock = System.Windows.Forms.DockStyle.Right;
            this.系统菜单.Location = new System.Drawing.Point(1790, 0);
            this.系统菜单.Name = "系统菜单";
            this.系统菜单.Size = new System.Drawing.Size(130, 126);
            this.系统菜单.TabIndex = 0;
            // 
            // 密码修改
            // 
            this.密码修改.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.密码修改.AutoSize = true;
            this.密码修改.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码修改.ForeColor = System.Drawing.Color.White;
            this.密码修改.Location = new System.Drawing.Point(-113, 18);
            this.密码修改.Name = "密码修改";
            this.密码修改.Size = new System.Drawing.Size(72, 17);
            this.密码修改.TabIndex = 6;
            this.密码修改.Text = "密码修改";
            this.密码修改.Click += new System.EventHandler(this.密码修改_Click);
            // 
            // 退出系统
            // 
            this.退出系统.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.退出系统.AutoSize = true;
            this.退出系统.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出系统.ForeColor = System.Drawing.Color.White;
            this.退出系统.Location = new System.Drawing.Point(-113, 91);
            this.退出系统.Name = "退出系统";
            this.退出系统.Size = new System.Drawing.Size(72, 17);
            this.退出系统.TabIndex = 4;
            this.退出系统.Text = "退出系统";
            this.退出系统.Click += new System.EventHandler(this.退出系统_Click);
            // 
            // 系统管理
            // 
            this.系统管理.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.系统管理.Image = global::WMS_DANG.Properties.Resources.党;
            this.系统管理.Location = new System.Drawing.Point(13, 26);
            this.系统管理.Name = "系统管理";
            this.系统管理.Size = new System.Drawing.Size(105, 70);
            this.系统管理.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.系统管理.TabIndex = 1;
            this.系统管理.TabStop = false;
            this.系统管理.DoubleClick += new System.EventHandler(this.系统管理_DoubleClick);
            this.系统管理.MouseEnter += new System.EventHandler(this.系统菜单_MouseEnter);
            // 
            // 注销登录
            // 
            this.注销登录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.注销登录.AutoSize = true;
            this.注销登录.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注销登录.ForeColor = System.Drawing.Color.White;
            this.注销登录.Location = new System.Drawing.Point(-113, 53);
            this.注销登录.Name = "注销登录";
            this.注销登录.Size = new System.Drawing.Size(72, 17);
            this.注销登录.TabIndex = 3;
            this.注销登录.Text = "注销登录";
            this.注销登录.Click += new System.EventHandler(this.注销登录_Click);
            // 
            // 时间显示
            // 
            this.时间显示.ColumnCount = 1;
            this.时间显示.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.时间显示.Controls.Add(this.时分秒, 0, 0);
            this.时间显示.Controls.Add(this.年月日, 0, 1);
            this.时间显示.Location = new System.Drawing.Point(11, 15);
            this.时间显示.Name = "时间显示";
            this.时间显示.RowCount = 2;
            this.时间显示.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.时间显示.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.时间显示.Size = new System.Drawing.Size(237, 98);
            this.时间显示.TabIndex = 7;
            // 
            // 时分秒
            // 
            this.时分秒.AutoSize = true;
            this.时分秒.Dock = System.Windows.Forms.DockStyle.Fill;
            this.时分秒.Font = new System.Drawing.Font("华文彩云", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.时分秒.ForeColor = System.Drawing.Color.White;
            this.时分秒.Location = new System.Drawing.Point(3, 0);
            this.时分秒.Name = "时分秒";
            this.时分秒.Size = new System.Drawing.Size(231, 47);
            this.时分秒.TabIndex = 0;
            this.时分秒.Text = "时分秒";
            this.时分秒.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.时分秒.DoubleClick += new System.EventHandler(this.时分秒_DoubleClick);
            // 
            // 年月日
            // 
            this.年月日.AutoSize = true;
            this.年月日.Dock = System.Windows.Forms.DockStyle.Fill;
            this.年月日.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.年月日.ForeColor = System.Drawing.Color.White;
            this.年月日.Location = new System.Drawing.Point(3, 47);
            this.年月日.Name = "年月日";
            this.年月日.Size = new System.Drawing.Size(231, 51);
            this.年月日.TabIndex = 1;
            this.年月日.Text = "年月日";
            this.年月日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 角色
            // 
            this.角色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.角色.AutoSize = true;
            this.角色.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.角色.ForeColor = System.Drawing.Color.White;
            this.角色.Location = new System.Drawing.Point(1657, 77);
            this.角色.Name = "角色";
            this.角色.Size = new System.Drawing.Size(35, 14);
            this.角色.TabIndex = 5;
            this.角色.Text = "角色";
            // 
            // 导航栏
            // 
            this.导航栏.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.导航栏.Dock = System.Windows.Forms.DockStyle.None;
            this.导航栏.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导航栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.货位管理ToolStripMenuItem});
            this.导航栏.Location = new System.Drawing.Point(251, 51);
            this.导航栏.Name = "导航栏";
            this.导航栏.Size = new System.Drawing.Size(431, 38);
            this.导航栏.TabIndex = 0;
            this.导航栏.Text = "menuStrip1";
            this.导航栏.MouseEnter += new System.EventHandler(this.导航栏显示状态);
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库信息ToolStripMenuItem,
            this.区域信息ToolStripMenuItem,
            this.设备信息ToolStripMenuItem,
            this.巷道信息ToolStripMenuItem,
            this.toolStripSeparator1,
            this.托盘信息ToolStripMenuItem,
            this.托盘格子设置ToolStripMenuItem,
            this.托盘标签打印ToolStripMenuItem,
            this.存储策略ToolStripMenuItem,
            this.toolStripSeparator2,
            this.物料类别ToolStripMenuItem,
            this.计量单位ToolStripMenuItem,
            this.物料信息ToolStripMenuItem,
            this.物料配套ToolStripMenuItem});
            this.基础设置ToolStripMenuItem.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础设置ToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // 仓库信息ToolStripMenuItem
            // 
            this.仓库信息ToolStripMenuItem.Name = "仓库信息ToolStripMenuItem";
            this.仓库信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.仓库信息ToolStripMenuItem.Text = "仓库信息";
            this.仓库信息ToolStripMenuItem.Click += new System.EventHandler(this.仓库信息ToolStripMenuItem_Click);
            // 
            // 区域信息ToolStripMenuItem
            // 
            this.区域信息ToolStripMenuItem.Name = "区域信息ToolStripMenuItem";
            this.区域信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.区域信息ToolStripMenuItem.Text = "区域信息";
            this.区域信息ToolStripMenuItem.Click += new System.EventHandler(this.区域信息ToolStripMenuItem_Click);
            // 
            // 设备信息ToolStripMenuItem
            // 
            this.设备信息ToolStripMenuItem.Name = "设备信息ToolStripMenuItem";
            this.设备信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.设备信息ToolStripMenuItem.Text = "设备信息";
            this.设备信息ToolStripMenuItem.Click += new System.EventHandler(this.设备信息ToolStripMenuItem_Click);
            // 
            // 巷道信息ToolStripMenuItem
            // 
            this.巷道信息ToolStripMenuItem.Name = "巷道信息ToolStripMenuItem";
            this.巷道信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.巷道信息ToolStripMenuItem.Text = "巷道信息";
            this.巷道信息ToolStripMenuItem.Click += new System.EventHandler(this.巷道信息ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // 托盘信息ToolStripMenuItem
            // 
            this.托盘信息ToolStripMenuItem.Name = "托盘信息ToolStripMenuItem";
            this.托盘信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.托盘信息ToolStripMenuItem.Text = "托盘信息";
            this.托盘信息ToolStripMenuItem.Click += new System.EventHandler(this.托盘信息ToolStripMenuItem_Click);
            // 
            // 托盘格子设置ToolStripMenuItem
            // 
            this.托盘格子设置ToolStripMenuItem.Name = "托盘格子设置ToolStripMenuItem";
            this.托盘格子设置ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.托盘格子设置ToolStripMenuItem.Text = "托盘格子设置";
            this.托盘格子设置ToolStripMenuItem.Click += new System.EventHandler(this.托盘格子设置ToolStripMenuItem_Click);
            // 
            // 托盘标签打印ToolStripMenuItem
            // 
            this.托盘标签打印ToolStripMenuItem.Name = "托盘标签打印ToolStripMenuItem";
            this.托盘标签打印ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.托盘标签打印ToolStripMenuItem.Text = "托盘标签打印";
            this.托盘标签打印ToolStripMenuItem.Click += new System.EventHandler(this.托盘标签打印ToolStripMenuItem_Click);
            // 
            // 存储策略ToolStripMenuItem
            // 
            this.存储策略ToolStripMenuItem.Name = "存储策略ToolStripMenuItem";
            this.存储策略ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.存储策略ToolStripMenuItem.Text = "存储策略";
            this.存储策略ToolStripMenuItem.Click += new System.EventHandler(this.存储策略ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // 物料类别ToolStripMenuItem
            // 
            this.物料类别ToolStripMenuItem.Name = "物料类别ToolStripMenuItem";
            this.物料类别ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.物料类别ToolStripMenuItem.Text = "物料类别";
            this.物料类别ToolStripMenuItem.Click += new System.EventHandler(this.物料类别ToolStripMenuItem_Click);
            // 
            // 计量单位ToolStripMenuItem
            // 
            this.计量单位ToolStripMenuItem.Name = "计量单位ToolStripMenuItem";
            this.计量单位ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.计量单位ToolStripMenuItem.Text = "计量单位";
            this.计量单位ToolStripMenuItem.Visible = false;
            this.计量单位ToolStripMenuItem.Click += new System.EventHandler(this.计量单位ToolStripMenuItem_Click);
            // 
            // 物料信息ToolStripMenuItem
            // 
            this.物料信息ToolStripMenuItem.Name = "物料信息ToolStripMenuItem";
            this.物料信息ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.物料信息ToolStripMenuItem.Text = "物料信息";
            this.物料信息ToolStripMenuItem.Click += new System.EventHandler(this.物料信息ToolStripMenuItem_Click);
            // 
            // 物料配套ToolStripMenuItem
            // 
            this.物料配套ToolStripMenuItem.Name = "物料配套ToolStripMenuItem";
            this.物料配套ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.物料配套ToolStripMenuItem.Text = "物料配套";
            this.物料配套ToolStripMenuItem.Click += new System.EventHandler(this.物料配套ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息ToolStripMenuItem,
            this.角色信息ToolStripMenuItem,
            this.用户角色ToolStripMenuItem,
            this.角色权限ToolStripMenuItem,
            this.用户仓库ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户管理ToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.用户信息ToolStripMenuItem_Click);
            // 
            // 角色信息ToolStripMenuItem
            // 
            this.角色信息ToolStripMenuItem.Name = "角色信息ToolStripMenuItem";
            this.角色信息ToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.角色信息ToolStripMenuItem.Text = "角色信息";
            this.角色信息ToolStripMenuItem.Click += new System.EventHandler(this.角色信息ToolStripMenuItem_Click);
            // 
            // 用户角色ToolStripMenuItem
            // 
            this.用户角色ToolStripMenuItem.Name = "用户角色ToolStripMenuItem";
            this.用户角色ToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.用户角色ToolStripMenuItem.Text = "用户角色";
            this.用户角色ToolStripMenuItem.Click += new System.EventHandler(this.用户角色ToolStripMenuItem_Click);
            // 
            // 角色权限ToolStripMenuItem
            // 
            this.角色权限ToolStripMenuItem.Name = "角色权限ToolStripMenuItem";
            this.角色权限ToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.角色权限ToolStripMenuItem.Text = "角色权限";
            this.角色权限ToolStripMenuItem.Click += new System.EventHandler(this.角色权限ToolStripMenuItem_Click);
            // 
            // 用户仓库ToolStripMenuItem
            // 
            this.用户仓库ToolStripMenuItem.Name = "用户仓库ToolStripMenuItem";
            this.用户仓库ToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.用户仓库ToolStripMenuItem.Text = "用户仓库";
            this.用户仓库ToolStripMenuItem.Click += new System.EventHandler(this.用户仓库ToolStripMenuItem_Click);
            // 
            // 登录人
            // 
            this.登录人.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.登录人.AutoSize = true;
            this.登录人.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录人.ForeColor = System.Drawing.Color.White;
            this.登录人.Location = new System.Drawing.Point(1657, 35);
            this.登录人.Name = "登录人";
            this.登录人.Size = new System.Drawing.Size(49, 14);
            this.登录人.TabIndex = 2;
            this.登录人.Text = "登录人";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 身
            // 
            this.身.Dock = System.Windows.Forms.DockStyle.Fill;
            this.身.Location = new System.Drawing.Point(0, 126);
            this.身.Name = "身";
            this.身.Size = new System.Drawing.Size(1920, 954);
            this.身.TabIndex = 5;
            this.身.MouseEnter += new System.EventHandler(this.导航栏显示状态);
            // 
            // 货位管理ToolStripMenuItem
            // 
            this.货位管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.货位初始化ToolStripMenuItem,
            this.货位状态管理ToolStripMenuItem,
            this.空货位查询ToolStripMenuItem});
            this.货位管理ToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.货位管理ToolStripMenuItem.Name = "货位管理ToolStripMenuItem";
            this.货位管理ToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.货位管理ToolStripMenuItem.Text = "货位管理";
            // 
            // 货位初始化ToolStripMenuItem
            // 
            this.货位初始化ToolStripMenuItem.Name = "货位初始化ToolStripMenuItem";
            this.货位初始化ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.货位初始化ToolStripMenuItem.Text = "货位初始化";
            this.货位初始化ToolStripMenuItem.Click += new System.EventHandler(this.货位初始化ToolStripMenuItem_Click);
            // 
            // 货位状态管理ToolStripMenuItem
            // 
            this.货位状态管理ToolStripMenuItem.Name = "货位状态管理ToolStripMenuItem";
            this.货位状态管理ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.货位状态管理ToolStripMenuItem.Text = "货位状态管理";
            this.货位状态管理ToolStripMenuItem.Click += new System.EventHandler(this.货位状态管理ToolStripMenuItem_Click);
            // 
            // 空货位查询ToolStripMenuItem
            // 
            this.空货位查询ToolStripMenuItem.Name = "空货位查询ToolStripMenuItem";
            this.空货位查询ToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.空货位查询ToolStripMenuItem.Text = "空货位查询";
            this.空货位查询ToolStripMenuItem.Click += new System.EventHandler(this.空货位查询ToolStripMenuItem_Click);
            // 
            // DANG_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.身);
            this.Controls.Add(this.头);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.导航栏;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DANG_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANG_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DANG_Main_Load);
            this.头.ResumeLayout(false);
            this.头.PerformLayout();
            this.系统菜单.ResumeLayout(false);
            this.系统菜单.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.系统管理)).EndInit();
            this.时间显示.ResumeLayout(false);
            this.时间显示.PerformLayout();
            this.导航栏.ResumeLayout(false);
            this.导航栏.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel 头;
        private System.Windows.Forms.PictureBox 系统管理;
        private System.Windows.Forms.Label 登录人;
        private System.Windows.Forms.Label 退出系统;
        private System.Windows.Forms.Label 注销登录;
        private System.Windows.Forms.Label 角色;
        public System.Windows.Forms.MenuStrip 导航栏;
        private System.Windows.Forms.Label 密码修改;
        private System.Windows.Forms.TableLayoutPanel 时间显示;
        private System.Windows.Forms.Label 时分秒;
        private System.Windows.Forms.Label 年月日;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel 系统菜单;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 巷道信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料类别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 托盘格子设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存储策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 托盘标签打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户角色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户仓库ToolStripMenuItem;
        private System.Windows.Forms.Panel 身;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 托盘信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 计量单位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料配套ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货位管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货位初始化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货位状态管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空货位查询ToolStripMenuItem;
    }
}