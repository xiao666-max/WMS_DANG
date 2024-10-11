
namespace WMS_DANG
{
    partial class 登录界面
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录界面));
            this.登录按钮 = new System.Windows.Forms.Button();
            this.退出按钮 = new System.Windows.Forms.PictureBox();
            this.键盘 = new System.Windows.Forms.PictureBox();
            this.登陆输入框 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.账号输入框 = new System.Windows.Forms.TextBox();
            this.密码输入框 = new System.Windows.Forms.TextBox();
            this.提示 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.退出按钮)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.键盘)).BeginInit();
            this.登陆输入框.SuspendLayout();
            this.SuspendLayout();
            // 
            // 登录按钮
            // 
            this.登录按钮.BackColor = System.Drawing.Color.Gray;
            this.登录按钮.Dock = System.Windows.Forms.DockStyle.Fill;
            this.登录按钮.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.登录按钮.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录按钮.ForeColor = System.Drawing.Color.Black;
            this.登录按钮.Location = new System.Drawing.Point(3, 99);
            this.登录按钮.Name = "登录按钮";
            this.登录按钮.Size = new System.Drawing.Size(267, 42);
            this.登录按钮.TabIndex = 0;
            this.登录按钮.Text = "登录";
            this.登录按钮.UseVisualStyleBackColor = false;
            this.登录按钮.Click += new System.EventHandler(this.登录按钮_Click);
            this.登录按钮.MouseDown += new System.Windows.Forms.MouseEventHandler(this.登录按钮_MouseDown);
            this.登录按钮.MouseEnter += new System.EventHandler(this.登录按钮_MouseEnter);
            this.登录按钮.MouseLeave += new System.EventHandler(this.登录按钮_MouseLeave);
            this.登录按钮.MouseUp += new System.Windows.Forms.MouseEventHandler(this.登录按钮_MouseUp);
            // 
            // 退出按钮
            // 
            this.退出按钮.Image = global::WMS_DANG.Properties.Resources.关闭2;
            this.退出按钮.Location = new System.Drawing.Point(27, 332);
            this.退出按钮.Name = "退出按钮";
            this.退出按钮.Size = new System.Drawing.Size(40, 40);
            this.退出按钮.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.退出按钮.TabIndex = 13;
            this.退出按钮.TabStop = false;
            this.退出按钮.Click += new System.EventHandler(this.退出按钮_Click_1);
            this.退出按钮.MouseEnter += new System.EventHandler(this.退出按钮_MouseEnter);
            this.退出按钮.MouseLeave += new System.EventHandler(this.退出按钮_MouseLeave);
            // 
            // 键盘
            // 
            this.键盘.Image = global::WMS_DANG.Properties.Resources.键盘1;
            this.键盘.Location = new System.Drawing.Point(429, 332);
            this.键盘.Name = "键盘";
            this.键盘.Size = new System.Drawing.Size(71, 40);
            this.键盘.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.键盘.TabIndex = 12;
            this.键盘.TabStop = false;
            this.键盘.Visible = false;
            this.键盘.Click += new System.EventHandler(this.键盘_Click);
            // 
            // 登陆输入框
            // 
            this.登陆输入框.BackColor = System.Drawing.Color.Black;
            this.登陆输入框.ColumnCount = 1;
            this.登陆输入框.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.登陆输入框.Controls.Add(this.button1, 0, 3);
            this.登陆输入框.Controls.Add(this.账号输入框, 0, 0);
            this.登陆输入框.Controls.Add(this.密码输入框, 0, 1);
            this.登陆输入框.Controls.Add(this.登录按钮, 0, 2);
            this.登陆输入框.Location = new System.Drawing.Point(123, 115);
            this.登陆输入框.Name = "登陆输入框";
            this.登陆输入框.RowCount = 4;
            this.登陆输入框.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.登陆输入框.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.登陆输入框.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.登陆输入框.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.登陆输入框.Size = new System.Drawing.Size(273, 145);
            this.登陆输入框.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 1);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 账号输入框
            // 
            this.账号输入框.BackColor = System.Drawing.Color.White;
            this.账号输入框.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.账号输入框.Dock = System.Windows.Forms.DockStyle.Fill;
            this.账号输入框.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账号输入框.ForeColor = System.Drawing.Color.Black;
            this.账号输入框.Location = new System.Drawing.Point(3, 3);
            this.账号输入框.MaxLength = 20;
            this.账号输入框.Name = "账号输入框";
            this.账号输入框.Size = new System.Drawing.Size(267, 40);
            this.账号输入框.TabIndex = 10;
            this.账号输入框.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 密码输入框
            // 
            this.密码输入框.BackColor = System.Drawing.Color.White;
            this.密码输入框.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.密码输入框.Dock = System.Windows.Forms.DockStyle.Fill;
            this.密码输入框.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码输入框.ForeColor = System.Drawing.Color.Black;
            this.密码输入框.Location = new System.Drawing.Point(3, 51);
            this.密码输入框.MaxLength = 20;
            this.密码输入框.Name = "密码输入框";
            this.密码输入框.Size = new System.Drawing.Size(267, 40);
            this.密码输入框.TabIndex = 0;
            this.密码输入框.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.密码输入框.UseSystemPasswordChar = true;
            // 
            // 提示
            // 
            this.提示.AutoSize = true;
            this.提示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.提示.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.提示.ForeColor = System.Drawing.Color.Gray;
            this.提示.Location = new System.Drawing.Point(179, 275);
            this.提示.Name = "提示";
            this.提示.Size = new System.Drawing.Size(161, 14);
            this.提示.TabIndex = 15;
            this.提示.Text = "密码不正确。请再试一次";
            this.提示.Visible = false;
            // 
            // 登录界面
            // 
            this.AcceptButton = this.登录按钮;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(512, 384);
            this.ControlBox = false;
            this.Controls.Add(this.提示);
            this.Controls.Add(this.登陆输入框);
            this.Controls.Add(this.退出按钮);
            this.Controls.Add(this.键盘);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "登录界面";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Click += new System.EventHandler(this.登录界面_Click);
            ((System.ComponentModel.ISupportInitialize)(this.退出按钮)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.键盘)).EndInit();
            this.登陆输入框.ResumeLayout(false);
            this.登陆输入框.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 登录按钮;
        private System.Windows.Forms.PictureBox 键盘;
        private System.Windows.Forms.PictureBox 退出按钮;
        private System.Windows.Forms.TableLayoutPanel 登陆输入框;
        private System.Windows.Forms.TextBox 账号输入框;
        private System.Windows.Forms.TextBox 密码输入框;
        private System.Windows.Forms.Label 提示;
        private System.Windows.Forms.Button button1;
    }
}

