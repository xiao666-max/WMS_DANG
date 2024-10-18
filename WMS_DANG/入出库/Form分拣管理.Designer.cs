
namespace WMS_DANG.入出库
{
    partial class Form分拣管理
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
            this.label装配条码 = new System.Windows.Forms.Label();
            this.label托盘号 = new System.Windows.Forms.Label();
            this.textBox托盘号装配指令 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button设置恢复 = new System.Windows.Forms.Button();
            this.button设置暂停 = new System.Windows.Forms.Button();
            this.button设置普通 = new System.Windows.Forms.Button();
            this.button删除作业 = new System.Windows.Forms.Button();
            this.button设置完成 = new System.Windows.Forms.Button();
            this.button到达拣货口 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView出库计划 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox条码批次号 = new System.Windows.Forms.TextBox();
            this.radioButton条码 = new System.Windows.Forms.RadioButton();
            this.radioButton批次号 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox扫描条码 = new System.Windows.Forms.TextBox();
            this.textBox装配条码 = new System.Windows.Forms.TextBox();
            this.button原托盘回库 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button条码扫描 = new System.Windows.Forms.Button();
            this.label图号 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView出库 = new System.Windows.Forms.DataGridView();
            this.radioButton托盘号 = new System.Windows.Forms.RadioButton();
            this.radioButton装配指令 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button盘点确认 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label目标托盘信息 = new System.Windows.Forms.Label();
            this.dataGridView目标托盘信息 = new System.Windows.Forms.DataGridView();
            this.button退出 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button目标托盘回库 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox目标托盘号 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView出库计划)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView出库)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView目标托盘信息)).BeginInit();
            this.SuspendLayout();
            // 
            // label装配条码
            // 
            this.label装配条码.AutoSize = true;
            this.label装配条码.Location = new System.Drawing.Point(6, 17);
            this.label装配条码.Name = "label装配条码";
            this.label装配条码.Size = new System.Drawing.Size(53, 12);
            this.label装配条码.TabIndex = 0;
            this.label装配条码.Text = "装配条码";
            // 
            // label托盘号
            // 
            this.label托盘号.AutoSize = true;
            this.label托盘号.ForeColor = System.Drawing.Color.Maroon;
            this.label托盘号.Location = new System.Drawing.Point(286, 7);
            this.label托盘号.Name = "label托盘号";
            this.label托盘号.Size = new System.Drawing.Size(77, 12);
            this.label托盘号.TabIndex = 4;
            this.label托盘号.Text = "回车进行查询";
            // 
            // textBox托盘号装配指令
            // 
            this.textBox托盘号装配指令.Location = new System.Drawing.Point(149, 4);
            this.textBox托盘号装配指令.Name = "textBox托盘号装配指令";
            this.textBox托盘号装配指令.Size = new System.Drawing.Size(131, 21);
            this.textBox托盘号装配指令.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label作业明细数量, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1884, 861);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label作业明细数量
            // 
            this.label作业明细数量.AutoSize = true;
            this.label作业明细数量.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label作业明细数量.Location = new System.Drawing.Point(5, 858);
            this.label作业明细数量.Name = "label作业明细数量";
            this.label作业明细数量.Size = new System.Drawing.Size(1874, 1);
            this.label作业明细数量.TabIndex = 7;
            this.label作业明细数量.Text = "共[QQQ]条数据";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button设置恢复);
            this.panel4.Controls.Add(this.button设置暂停);
            this.panel4.Controls.Add(this.button设置普通);
            this.panel4.Controls.Add(this.button删除作业);
            this.panel4.Controls.Add(this.button设置完成);
            this.panel4.Controls.Add(this.button到达拣货口);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 855);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1874, 1);
            this.panel4.TabIndex = 7;
            // 
            // button设置恢复
            // 
            this.button设置恢复.Location = new System.Drawing.Point(722, 5);
            this.button设置恢复.Name = "button设置恢复";
            this.button设置恢复.Size = new System.Drawing.Size(110, 32);
            this.button设置恢复.TabIndex = 6;
            this.button设置恢复.Text = "设置恢复";
            this.button设置恢复.UseVisualStyleBackColor = true;
            this.button设置恢复.Visible = false;
            // 
            // button设置暂停
            // 
            this.button设置暂停.Location = new System.Drawing.Point(605, 5);
            this.button设置暂停.Name = "button设置暂停";
            this.button设置暂停.Size = new System.Drawing.Size(110, 32);
            this.button设置暂停.TabIndex = 5;
            this.button设置暂停.Text = "设置暂停";
            this.button设置暂停.UseVisualStyleBackColor = true;
            this.button设置暂停.Visible = false;
            // 
            // button设置普通
            // 
            this.button设置普通.Location = new System.Drawing.Point(488, 5);
            this.button设置普通.Name = "button设置普通";
            this.button设置普通.Size = new System.Drawing.Size(110, 32);
            this.button设置普通.TabIndex = 4;
            this.button设置普通.Text = "设置普通";
            this.button设置普通.UseVisualStyleBackColor = true;
            this.button设置普通.Visible = false;
            // 
            // button删除作业
            // 
            this.button删除作业.Location = new System.Drawing.Point(371, 5);
            this.button删除作业.Name = "button删除作业";
            this.button删除作业.Size = new System.Drawing.Size(110, 32);
            this.button删除作业.TabIndex = 3;
            this.button删除作业.Text = "删除作业";
            this.button删除作业.UseVisualStyleBackColor = true;
            this.button删除作业.Visible = false;
            // 
            // button设置完成
            // 
            this.button设置完成.Location = new System.Drawing.Point(254, 5);
            this.button设置完成.Name = "button设置完成";
            this.button设置完成.Size = new System.Drawing.Size(110, 32);
            this.button设置完成.TabIndex = 1;
            this.button设置完成.Text = "设置完成";
            this.button设置完成.UseVisualStyleBackColor = true;
            this.button设置完成.Visible = false;
            // 
            // button到达拣货口
            // 
            this.button到达拣货口.Location = new System.Drawing.Point(120, 5);
            this.button到达拣货口.Name = "button到达拣货口";
            this.button到达拣货口.Size = new System.Drawing.Size(110, 32);
            this.button到达拣货口.TabIndex = 0;
            this.button到达拣货口.Text = "到达拣货口";
            this.button到达拣货口.UseVisualStyleBackColor = true;
            this.button到达拣货口.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1874, 334);
            this.panel1.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.dataGridView出库计划);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.textBox条码批次号);
            this.panel8.Controls.Add(this.radioButton条码);
            this.panel8.Controls.Add(this.radioButton批次号);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.textBox扫描条码);
            this.panel8.Controls.Add(this.label装配条码);
            this.panel8.Controls.Add(this.textBox装配条码);
            this.panel8.Controls.Add(this.button原托盘回库);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.button条码扫描);
            this.panel8.Controls.Add(this.label图号);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(512, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1355, 315);
            this.panel8.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "共[QQQ]条数据";
            // 
            // dataGridView出库计划
            // 
            this.dataGridView出库计划.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView出库计划.Location = new System.Drawing.Point(4, 71);
            this.dataGridView出库计划.Name = "dataGridView出库计划";
            this.dataGridView出库计划.RowTemplate.Height = 23;
            this.dataGridView出库计划.Size = new System.Drawing.Size(1348, 216);
            this.dataGridView出库计划.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "条码--";
            // 
            // textBox条码批次号
            // 
            this.textBox条码批次号.Location = new System.Drawing.Point(126, 41);
            this.textBox条码批次号.Name = "textBox条码批次号";
            this.textBox条码批次号.Size = new System.Drawing.Size(137, 21);
            this.textBox条码批次号.TabIndex = 17;
            // 
            // radioButton条码
            // 
            this.radioButton条码.AutoSize = true;
            this.radioButton条码.Location = new System.Drawing.Point(8, 43);
            this.radioButton条码.Name = "radioButton条码";
            this.radioButton条码.Size = new System.Drawing.Size(47, 16);
            this.radioButton条码.TabIndex = 15;
            this.radioButton条码.TabStop = true;
            this.radioButton条码.Text = "条码";
            this.radioButton条码.UseVisualStyleBackColor = true;
            // 
            // radioButton批次号
            // 
            this.radioButton批次号.AutoSize = true;
            this.radioButton批次号.Location = new System.Drawing.Point(61, 43);
            this.radioButton批次号.Name = "radioButton批次号";
            this.radioButton批次号.Size = new System.Drawing.Size(59, 16);
            this.radioButton批次号.TabIndex = 16;
            this.radioButton批次号.TabStop = true;
            this.radioButton批次号.Text = "批次号";
            this.radioButton批次号.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "批量-----托盘";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox扫描条码
            // 
            this.textBox扫描条码.Location = new System.Drawing.Point(245, 13);
            this.textBox扫描条码.Name = "textBox扫描条码";
            this.textBox扫描条码.Size = new System.Drawing.Size(156, 21);
            this.textBox扫描条码.TabIndex = 11;
            // 
            // textBox装配条码
            // 
            this.textBox装配条码.Location = new System.Drawing.Point(66, 13);
            this.textBox装配条码.Name = "textBox装配条码";
            this.textBox装配条码.Size = new System.Drawing.Size(137, 21);
            this.textBox装配条码.TabIndex = 9;
            // 
            // button原托盘回库
            // 
            this.button原托盘回库.Location = new System.Drawing.Point(722, 33);
            this.button原托盘回库.Name = "button原托盘回库";
            this.button原托盘回库.Size = new System.Drawing.Size(110, 32);
            this.button原托盘回库.TabIndex = 7;
            this.button原托盘回库.Text = "原托盘回库";
            this.button原托盘回库.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(407, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "2、---------";
            // 
            // button条码扫描
            // 
            this.button条码扫描.Location = new System.Drawing.Point(490, 35);
            this.button条码扫描.Name = "button条码扫描";
            this.button条码扫描.Size = new System.Drawing.Size(110, 32);
            this.button条码扫描.TabIndex = 6;
            this.button条码扫描.Text = "条码扫描";
            this.button条码扫描.UseVisualStyleBackColor = true;
            // 
            // label图号
            // 
            this.label图号.AutoSize = true;
            this.label图号.Location = new System.Drawing.Point(210, 16);
            this.label图号.Name = "label图号";
            this.label图号.Size = new System.Drawing.Size(29, 12);
            this.label图号.TabIndex = 10;
            this.label图号.Text = "图号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(407, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "1、----------------------";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView出库);
            this.panel7.Controls.Add(this.textBox托盘号装配指令);
            this.panel7.Controls.Add(this.label托盘号);
            this.panel7.Controls.Add(this.radioButton托盘号);
            this.panel7.Controls.Add(this.radioButton装配指令);
            this.panel7.Location = new System.Drawing.Point(0, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(509, 315);
            this.panel7.TabIndex = 14;
            // 
            // dataGridView出库
            // 
            this.dataGridView出库.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView出库.Location = new System.Drawing.Point(7, 35);
            this.dataGridView出库.Name = "dataGridView出库";
            this.dataGridView出库.RowTemplate.Height = 23;
            this.dataGridView出库.Size = new System.Drawing.Size(499, 277);
            this.dataGridView出库.TabIndex = 9;
            // 
            // radioButton托盘号
            // 
            this.radioButton托盘号.AutoSize = true;
            this.radioButton托盘号.Location = new System.Drawing.Point(7, 6);
            this.radioButton托盘号.Name = "radioButton托盘号";
            this.radioButton托盘号.Size = new System.Drawing.Size(59, 16);
            this.radioButton托盘号.TabIndex = 7;
            this.radioButton托盘号.TabStop = true;
            this.radioButton托盘号.Text = "托盘号";
            this.radioButton托盘号.UseVisualStyleBackColor = true;
            // 
            // radioButton装配指令
            // 
            this.radioButton装配指令.AutoSize = true;
            this.radioButton装配指令.Location = new System.Drawing.Point(72, 6);
            this.radioButton装配指令.Name = "radioButton装配指令";
            this.radioButton装配指令.Size = new System.Drawing.Size(71, 16);
            this.radioButton装配指令.TabIndex = 8;
            this.radioButton装配指令.TabStop = true;
            this.radioButton装配指令.Text = "装配指令";
            this.radioButton装配指令.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Location = new System.Drawing.Point(5, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1874, 500);
            this.panel2.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.button盘点确认);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.panel5);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Location = new System.Drawing.Point(5, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(501, 494);
            this.panel11.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "看不清的文字-------------";
            // 
            // button盘点确认
            // 
            this.button盘点确认.Location = new System.Drawing.Point(382, 8);
            this.button盘点确认.Name = "button盘点确认";
            this.button盘点确认.Size = new System.Drawing.Size(110, 32);
            this.button盘点确认.TabIndex = 21;
            this.button盘点确认.Text = "盘点确认";
            this.button盘点确认.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(253, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 217);
            this.panel6.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(4, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 217);
            this.panel3.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(253, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 217);
            this.panel5.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(4, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(243, 217);
            this.panel9.TabIndex = 24;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label目标托盘信息);
            this.panel10.Controls.Add(this.dataGridView目标托盘信息);
            this.panel10.Controls.Add(this.button退出);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.button目标托盘回库);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.textBox目标托盘号);
            this.panel10.Location = new System.Drawing.Point(512, 9);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1359, 488);
            this.panel10.TabIndex = 32;
            // 
            // label目标托盘信息
            // 
            this.label目标托盘信息.AutoSize = true;
            this.label目标托盘信息.ForeColor = System.Drawing.Color.Maroon;
            this.label目标托盘信息.Location = new System.Drawing.Point(3, 10);
            this.label目标托盘信息.Name = "label目标托盘信息";
            this.label目标托盘信息.Size = new System.Drawing.Size(77, 12);
            this.label目标托盘信息.TabIndex = 27;
            this.label目标托盘信息.Text = "目标托盘信息";
            // 
            // dataGridView目标托盘信息
            // 
            this.dataGridView目标托盘信息.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView目标托盘信息.Location = new System.Drawing.Point(8, 57);
            this.dataGridView目标托盘信息.Name = "dataGridView目标托盘信息";
            this.dataGridView目标托盘信息.RowTemplate.Height = 23;
            this.dataGridView目标托盘信息.Size = new System.Drawing.Size(1344, 419);
            this.dataGridView目标托盘信息.TabIndex = 31;
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(742, 12);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(315, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "回车进行查询";
            // 
            // button目标托盘回库
            // 
            this.button目标托盘回库.Location = new System.Drawing.Point(546, 12);
            this.button目标托盘回库.Name = "button目标托盘回库";
            this.button目标托盘回库.Size = new System.Drawing.Size(110, 32);
            this.button目标托盘回库.TabIndex = 26;
            this.button目标托盘回库.Text = "目标托盘回库";
            this.button目标托盘回库.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "扫描目标托盘号";
            // 
            // textBox目标托盘号
            // 
            this.textBox目标托盘号.Location = new System.Drawing.Point(95, 30);
            this.textBox目标托盘号.Name = "textBox目标托盘号";
            this.textBox目标托盘号.Size = new System.Drawing.Size(214, 21);
            this.textBox目标托盘号.TabIndex = 29;
            // 
            // Form分拣管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form分拣管理";
            this.Text = "分拣管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView出库计划)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView出库)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView目标托盘信息)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label装配条码;
        private System.Windows.Forms.Label label托盘号;
        private System.Windows.Forms.TextBox textBox托盘号装配指令;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button设置完成;
        private System.Windows.Forms.Button button到达拣货口;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button原托盘回库;
        private System.Windows.Forms.Button button设置恢复;
        private System.Windows.Forms.Button button设置暂停;
        private System.Windows.Forms.Button button设置普通;
        private System.Windows.Forms.Button button删除作业;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Button button条码扫描;
        private System.Windows.Forms.RadioButton radioButton装配指令;
        private System.Windows.Forms.RadioButton radioButton托盘号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox扫描条码;
        private System.Windows.Forms.Label label图号;
        private System.Windows.Forms.TextBox textBox装配条码;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView出库;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView出库计划;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox条码批次号;
        private System.Windows.Forms.RadioButton radioButton条码;
        private System.Windows.Forms.RadioButton radioButton批次号;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button盘点确认;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox目标托盘号;
        private System.Windows.Forms.Label label目标托盘信息;
        private System.Windows.Forms.Button button目标托盘回库;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView目标托盘信息;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
    }
}