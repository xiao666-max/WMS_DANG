
namespace WMS_DANG.入出库
{
    partial class Form出库计划设置
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
            this.label构型 = new System.Windows.Forms.Label();
            this.textBox构型 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label已经启动的装配指令信息 = new System.Windows.Forms.Label();
            this.dataGridView作业明细 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button退出 = new System.Windows.Forms.Button();
            this.button申请货位 = new System.Windows.Forms.Button();
            this.button设置恢复 = new System.Windows.Forms.Button();
            this.button取消计划 = new System.Windows.Forms.Button();
            this.button查询计划 = new System.Windows.Forms.Button();
            this.button删除作业 = new System.Windows.Forms.Button();
            this.label作业主表数量 = new System.Windows.Forms.Label();
            this.button设置完成 = new System.Windows.Forms.Button();
            this.button到达拣货口 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button查询 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label装配指令信息 = new System.Windows.Forms.Label();
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.numericUpDown架次 = new System.Windows.Forms.NumericUpDown();
            this.label架次 = new System.Windows.Forms.Label();
            this.textBox站位 = new System.Windows.Forms.TextBox();
            this.label站位 = new System.Windows.Forms.Label();
            this.dateTimePicker开始 = new System.Windows.Forms.DateTimePicker();
            this.label需求时间 = new System.Windows.Forms.Label();
            this.dateTimePicker结束 = new System.Windows.Forms.DateTimePicker();
            this.button启动计划 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown架次)).BeginInit();
            this.SuspendLayout();
            // 
            // label构型
            // 
            this.label构型.AutoSize = true;
            this.label构型.Location = new System.Drawing.Point(12, 19);
            this.label构型.Name = "label构型";
            this.label构型.Size = new System.Drawing.Size(29, 12);
            this.label构型.TabIndex = 4;
            this.label构型.Text = "构型";
            // 
            // textBox构型
            // 
            this.textBox构型.Location = new System.Drawing.Point(53, 15);
            this.textBox构型.Name = "textBox构型";
            this.textBox构型.Size = new System.Drawing.Size(100, 21);
            this.textBox构型.TabIndex = 5;
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
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataGridView作业明细);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 403);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label已经启动的装配指令信息);
            this.panel6.Controls.Add(this.button查询计划);
            this.panel6.Controls.Add(this.button取消计划);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1374, 46);
            this.panel6.TabIndex = 2;
            // 
            // label已经启动的装配指令信息
            // 
            this.label已经启动的装配指令信息.AutoSize = true;
            this.label已经启动的装配指令信息.Location = new System.Drawing.Point(12, 17);
            this.label已经启动的装配指令信息.Name = "label已经启动的装配指令信息";
            this.label已经启动的装配指令信息.Size = new System.Drawing.Size(137, 12);
            this.label已经启动的装配指令信息.TabIndex = 1;
            this.label已经启动的装配指令信息.Text = "已经启动的装配指令信息";
            // 
            // dataGridView作业明细
            // 
            this.dataGridView作业明细.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业明细.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业明细.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业明细.Name = "dataGridView作业明细";
            this.dataGridView作业明细.RowTemplate.Height = 23;
            this.dataGridView作业明细.Size = new System.Drawing.Size(1374, 403);
            this.dataGridView作业明细.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button申请货位);
            this.panel4.Controls.Add(this.button设置恢复);
            this.panel4.Controls.Add(this.button删除作业);
            this.panel4.Controls.Add(this.label作业主表数量);
            this.panel4.Controls.Add(this.button设置完成);
            this.panel4.Controls.Add(this.button到达拣货口);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 44);
            this.panel4.TabIndex = 7;
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(1177, 9);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // button申请货位
            // 
            this.button申请货位.Location = new System.Drawing.Point(839, 5);
            this.button申请货位.Name = "button申请货位";
            this.button申请货位.Size = new System.Drawing.Size(110, 32);
            this.button申请货位.TabIndex = 7;
            this.button申请货位.Text = "申请货位";
            this.button申请货位.UseVisualStyleBackColor = true;
            this.button申请货位.Visible = false;
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
            // button取消计划
            // 
            this.button取消计划.Location = new System.Drawing.Point(596, 7);
            this.button取消计划.Name = "button取消计划";
            this.button取消计划.Size = new System.Drawing.Size(110, 32);
            this.button取消计划.TabIndex = 5;
            this.button取消计划.Text = "取消计划";
            this.button取消计划.UseVisualStyleBackColor = true;
            // 
            // button查询计划
            // 
            this.button查询计划.Location = new System.Drawing.Point(479, 7);
            this.button查询计划.Name = "button查询计划";
            this.button查询计划.Size = new System.Drawing.Size(110, 32);
            this.button查询计划.TabIndex = 4;
            this.button查询计划.Text = "查询";
            this.button查询计划.UseVisualStyleBackColor = true;
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
            // label作业主表数量
            // 
            this.label作业主表数量.AutoSize = true;
            this.label作业主表数量.Location = new System.Drawing.Point(12, 15);
            this.label作业主表数量.Name = "label作业主表数量";
            this.label作业主表数量.Size = new System.Drawing.Size(83, 12);
            this.label作业主表数量.TabIndex = 2;
            this.label作业主表数量.Text = "共[QQQ]条数据";
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
            this.panel1.Controls.Add(this.dateTimePicker结束);
            this.panel1.Controls.Add(this.label需求时间);
            this.panel1.Controls.Add(this.dateTimePicker开始);
            this.panel1.Controls.Add(this.textBox站位);
            this.panel1.Controls.Add(this.label站位);
            this.panel1.Controls.Add(this.label架次);
            this.panel1.Controls.Add(this.numericUpDown架次);
            this.panel1.Controls.Add(this.button退出);
            this.panel1.Controls.Add(this.button查询);
            this.panel1.Controls.Add(this.textBox构型);
            this.panel1.Controls.Add(this.label构型);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 49);
            this.panel1.TabIndex = 7;
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
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1374, 309);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // numericUpDown架次
            // 
            this.numericUpDown架次.Location = new System.Drawing.Point(214, 15);
            this.numericUpDown架次.Name = "numericUpDown架次";
            this.numericUpDown架次.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown架次.TabIndex = 9;
            // 
            // label架次
            // 
            this.label架次.AutoSize = true;
            this.label架次.Location = new System.Drawing.Point(179, 19);
            this.label架次.Name = "label架次";
            this.label架次.Size = new System.Drawing.Size(29, 12);
            this.label架次.TabIndex = 10;
            this.label架次.Text = "架次";
            // 
            // textBox站位
            // 
            this.textBox站位.Location = new System.Drawing.Point(416, 15);
            this.textBox站位.Name = "textBox站位";
            this.textBox站位.Size = new System.Drawing.Size(100, 21);
            this.textBox站位.TabIndex = 12;
            // 
            // label站位
            // 
            this.label站位.AutoSize = true;
            this.label站位.Location = new System.Drawing.Point(375, 19);
            this.label站位.Name = "label站位";
            this.label站位.Size = new System.Drawing.Size(29, 12);
            this.label站位.TabIndex = 11;
            this.label站位.Text = "站位";
            // 
            // dateTimePicker开始
            // 
            this.dateTimePicker开始.Location = new System.Drawing.Point(605, 15);
            this.dateTimePicker开始.Name = "dateTimePicker开始";
            this.dateTimePicker开始.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker开始.TabIndex = 13;
            // 
            // label需求时间
            // 
            this.label需求时间.AutoSize = true;
            this.label需求时间.Location = new System.Drawing.Point(546, 19);
            this.label需求时间.Name = "label需求时间";
            this.label需求时间.Size = new System.Drawing.Size(53, 12);
            this.label需求时间.TabIndex = 14;
            this.label需求时间.Text = "需求时间";
            // 
            // dateTimePicker结束
            // 
            this.dateTimePicker结束.Location = new System.Drawing.Point(767, 15);
            this.dateTimePicker结束.Name = "dateTimePicker结束";
            this.dateTimePicker结束.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker结束.TabIndex = 15;
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
            // Form出库计划设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form出库计划设置";
            this.Text = "作业管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业明细)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown架次)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label构型;
        private System.Windows.Forms.TextBox textBox构型;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label装配指令信息;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button设置完成;
        private System.Windows.Forms.Button button到达拣货口;
        private System.Windows.Forms.Label label作业主表数量;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button申请货位;
        private System.Windows.Forms.Button button设置恢复;
        private System.Windows.Forms.Button button取消计划;
        private System.Windows.Forms.Button button查询计划;
        private System.Windows.Forms.Button button删除作业;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label已经启动的装配指令信息;
        private System.Windows.Forms.DataGridView dataGridView作业明细;
        private System.Windows.Forms.Button button查询;
        private System.Windows.Forms.TextBox textBox站位;
        private System.Windows.Forms.Label label站位;
        private System.Windows.Forms.Label label架次;
        private System.Windows.Forms.NumericUpDown numericUpDown架次;
        private System.Windows.Forms.DateTimePicker dateTimePicker结束;
        private System.Windows.Forms.Label label需求时间;
        private System.Windows.Forms.DateTimePicker dateTimePicker开始;
        private System.Windows.Forms.Button button启动计划;
    }
}