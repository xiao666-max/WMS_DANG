﻿
namespace WMS_DANG.入出库
{
    partial class Form入库呼叫托盘
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel呼叫托盘 = new System.Windows.Forms.Panel();
            this.button呼叫托盘 = new System.Windows.Forms.Button();
            this.button退出 = new System.Windows.Forms.Button();
            this.panel选择条件 = new System.Windows.Forms.Panel();
            this.radioButton图号 = new System.Windows.Forms.RadioButton();
            this.radioButton周转箱 = new System.Windows.Forms.RadioButton();
            this.radioButton条码 = new System.Windows.Forms.RadioButton();
            this.radioButton批次 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox物料 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button托盘回库 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label作业主表数量 = new System.Windows.Forms.Label();
            this.checkBox起始时间 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker起始时间 = new System.Windows.Forms.DateTimePicker();
            this.label起始时间 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel呼叫托盘.SuspendLayout();
            this.panel选择条件.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 753);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1374, 753);
            this.dataGridView作业主表.TabIndex = 0;
            this.dataGridView作业主表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView作业主表_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel呼叫托盘);
            this.panel1.Controls.Add(this.panel选择条件);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 42);
            this.panel1.TabIndex = 7;
            // 
            // panel呼叫托盘
            // 
            this.panel呼叫托盘.Controls.Add(this.button呼叫托盘);
            this.panel呼叫托盘.Controls.Add(this.button退出);
            this.panel呼叫托盘.Location = new System.Drawing.Point(523, 3);
            this.panel呼叫托盘.Name = "panel呼叫托盘";
            this.panel呼叫托盘.Size = new System.Drawing.Size(298, 36);
            this.panel呼叫托盘.TabIndex = 20;
            // 
            // button呼叫托盘
            // 
            this.button呼叫托盘.Location = new System.Drawing.Point(3, 1);
            this.button呼叫托盘.Name = "button呼叫托盘";
            this.button呼叫托盘.Size = new System.Drawing.Size(110, 32);
            this.button呼叫托盘.TabIndex = 19;
            this.button呼叫托盘.Text = "呼叫托盘";
            this.button呼叫托盘.UseVisualStyleBackColor = true;
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(147, 1);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // panel选择条件
            // 
            this.panel选择条件.Controls.Add(this.radioButton图号);
            this.panel选择条件.Controls.Add(this.radioButton周转箱);
            this.panel选择条件.Controls.Add(this.radioButton条码);
            this.panel选择条件.Controls.Add(this.radioButton批次);
            this.panel选择条件.Controls.Add(this.label5);
            this.panel选择条件.Controls.Add(this.textBox物料);
            this.panel选择条件.Location = new System.Drawing.Point(3, 3);
            this.panel选择条件.Name = "panel选择条件";
            this.panel选择条件.Size = new System.Drawing.Size(505, 36);
            this.panel选择条件.TabIndex = 14;
            // 
            // radioButton图号
            // 
            this.radioButton图号.AutoSize = true;
            this.radioButton图号.Location = new System.Drawing.Point(182, 10);
            this.radioButton图号.Name = "radioButton图号";
            this.radioButton图号.Size = new System.Drawing.Size(47, 16);
            this.radioButton图号.TabIndex = 10;
            this.radioButton图号.TabStop = true;
            this.radioButton图号.Text = "图号";
            this.radioButton图号.UseVisualStyleBackColor = true;
            // 
            // radioButton周转箱
            // 
            this.radioButton周转箱.AutoSize = true;
            this.radioButton周转箱.Location = new System.Drawing.Point(115, 10);
            this.radioButton周转箱.Name = "radioButton周转箱";
            this.radioButton周转箱.Size = new System.Drawing.Size(59, 16);
            this.radioButton周转箱.TabIndex = 9;
            this.radioButton周转箱.TabStop = true;
            this.radioButton周转箱.Text = "周转箱";
            this.radioButton周转箱.UseVisualStyleBackColor = true;
            // 
            // radioButton条码
            // 
            this.radioButton条码.AutoSize = true;
            this.radioButton条码.Location = new System.Drawing.Point(60, 10);
            this.radioButton条码.Name = "radioButton条码";
            this.radioButton条码.Size = new System.Drawing.Size(47, 16);
            this.radioButton条码.TabIndex = 8;
            this.radioButton条码.TabStop = true;
            this.radioButton条码.Text = "条码";
            this.radioButton条码.UseVisualStyleBackColor = true;
            // 
            // radioButton批次
            // 
            this.radioButton批次.AutoSize = true;
            this.radioButton批次.Location = new System.Drawing.Point(5, 10);
            this.radioButton批次.Name = "radioButton批次";
            this.radioButton批次.Size = new System.Drawing.Size(47, 16);
            this.radioButton批次.TabIndex = 7;
            this.radioButton批次.TabStop = true;
            this.radioButton批次.Text = "批次";
            this.radioButton批次.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "回车进行查询";
            // 
            // textBox物料
            // 
            this.textBox物料.Location = new System.Drawing.Point(235, 6);
            this.textBox物料.Name = "textBox物料";
            this.textBox物料.Size = new System.Drawing.Size(160, 21);
            this.textBox物料.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button托盘回库);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.checkBox起始时间);
            this.panel4.Controls.Add(this.dateTimePicker起始时间);
            this.panel4.Controls.Add(this.label起始时间);
            this.panel4.Location = new System.Drawing.Point(5, 816);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 40);
            this.panel4.TabIndex = 7;
            // 
            // button托盘回库
            // 
            this.button托盘回库.Location = new System.Drawing.Point(1125, 43);
            this.button托盘回库.Name = "button托盘回库";
            this.button托盘回库.Size = new System.Drawing.Size(110, 32);
            this.button托盘回库.TabIndex = 17;
            this.button托盘回库.Text = "托盘回库";
            this.button托盘回库.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label作业主表数量);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1374, 35);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label作业主表数量
            // 
            this.label作业主表数量.AutoSize = true;
            this.label作业主表数量.Location = new System.Drawing.Point(6, 15);
            this.label作业主表数量.Name = "label作业主表数量";
            this.label作业主表数量.Size = new System.Drawing.Size(107, 12);
            this.label作业主表数量.TabIndex = 2;
            this.label作业主表数量.Text = "全选共[QQQ]条数据";
            // 
            // checkBox起始时间
            // 
            this.checkBox起始时间.AutoSize = true;
            this.checkBox起始时间.Location = new System.Drawing.Point(915, 12);
            this.checkBox起始时间.Name = "checkBox起始时间";
            this.checkBox起始时间.Size = new System.Drawing.Size(15, 14);
            this.checkBox起始时间.TabIndex = 11;
            this.checkBox起始时间.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker起始时间
            // 
            this.dateTimePicker起始时间.Location = new System.Drawing.Point(936, 10);
            this.dateTimePicker起始时间.Name = "dateTimePicker起始时间";
            this.dateTimePicker起始时间.Size = new System.Drawing.Size(221, 21);
            this.dateTimePicker起始时间.TabIndex = 8;
            // 
            // label起始时间
            // 
            this.label起始时间.AutoSize = true;
            this.label起始时间.Location = new System.Drawing.Point(855, 14);
            this.label起始时间.Name = "label起始时间";
            this.label起始时间.Size = new System.Drawing.Size(53, 12);
            this.label起始时间.TabIndex = 0;
            this.label起始时间.Text = "起始时间";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form入库呼叫托盘
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form入库呼叫托盘";
            this.Text = "入库呼叫托盘";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel呼叫托盘.ResumeLayout(false);
            this.panel选择条件.ResumeLayout(false);
            this.panel选择条件.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel呼叫托盘;
        private System.Windows.Forms.Button button呼叫托盘;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Panel panel选择条件;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox物料;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button托盘回库;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label作业主表数量;
        private System.Windows.Forms.CheckBox checkBox起始时间;
        private System.Windows.Forms.DateTimePicker dateTimePicker起始时间;
        private System.Windows.Forms.Label label起始时间;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton图号;
        private System.Windows.Forms.RadioButton radioButton周转箱;
        private System.Windows.Forms.RadioButton radioButton条码;
        private System.Windows.Forms.RadioButton radioButton批次;
    }
}