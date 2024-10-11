
namespace WMS_DANG.用户管理
{
    partial class 角色信息
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
            this.标题栏 = new System.Windows.Forms.TableLayoutPanel();
            this.标题 = new System.Windows.Forms.Label();
            this.退出 = new System.Windows.Forms.PictureBox();
            this.标题栏.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.退出)).BeginInit();
            this.SuspendLayout();
            // 
            // 标题栏
            // 
            this.标题栏.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.标题栏.ColumnCount = 3;
            this.标题栏.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.标题栏.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.标题栏.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.标题栏.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.标题栏.Controls.Add(this.标题, 1, 0);
            this.标题栏.Controls.Add(this.退出, 0, 0);
            this.标题栏.Dock = System.Windows.Forms.DockStyle.Top;
            this.标题栏.Location = new System.Drawing.Point(0, 0);
            this.标题栏.Name = "标题栏";
            this.标题栏.RowCount = 1;
            this.标题栏.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.标题栏.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.标题栏.Size = new System.Drawing.Size(1904, 31);
            this.标题栏.TabIndex = 4;
            // 
            // 标题
            // 
            this.标题.AutoSize = true;
            this.标题.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.标题.Dock = System.Windows.Forms.DockStyle.Fill;
            this.标题.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标题.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.标题.Location = new System.Drawing.Point(53, 0);
            this.标题.Name = "标题";
            this.标题.Size = new System.Drawing.Size(1798, 31);
            this.标题.TabIndex = 0;
            this.标题.Text = "标题";
            this.标题.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 退出
            // 
            this.退出.Image = global::WMS_DANG.Properties.Resources.退出;
            this.退出.Location = new System.Drawing.Point(3, 3);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(44, 25);
            this.退出.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.退出.TabIndex = 1;
            this.退出.TabStop = false;
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 角色信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 915);
            this.Controls.Add(this.标题栏);
            this.Name = "角色信息";
            this.Text = "角色信息";
            this.Load += new System.EventHandler(this.角色信息_Load);
            this.标题栏.ResumeLayout(false);
            this.标题栏.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.退出)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel 标题栏;
        private System.Windows.Forms.Label 标题;
        private System.Windows.Forms.PictureBox 退出;
    }
}