
namespace WMS_DANG.入出库
{
    partial class Form拆分条码
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
            this.label原托盘号 = new System.Windows.Forms.Label();
            this.textBox原托盘号 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView作业明细 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button添加至目标托盘 = new System.Windows.Forms.Button();
            this.label目标托盘信息 = new System.Windows.Forms.Label();
            this.button退出 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox装配条码 = new System.Windows.Forms.TextBox();
            this.label装配条码 = new System.Windows.Forms.Label();
            this.textBox批次 = new System.Windows.Forms.TextBox();
            this.label批次 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label原托盘信息 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox物料 = new System.Windows.Forms.TextBox();
            this.label物料 = new System.Windows.Forms.Label();
            this.button查询 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button启动计划 = new System.Windows.Forms.Button();
            this.label装配指令信息 = new System.Windows.Forms.Label();
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            this.SuspendLayout();
            // 
            // label原托盘号
            // 
            this.label原托盘号.AutoSize = true;
            this.label原托盘号.Location = new System.Drawing.Point(101, 18);
            this.label原托盘号.Name = "label原托盘号";
            this.label原托盘号.Size = new System.Drawing.Size(53, 12);
            this.label原托盘号.TabIndex = 4;
            this.label原托盘号.Text = "原托盘号";
            // 
            // textBox原托盘号
            // 
            this.textBox原托盘号.Location = new System.Drawing.Point(160, 14);
            this.textBox原托盘号.Name = "textBox原托盘号";
            this.textBox原托盘号.Size = new System.Drawing.Size(100, 21);
            this.textBox原托盘号.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label作业明细数量, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label作业明细数量
            // 
            this.label作业明细数量.AutoSize = true;
            this.label作业明细数量.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label作业明细数量.Location = new System.Drawing.Point(5, 839);
            this.label作业明细数量.Name = "label作业明细数量";
            this.label作业明细数量.Size = new System.Drawing.Size(1374, 20);
            this.label作业明细数量.TabIndex = 7;
            this.label作业明细数量.Text = "共[QQQ]条数据";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView作业明细);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 403);
            this.panel5.TabIndex = 8;
            // 
            // dataGridView作业明细
            // 
            this.dataGridView作业明细.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业明细.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView作业明细.Location = new System.Drawing.Point(0, 100);
            this.dataGridView作业明细.Name = "dataGridView作业明细";
            this.dataGridView作业明细.RowTemplate.Height = 23;
            this.dataGridView作业明细.Size = new System.Drawing.Size(1374, 303);
            this.dataGridView作业明细.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button添加至目标托盘);
            this.panel4.Controls.Add(this.label目标托盘信息);
            this.panel4.Controls.Add(this.button退出);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 44);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(278, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "回车进行查询";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "目标托盘号";
            // 
            // button添加至目标托盘
            // 
            this.button添加至目标托盘.Location = new System.Drawing.Point(1087, 5);
            this.button添加至目标托盘.Name = "button添加至目标托盘";
            this.button添加至目标托盘.Size = new System.Drawing.Size(110, 32);
            this.button添加至目标托盘.TabIndex = 7;
            this.button添加至目标托盘.Text = "添加至目标托盘";
            this.button添加至目标托盘.UseVisualStyleBackColor = true;
            this.button添加至目标托盘.Visible = false;
            // 
            // label目标托盘信息
            // 
            this.label目标托盘信息.AutoSize = true;
            this.label目标托盘信息.ForeColor = System.Drawing.Color.Maroon;
            this.label目标托盘信息.Location = new System.Drawing.Point(12, 15);
            this.label目标托盘信息.Name = "label目标托盘信息";
            this.label目标托盘信息.Size = new System.Drawing.Size(77, 12);
            this.label目标托盘信息.TabIndex = 2;
            this.label目标托盘信息.Text = "目标托盘信息";
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(1224, 5);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox装配条码);
            this.panel1.Controls.Add(this.label装配条码);
            this.panel1.Controls.Add(this.textBox批次);
            this.panel1.Controls.Add(this.label批次);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label原托盘信息);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox物料);
            this.panel1.Controls.Add(this.label物料);
            this.panel1.Controls.Add(this.button查询);
            this.panel1.Controls.Add(this.textBox原托盘号);
            this.panel1.Controls.Add(this.label原托盘号);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 49);
            this.panel1.TabIndex = 7;
            // 
            // textBox装配条码
            // 
            this.textBox装配条码.Location = new System.Drawing.Point(854, 15);
            this.textBox装配条码.Name = "textBox装配条码";
            this.textBox装配条码.Size = new System.Drawing.Size(100, 21);
            this.textBox装配条码.TabIndex = 21;
            // 
            // label装配条码
            // 
            this.label装配条码.AutoSize = true;
            this.label装配条码.Location = new System.Drawing.Point(791, 19);
            this.label装配条码.Name = "label装配条码";
            this.label装配条码.Size = new System.Drawing.Size(53, 12);
            this.label装配条码.TabIndex = 20;
            this.label装配条码.Text = "装配条码";
            // 
            // textBox批次
            // 
            this.textBox批次.Location = new System.Drawing.Point(655, 14);
            this.textBox批次.Name = "textBox批次";
            this.textBox批次.Size = new System.Drawing.Size(100, 21);
            this.textBox批次.TabIndex = 19;
            // 
            // label批次
            // 
            this.label批次.AutoSize = true;
            this.label批次.Location = new System.Drawing.Point(619, 18);
            this.label批次.Name = "label批次";
            this.label批次.Size = new System.Drawing.Size(29, 12);
            this.label批次.TabIndex = 18;
            this.label批次.Text = "批次";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label原托盘信息
            // 
            this.label原托盘信息.AutoSize = true;
            this.label原托盘信息.ForeColor = System.Drawing.Color.Maroon;
            this.label原托盘信息.Location = new System.Drawing.Point(7, 9);
            this.label原托盘信息.Name = "label原托盘信息";
            this.label原托盘信息.Size = new System.Drawing.Size(65, 12);
            this.label原托盘信息.TabIndex = 16;
            this.label原托盘信息.Text = "原托盘信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "共[QQQ]条数据";
            // 
            // textBox物料
            // 
            this.textBox物料.Location = new System.Drawing.Point(331, 15);
            this.textBox物料.Name = "textBox物料";
            this.textBox物料.Size = new System.Drawing.Size(100, 21);
            this.textBox物料.TabIndex = 12;
            // 
            // label物料
            // 
            this.label物料.AutoSize = true;
            this.label物料.Location = new System.Drawing.Point(295, 19);
            this.label物料.Name = "label物料";
            this.label物料.Size = new System.Drawing.Size(29, 12);
            this.label物料.TabIndex = 11;
            this.label物料.Text = "物料";
            // 
            // button查询
            // 
            this.button查询.Location = new System.Drawing.Point(1037, 9);
            this.button查询.Name = "button查询";
            this.button查询.Size = new System.Drawing.Size(110, 32);
            this.button查询.TabIndex = 6;
            this.button查询.Text = "查询";
            this.button查询.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 309);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button启动计划);
            this.panel3.Controls.Add(this.label装配指令信息);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1374, 40);
            this.panel3.TabIndex = 2;
            // 
            // button启动计划
            // 
            this.button启动计划.Location = new System.Drawing.Point(336, 4);
            this.button启动计划.Name = "button启动计划";
            this.button启动计划.Size = new System.Drawing.Size(110, 32);
            this.button启动计划.TabIndex = 8;
            this.button启动计划.Text = "启动计划";
            this.button启动计划.UseVisualStyleBackColor = true;
            // 
            // label装配指令信息
            // 
            this.label装配指令信息.AutoSize = true;
            this.label装配指令信息.Location = new System.Drawing.Point(12, 13);
            this.label装配指令信息.Name = "label装配指令信息";
            this.label装配指令信息.Size = new System.Drawing.Size(77, 12);
            this.label装配指令信息.TabIndex = 1;
            this.label装配指令信息.Text = "装配指令信息";
            // 
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 46);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1374, 263);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // Form拆分条码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form拆分条码";
            this.Text = "拆分条码";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label原托盘号;
        private System.Windows.Forms.TextBox textBox原托盘号;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label装配指令信息;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label目标托盘信息;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button添加至目标托盘;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView作业明细;
        private System.Windows.Forms.Button button查询;
        private System.Windows.Forms.TextBox textBox物料;
        private System.Windows.Forms.Label label物料;
        private System.Windows.Forms.Button button启动计划;
        private System.Windows.Forms.Label label原托盘信息;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox装配条码;
        private System.Windows.Forms.Label label装配条码;
        private System.Windows.Forms.TextBox textBox批次;
        private System.Windows.Forms.Label label批次;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}