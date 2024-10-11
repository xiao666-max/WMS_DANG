
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
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.label作业主表 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(367, 185);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.3121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.6879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 238);
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
            this.panel2.Controls.Add(this.label作业主表);
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Location = new System.Drawing.Point(36, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 248);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 15);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(368, 233);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // label作业主表
            // 
            this.label作业主表.AutoSize = true;
            this.label作业主表.Dock = System.Windows.Forms.DockStyle.Top;
            this.label作业主表.Location = new System.Drawing.Point(0, 0);
            this.label作业主表.Name = "label作业主表";
            this.label作业主表.Size = new System.Drawing.Size(53, 12);
            this.label作业主表.TabIndex = 1;
            this.label作业主表.Text = "作业主表";
            // 
            // Form作业管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form作业管理";
            this.Text = "作业管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
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
    }
}