
namespace WMS_DANG.入出库
{
    partial class Form移库管理
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
            this.label托盘号 = new System.Windows.Forms.Label();
            this.textBox托盘号 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label货位 = new System.Windows.Forms.Label();
            this.dataGridView货位 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button查询货位 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button生成作业 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label列 = new System.Windows.Forms.Label();
            this.numericUpDown列 = new System.Windows.Forms.NumericUpDown();
            this.label层 = new System.Windows.Forms.Label();
            this.numericUpDown层 = new System.Windows.Forms.NumericUpDown();
            this.label排 = new System.Windows.Forms.Label();
            this.numericUpDown排 = new System.Windows.Forms.NumericUpDown();
            this.ComboBox区域 = new System.Windows.Forms.ComboBox();
            this.button退出 = new System.Windows.Forms.Button();
            this.label区域 = new System.Windows.Forms.Label();
            this.textBox条码 = new System.Windows.Forms.TextBox();
            this.label条码 = new System.Windows.Forms.Label();
            this.textBox批次 = new System.Windows.Forms.TextBox();
            this.label批次 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox物料 = new System.Windows.Forms.TextBox();
            this.label物料 = new System.Windows.Forms.Label();
            this.button查询 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button启动计划 = new System.Windows.Forms.Button();
            this.label库存明细 = new System.Windows.Forms.Label();
            this.dataGridView库存明细 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView货位)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown列)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown层)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown排)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView库存明细)).BeginInit();
            this.SuspendLayout();
            // 
            // label托盘号
            // 
            this.label托盘号.AutoSize = true;
            this.label托盘号.Location = new System.Drawing.Point(391, 72);
            this.label托盘号.Name = "label托盘号";
            this.label托盘号.Size = new System.Drawing.Size(41, 12);
            this.label托盘号.TabIndex = 4;
            this.label托盘号.Text = "托盘号";
            // 
            // textBox托盘号
            // 
            this.textBox托盘号.Location = new System.Drawing.Point(439, 68);
            this.textBox托盘号.Name = "textBox托盘号";
            this.textBox托盘号.Size = new System.Drawing.Size(243, 21);
            this.textBox托盘号.TabIndex = 5;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
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
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataGridView货位);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 387);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label货位);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1374, 38);
            this.panel6.TabIndex = 2;
            // 
            // label货位
            // 
            this.label货位.AutoSize = true;
            this.label货位.Location = new System.Drawing.Point(12, 13);
            this.label货位.Name = "label货位";
            this.label货位.Size = new System.Drawing.Size(29, 12);
            this.label货位.TabIndex = 2;
            this.label货位.Text = "货位";
            // 
            // dataGridView货位
            // 
            this.dataGridView货位.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView货位.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView货位.Location = new System.Drawing.Point(0, 114);
            this.dataGridView货位.Name = "dataGridView货位";
            this.dataGridView货位.RowTemplate.Height = 23;
            this.dataGridView货位.Size = new System.Drawing.Size(1374, 273);
            this.dataGridView货位.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button查询货位);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.numericUpDown2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.numericUpDown3);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button生成作业);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 60);
            this.panel4.TabIndex = 7;
            // 
            // button查询货位
            // 
            this.button查询货位.Location = new System.Drawing.Point(1087, 15);
            this.button查询货位.Name = "button查询货位";
            this.button查询货位.Size = new System.Drawing.Size(110, 32);
            this.button查询货位.TabIndex = 53;
            this.button查询货位.Text = "查询";
            this.button查询货位.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 60;
            this.label1.Text = "列";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(51, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(709, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "层";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(738, 6);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown2.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(364, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 56;
            this.label5.Text = "排";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(394, 6);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown3.TabIndex = 55;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 20);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.Text = "==请选择==";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "区域";
            // 
            // button生成作业
            // 
            this.button生成作业.Location = new System.Drawing.Point(1224, 15);
            this.button生成作业.Name = "button生成作业";
            this.button生成作业.Size = new System.Drawing.Size(110, 32);
            this.button生成作业.TabIndex = 7;
            this.button生成作业.Text = "生成作业";
            this.button生成作业.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label列);
            this.panel1.Controls.Add(this.numericUpDown列);
            this.panel1.Controls.Add(this.label层);
            this.panel1.Controls.Add(this.numericUpDown层);
            this.panel1.Controls.Add(this.label排);
            this.panel1.Controls.Add(this.numericUpDown排);
            this.panel1.Controls.Add(this.ComboBox区域);
            this.panel1.Controls.Add(this.button退出);
            this.panel1.Controls.Add(this.label区域);
            this.panel1.Controls.Add(this.textBox条码);
            this.panel1.Controls.Add(this.label条码);
            this.panel1.Controls.Add(this.textBox批次);
            this.panel1.Controls.Add(this.label批次);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox物料);
            this.panel1.Controls.Add(this.label物料);
            this.panel1.Controls.Add(this.button查询);
            this.panel1.Controls.Add(this.textBox托盘号);
            this.panel1.Controls.Add(this.label托盘号);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 100);
            this.panel1.TabIndex = 7;
            // 
            // label列
            // 
            this.label列.AutoSize = true;
            this.label列.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label列.Location = new System.Drawing.Point(35, 41);
            this.label列.Name = "label列";
            this.label列.Size = new System.Drawing.Size(17, 12);
            this.label列.TabIndex = 52;
            this.label列.Text = "列";
            // 
            // numericUpDown列
            // 
            this.numericUpDown列.Location = new System.Drawing.Point(67, 37);
            this.numericUpDown列.Name = "numericUpDown列";
            this.numericUpDown列.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown列.TabIndex = 51;
            // 
            // label层
            // 
            this.label层.AutoSize = true;
            this.label层.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label层.Location = new System.Drawing.Point(726, 17);
            this.label层.Name = "label层";
            this.label层.Size = new System.Drawing.Size(17, 12);
            this.label层.TabIndex = 50;
            this.label层.Text = "层";
            // 
            // numericUpDown层
            // 
            this.numericUpDown层.Location = new System.Drawing.Point(758, 13);
            this.numericUpDown层.Name = "numericUpDown层";
            this.numericUpDown层.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown层.TabIndex = 49;
            // 
            // label排
            // 
            this.label排.AutoSize = true;
            this.label排.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label排.Location = new System.Drawing.Point(415, 16);
            this.label排.Name = "label排";
            this.label排.Size = new System.Drawing.Size(17, 12);
            this.label排.TabIndex = 46;
            this.label排.Text = "排";
            // 
            // numericUpDown排
            // 
            this.numericUpDown排.Location = new System.Drawing.Point(439, 12);
            this.numericUpDown排.Name = "numericUpDown排";
            this.numericUpDown排.Size = new System.Drawing.Size(243, 21);
            this.numericUpDown排.TabIndex = 45;
            // 
            // ComboBox区域
            // 
            this.ComboBox区域.FormattingEnabled = true;
            this.ComboBox区域.Location = new System.Drawing.Point(67, 11);
            this.ComboBox区域.Name = "ComboBox区域";
            this.ComboBox区域.Size = new System.Drawing.Size(243, 20);
            this.ComboBox区域.TabIndex = 44;
            this.ComboBox区域.Text = "==请选择==";
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(1236, 53);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // label区域
            // 
            this.label区域.AutoSize = true;
            this.label区域.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label区域.Location = new System.Drawing.Point(23, 15);
            this.label区域.Name = "label区域";
            this.label区域.Size = new System.Drawing.Size(29, 12);
            this.label区域.TabIndex = 43;
            this.label区域.Text = "区域";
            // 
            // textBox条码
            // 
            this.textBox条码.Location = new System.Drawing.Point(66, 64);
            this.textBox条码.Name = "textBox条码";
            this.textBox条码.Size = new System.Drawing.Size(243, 21);
            this.textBox条码.TabIndex = 21;
            // 
            // label条码
            // 
            this.label条码.AutoSize = true;
            this.label条码.Location = new System.Drawing.Point(23, 68);
            this.label条码.Name = "label条码";
            this.label条码.Size = new System.Drawing.Size(29, 12);
            this.label条码.TabIndex = 20;
            this.label条码.Text = "条码";
            // 
            // textBox批次
            // 
            this.textBox批次.Location = new System.Drawing.Point(758, 44);
            this.textBox批次.Name = "textBox批次";
            this.textBox批次.Size = new System.Drawing.Size(243, 21);
            this.textBox批次.TabIndex = 19;
            // 
            // label批次
            // 
            this.label批次.AutoSize = true;
            this.label批次.Location = new System.Drawing.Point(714, 48);
            this.label批次.Name = "label批次";
            this.label批次.Size = new System.Drawing.Size(29, 12);
            this.label批次.TabIndex = 18;
            this.label批次.Text = "批次";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox物料
            // 
            this.textBox物料.Location = new System.Drawing.Point(439, 41);
            this.textBox物料.Name = "textBox物料";
            this.textBox物料.Size = new System.Drawing.Size(179, 21);
            this.textBox物料.TabIndex = 12;
            // 
            // label物料
            // 
            this.label物料.AutoSize = true;
            this.label物料.Location = new System.Drawing.Point(403, 45);
            this.label物料.Name = "label物料";
            this.label物料.Size = new System.Drawing.Size(29, 12);
            this.label物料.TabIndex = 11;
            this.label物料.Text = "物料";
            // 
            // button查询
            // 
            this.button查询.Location = new System.Drawing.Point(1087, 53);
            this.button查询.Name = "button查询";
            this.button查询.Size = new System.Drawing.Size(110, 32);
            this.button查询.TabIndex = 6;
            this.button查询.Text = "查询";
            this.button查询.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView库存明细);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 258);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button启动计划);
            this.panel3.Controls.Add(this.label库存明细);
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
            // label库存明细
            // 
            this.label库存明细.AutoSize = true;
            this.label库存明细.Location = new System.Drawing.Point(12, 13);
            this.label库存明细.Name = "label库存明细";
            this.label库存明细.Size = new System.Drawing.Size(77, 12);
            this.label库存明细.TabIndex = 1;
            this.label库存明细.Text = "装配指令信息";
            // 
            // dataGridView库存明细
            // 
            this.dataGridView库存明细.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView库存明细.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView库存明细.Location = new System.Drawing.Point(0, 46);
            this.dataGridView库存明细.Name = "dataGridView库存明细";
            this.dataGridView库存明细.RowTemplate.Height = 23;
            this.dataGridView库存明细.Size = new System.Drawing.Size(1374, 212);
            this.dataGridView库存明细.TabIndex = 0;
            // 
            // Form移库管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form移库管理";
            this.Text = "移库管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView货位)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown列)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown层)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown排)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView库存明细)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label托盘号;
        private System.Windows.Forms.TextBox textBox托盘号;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label库存明细;
        private System.Windows.Forms.DataGridView dataGridView库存明细;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button生成作业;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView货位;
        private System.Windows.Forms.Button button查询;
        private System.Windows.Forms.TextBox textBox物料;
        private System.Windows.Forms.Label label物料;
        private System.Windows.Forms.Button button启动计划;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox条码;
        private System.Windows.Forms.Label label条码;
        private System.Windows.Forms.TextBox textBox批次;
        private System.Windows.Forms.Label label批次;
        private System.Windows.Forms.Label label列;
        private System.Windows.Forms.NumericUpDown numericUpDown列;
        private System.Windows.Forms.Label label层;
        private System.Windows.Forms.NumericUpDown numericUpDown层;
        private System.Windows.Forms.Label label排;
        private System.Windows.Forms.NumericUpDown numericUpDown排;
        private System.Windows.Forms.ComboBox ComboBox区域;
        private System.Windows.Forms.Label label区域;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label货位;
        private System.Windows.Forms.Button button查询货位;
    }
}