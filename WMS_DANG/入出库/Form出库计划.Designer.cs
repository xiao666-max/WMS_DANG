
namespace WMS_DANG.入出库
{
    partial class Form出库计划
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label计划主表信息 = new System.Windows.Forms.Label();
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button查询 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox结束时间 = new System.Windows.Forms.CheckBox();
            this.checkBox起始时间 = new System.Windows.Forms.CheckBox();
            this.button退出 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label结束时间 = new System.Windows.Forms.Label();
            this.dateTimePicker起始时间 = new System.Windows.Forms.DateTimePicker();
            this.button查询物料 = new System.Windows.Forms.Button();
            this.textBox物料 = new System.Windows.Forms.TextBox();
            this.label起始时间 = new System.Windows.Forms.Label();
            this.label物料 = new System.Windows.Forms.Label();
            this.ComboBox处理状态 = new System.Windows.Forms.ComboBox();
            this.label处理状态 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label作业主表数量 = new System.Windows.Forms.Label();
            this.dataGridView作业明细 = new System.Windows.Forms.DataGridView();
            this.label计划明细信息 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label计划主表信息);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1374, 16);
            this.panel3.TabIndex = 2;
            // 
            // label计划主表信息
            // 
            this.label计划主表信息.AutoSize = true;
            this.label计划主表信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label计划主表信息.Location = new System.Drawing.Point(0, 0);
            this.label计划主表信息.Name = "label计划主表信息";
            this.label计划主表信息.Size = new System.Drawing.Size(77, 12);
            this.label计划主表信息.TabIndex = 1;
            this.label计划主表信息.Text = "计划主表信息";
            // 
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1374, 332);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 332);
            this.panel2.TabIndex = 7;
            // 
            // button查询
            // 
            this.button查询.Location = new System.Drawing.Point(228, 65);
            this.button查询.Name = "button查询";
            this.button查询.Size = new System.Drawing.Size(110, 32);
            this.button查询.TabIndex = 6;
            this.button查询.Text = "查询";
            this.button查询.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox结束时间);
            this.panel1.Controls.Add(this.checkBox起始时间);
            this.panel1.Controls.Add(this.button退出);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label结束时间);
            this.panel1.Controls.Add(this.dateTimePicker起始时间);
            this.panel1.Controls.Add(this.button查询物料);
            this.panel1.Controls.Add(this.button查询);
            this.panel1.Controls.Add(this.textBox物料);
            this.panel1.Controls.Add(this.label起始时间);
            this.panel1.Controls.Add(this.label物料);
            this.panel1.Controls.Add(this.ComboBox处理状态);
            this.panel1.Controls.Add(this.label处理状态);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 104);
            this.panel1.TabIndex = 7;
            // 
            // checkBox结束时间
            // 
            this.checkBox结束时间.AutoSize = true;
            this.checkBox结束时间.Location = new System.Drawing.Point(530, 9);
            this.checkBox结束时间.Name = "checkBox结束时间";
            this.checkBox结束时间.Size = new System.Drawing.Size(15, 14);
            this.checkBox结束时间.TabIndex = 12;
            this.checkBox结束时间.UseVisualStyleBackColor = true;
            // 
            // checkBox起始时间
            // 
            this.checkBox起始时间.AutoSize = true;
            this.checkBox起始时间.Location = new System.Drawing.Point(65, 10);
            this.checkBox起始时间.Name = "checkBox起始时间";
            this.checkBox起始时间.Size = new System.Drawing.Size(15, 14);
            this.checkBox起始时间.TabIndex = 11;
            this.checkBox起始时间.UseVisualStyleBackColor = true;
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(546, 65);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label结束时间
            // 
            this.label结束时间.AutoSize = true;
            this.label结束时间.Location = new System.Drawing.Point(470, 10);
            this.label结束时间.Name = "label结束时间";
            this.label结束时间.Size = new System.Drawing.Size(53, 12);
            this.label结束时间.TabIndex = 9;
            this.label结束时间.Text = "结束时间";
            // 
            // dateTimePicker起始时间
            // 
            this.dateTimePicker起始时间.Location = new System.Drawing.Point(86, 8);
            this.dateTimePicker起始时间.Name = "dateTimePicker起始时间";
            this.dateTimePicker起始时间.Size = new System.Drawing.Size(221, 21);
            this.dateTimePicker起始时间.TabIndex = 8;
            // 
            // button查询物料
            // 
            this.button查询物料.Location = new System.Drawing.Point(313, 28);
            this.button查询物料.Name = "button查询物料";
            this.button查询物料.Size = new System.Drawing.Size(81, 32);
            this.button查询物料.TabIndex = 7;
            this.button查询物料.Text = "查询物料";
            this.button查询物料.UseVisualStyleBackColor = true;
            // 
            // textBox物料
            // 
            this.textBox物料.Location = new System.Drawing.Point(64, 35);
            this.textBox物料.Name = "textBox物料";
            this.textBox物料.Size = new System.Drawing.Size(243, 21);
            this.textBox物料.TabIndex = 5;
            // 
            // label起始时间
            // 
            this.label起始时间.AutoSize = true;
            this.label起始时间.Location = new System.Drawing.Point(5, 12);
            this.label起始时间.Name = "label起始时间";
            this.label起始时间.Size = new System.Drawing.Size(53, 12);
            this.label起始时间.TabIndex = 0;
            this.label起始时间.Text = "起始时间";
            // 
            // label物料
            // 
            this.label物料.AutoSize = true;
            this.label物料.Location = new System.Drawing.Point(29, 38);
            this.label物料.Name = "label物料";
            this.label物料.Size = new System.Drawing.Size(29, 12);
            this.label物料.TabIndex = 4;
            this.label物料.Text = "物料";
            // 
            // ComboBox处理状态
            // 
            this.ComboBox处理状态.FormattingEnabled = true;
            this.ComboBox处理状态.Location = new System.Drawing.Point(529, 38);
            this.ComboBox处理状态.Name = "ComboBox处理状态";
            this.ComboBox处理状态.Size = new System.Drawing.Size(247, 20);
            this.ComboBox处理状态.TabIndex = 3;
            this.ComboBox处理状态.Text = "==请选择==";
            // 
            // label处理状态
            // 
            this.label处理状态.AutoSize = true;
            this.label处理状态.Location = new System.Drawing.Point(470, 41);
            this.label处理状态.Name = "label处理状态";
            this.label处理状态.Size = new System.Drawing.Size(53, 12);
            this.label处理状态.TabIndex = 2;
            this.label处理状态.Text = "处理状态";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label作业主表数量);
            this.panel4.Location = new System.Drawing.Point(5, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 1);
            this.panel4.TabIndex = 7;
            // 
            // label作业主表数量
            // 
            this.label作业主表数量.AutoSize = true;
            this.label作业主表数量.Location = new System.Drawing.Point(5, 10);
            this.label作业主表数量.Name = "label作业主表数量";
            this.label作业主表数量.Size = new System.Drawing.Size(83, 12);
            this.label作业主表数量.TabIndex = 2;
            this.label作业主表数量.Text = "共[QQQ]条数据";
            // 
            // dataGridView作业明细
            // 
            this.dataGridView作业明细.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业明细.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业明细.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业明细.Name = "dataGridView作业明细";
            this.dataGridView作业明细.RowTemplate.Height = 23;
            this.dataGridView作业明细.Size = new System.Drawing.Size(1374, 393);
            this.dataGridView作业明细.TabIndex = 0;
            // 
            // label计划明细信息
            // 
            this.label计划明细信息.AutoSize = true;
            this.label计划明细信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label计划明细信息.Location = new System.Drawing.Point(0, 0);
            this.label计划明细信息.Name = "label计划明细信息";
            this.label计划明细信息.Size = new System.Drawing.Size(77, 12);
            this.label计划明细信息.TabIndex = 1;
            this.label计划明细信息.Text = "计划明细信息";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label计划明细信息);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1374, 16);
            this.panel6.TabIndex = 2;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label作业明细数量
            // 
            this.label作业明细数量.AutoSize = true;
            this.label作业明细数量.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label作业明细数量.Location = new System.Drawing.Point(5, 858);
            this.label作业明细数量.Name = "label作业明细数量";
            this.label作业明细数量.Size = new System.Drawing.Size(1374, 1);
            this.label作业明细数量.TabIndex = 7;
            this.label作业明细数量.Text = "共[QQQ]条数据";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataGridView作业明细);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 393);
            this.panel5.TabIndex = 8;
            // 
            // Form出库计划
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form出库计划";
            this.Text = "出库计划";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label计划主表信息;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button查询;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox物料;
        private System.Windows.Forms.Label label起始时间;
        private System.Windows.Forms.Label label物料;
        private System.Windows.Forms.ComboBox ComboBox处理状态;
        private System.Windows.Forms.Label label处理状态;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Label label作业主表数量;
        private System.Windows.Forms.DataGridView dataGridView作业明细;
        private System.Windows.Forms.Label label计划明细信息;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button查询物料;
        private System.Windows.Forms.DateTimePicker dateTimePicker起始时间;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label结束时间;
        private System.Windows.Forms.CheckBox checkBox结束时间;
        private System.Windows.Forms.CheckBox checkBox起始时间;
    }
}