
namespace WMS_DANG.入出库
{
    partial class Form作业管理
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
            this.label区域 = new System.Windows.Forms.Label();
            this.comboBox区域 = new System.Windows.Forms.ComboBox();
            this.comboBox设备 = new System.Windows.Forms.ComboBox();
            this.label设备 = new System.Windows.Forms.Label();
            this.label托盘号 = new System.Windows.Forms.Label();
            this.textBox托盘号 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label作业主表 = new System.Windows.Forms.Label();
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button到达拣货口 = new System.Windows.Forms.Button();
            this.button设置完成 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button设置普通 = new System.Windows.Forms.Button();
            this.button删除作业 = new System.Windows.Forms.Button();
            this.button设置恢复 = new System.Windows.Forms.Button();
            this.button设置暂停 = new System.Windows.Forms.Button();
            this.button申请货位 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label区域
            // 
            this.label区域.AutoSize = true;
            this.label区域.Location = new System.Drawing.Point(25, 12);
            this.label区域.Name = "label区域";
            this.label区域.Size = new System.Drawing.Size(29, 12);
            this.label区域.TabIndex = 0;
            this.label区域.Text = "区域";
            // 
            // comboBox区域
            // 
            this.comboBox区域.FormattingEnabled = true;
            this.comboBox区域.Location = new System.Drawing.Point(60, 9);
            this.comboBox区域.Name = "comboBox区域";
            this.comboBox区域.Size = new System.Drawing.Size(247, 20);
            this.comboBox区域.TabIndex = 1;
            this.comboBox区域.Text = "==请选择==";
            // 
            // comboBox设备
            // 
            this.comboBox设备.FormattingEnabled = true;
            this.comboBox设备.Location = new System.Drawing.Point(375, 9);
            this.comboBox设备.Name = "comboBox设备";
            this.comboBox设备.Size = new System.Drawing.Size(247, 20);
            this.comboBox设备.TabIndex = 3;
            this.comboBox设备.Text = "==请选择==";
            // 
            // label设备
            // 
            this.label设备.AutoSize = true;
            this.label设备.Location = new System.Drawing.Point(340, 12);
            this.label设备.Name = "label设备";
            this.label设备.Size = new System.Drawing.Size(29, 12);
            this.label设备.TabIndex = 2;
            this.label设备.Text = "设备";
            // 
            // label托盘号
            // 
            this.label托盘号.AutoSize = true;
            this.label托盘号.Location = new System.Drawing.Point(13, 38);
            this.label托盘号.Name = "label托盘号";
            this.label托盘号.Size = new System.Drawing.Size(41, 12);
            this.label托盘号.TabIndex = 4;
            this.label托盘号.Text = "托盘号";
            // 
            // textBox托盘号
            // 
            this.textBox托盘号.Location = new System.Drawing.Point(60, 35);
            this.textBox托盘号.Name = "textBox托盘号";
            this.textBox托盘号.Size = new System.Drawing.Size(100, 21);
            this.textBox托盘号.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.12048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 516);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox区域);
            this.panel1.Controls.Add(this.textBox托盘号);
            this.panel1.Controls.Add(this.label区域);
            this.panel1.Controls.Add(this.label托盘号);
            this.panel1.Controls.Add(this.comboBox设备);
            this.panel1.Controls.Add(this.label设备);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 62);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 311);
            this.panel2.TabIndex = 7;
            // 
            // label作业主表
            // 
            this.label作业主表.AutoSize = true;
            this.label作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label作业主表.Location = new System.Drawing.Point(0, 0);
            this.label作业主表.Name = "label作业主表";
            this.label作业主表.Size = new System.Drawing.Size(53, 12);
            this.label作业主表.TabIndex = 1;
            this.label作业主表.Text = "作业主表";
            // 
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1101, 311);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label作业主表);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 16);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button申请货位);
            this.panel4.Controls.Add(this.button设置恢复);
            this.panel4.Controls.Add(this.button设置暂停);
            this.panel4.Controls.Add(this.button设置普通);
            this.panel4.Controls.Add(this.button删除作业);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button设置完成);
            this.panel4.Controls.Add(this.button到达拣货口);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 33);
            this.panel4.TabIndex = 7;
            // 
            // button到达拣货口
            // 
            this.button到达拣货口.Location = new System.Drawing.Point(120, 5);
            this.button到达拣货口.Name = "button到达拣货口";
            this.button到达拣货口.Size = new System.Drawing.Size(110, 23);
            this.button到达拣货口.TabIndex = 0;
            this.button到达拣货口.Text = "到达拣货口";
            this.button到达拣货口.UseVisualStyleBackColor = true;
            // 
            // button设置完成
            // 
            this.button设置完成.Location = new System.Drawing.Point(254, 5);
            this.button设置完成.Name = "button设置完成";
            this.button设置完成.Size = new System.Drawing.Size(110, 23);
            this.button设置完成.TabIndex = 1;
            this.button设置完成.Text = "设置完成";
            this.button设置完成.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "共[QQQ]条数据";
            // 
            // button设置普通
            // 
            this.button设置普通.Location = new System.Drawing.Point(488, 5);
            this.button设置普通.Name = "button设置普通";
            this.button设置普通.Size = new System.Drawing.Size(110, 23);
            this.button设置普通.TabIndex = 4;
            this.button设置普通.Text = "设置普通";
            this.button设置普通.UseVisualStyleBackColor = true;
            // 
            // button删除作业
            // 
            this.button删除作业.Location = new System.Drawing.Point(371, 5);
            this.button删除作业.Name = "button删除作业";
            this.button删除作业.Size = new System.Drawing.Size(110, 23);
            this.button删除作业.TabIndex = 3;
            this.button删除作业.Text = "删除作业";
            this.button删除作业.UseVisualStyleBackColor = true;
            // 
            // button设置恢复
            // 
            this.button设置恢复.Location = new System.Drawing.Point(722, 5);
            this.button设置恢复.Name = "button设置恢复";
            this.button设置恢复.Size = new System.Drawing.Size(110, 23);
            this.button设置恢复.TabIndex = 6;
            this.button设置恢复.Text = "设置恢复";
            this.button设置恢复.UseVisualStyleBackColor = true;
            // 
            // button设置暂停
            // 
            this.button设置暂停.Location = new System.Drawing.Point(605, 5);
            this.button设置暂停.Name = "button设置暂停";
            this.button设置暂停.Size = new System.Drawing.Size(110, 23);
            this.button设置暂停.TabIndex = 5;
            this.button设置暂停.Text = "设置暂停";
            this.button设置暂停.UseVisualStyleBackColor = true;
            // 
            // button申请货位
            // 
            this.button申请货位.Location = new System.Drawing.Point(839, 5);
            this.button申请货位.Name = "button申请货位";
            this.button申请货位.Size = new System.Drawing.Size(110, 23);
            this.button申请货位.TabIndex = 7;
            this.button申请货位.Text = "申请货位";
            this.button申请货位.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "申请货位";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form作业管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form作业管理";
            this.Text = "作业管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label区域;
        private System.Windows.Forms.ComboBox comboBox区域;
        private System.Windows.Forms.ComboBox comboBox设备;
        private System.Windows.Forms.Label label设备;
        private System.Windows.Forms.Label label托盘号;
        private System.Windows.Forms.TextBox textBox托盘号;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label作业主表;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button设置完成;
        private System.Windows.Forms.Button button到达拣货口;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button申请货位;
        private System.Windows.Forms.Button button设置恢复;
        private System.Windows.Forms.Button button设置暂停;
        private System.Windows.Forms.Button button设置普通;
        private System.Windows.Forms.Button button删除作业;
    }
}