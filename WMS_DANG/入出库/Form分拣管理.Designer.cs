
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label条码信息 = new System.Windows.Forms.Label();
            this.dataGridView条码信息 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button退出 = new System.Windows.Forms.Button();
            this.button剩余托盘回库 = new System.Windows.Forms.Button();
            this.button设置恢复 = new System.Windows.Forms.Button();
            this.button设置暂停 = new System.Windows.Forms.Button();
            this.button设置普通 = new System.Windows.Forms.Button();
            this.button删除作业 = new System.Windows.Forms.Button();
            this.label作业主表数量 = new System.Windows.Forms.Label();
            this.button设置完成 = new System.Windows.Forms.Button();
            this.button到达拣货口 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button出库确认条码 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label装配指令信息 = new System.Windows.Forms.Label();
            this.dataGridView装配指令信息 = new System.Windows.Forms.DataGridView();
            this.radioButton托盘号 = new System.Windows.Forms.RadioButton();
            this.radioButton装配指令 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox装配条码 = new System.Windows.Forms.TextBox();
            this.textBox扫描条码 = new System.Windows.Forms.TextBox();
            this.label扫描条码 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView条码信息)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView装配指令信息)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label装配条码
            // 
            this.label装配条码.AutoSize = true;
            this.label装配条码.Location = new System.Drawing.Point(528, 10);
            this.label装配条码.Name = "label装配条码";
            this.label装配条码.Size = new System.Drawing.Size(53, 12);
            this.label装配条码.TabIndex = 0;
            this.label装配条码.Text = "装配条码";
            // 
            // label托盘号
            // 
            this.label托盘号.AutoSize = true;
            this.label托盘号.ForeColor = System.Drawing.Color.Maroon;
            this.label托盘号.Location = new System.Drawing.Point(287, 11);
            this.label托盘号.Name = "label托盘号";
            this.label托盘号.Size = new System.Drawing.Size(77, 12);
            this.label托盘号.TabIndex = 4;
            this.label托盘号.Text = "回车进行查询";
            // 
            // textBox托盘号装配指令
            // 
            this.textBox托盘号装配指令.Location = new System.Drawing.Point(150, 8);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.panel5.Controls.Add(this.dataGridView条码信息);
            this.panel5.Controls.Add(this.label作业主表数量);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(383, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(988, 735);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label条码信息);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(383, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(988, 23);
            this.panel6.TabIndex = 2;
            // 
            // label条码信息
            // 
            this.label条码信息.AutoSize = true;
            this.label条码信息.Location = new System.Drawing.Point(0, 4);
            this.label条码信息.Name = "label条码信息";
            this.label条码信息.Size = new System.Drawing.Size(53, 12);
            this.label条码信息.TabIndex = 1;
            this.label条码信息.Text = "条码信息";
            // 
            // dataGridView条码信息
            // 
            this.dataGridView条码信息.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView条码信息.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView条码信息.Location = new System.Drawing.Point(0, 0);
            this.dataGridView条码信息.Name = "dataGridView条码信息";
            this.dataGridView条码信息.RowTemplate.Height = 23;
            this.dataGridView条码信息.Size = new System.Drawing.Size(988, 720);
            this.dataGridView条码信息.TabIndex = 0;
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
            this.panel4.Size = new System.Drawing.Size(1374, 1);
            this.panel4.TabIndex = 7;
            // 
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(1232, 19);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // button剩余托盘回库
            // 
            this.button剩余托盘回库.Location = new System.Drawing.Point(1098, 19);
            this.button剩余托盘回库.Name = "button剩余托盘回库";
            this.button剩余托盘回库.Size = new System.Drawing.Size(110, 32);
            this.button剩余托盘回库.TabIndex = 7;
            this.button剩余托盘回库.Text = "剩余托盘回库";
            this.button剩余托盘回库.UseVisualStyleBackColor = true;
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
            // label作业主表数量
            // 
            this.label作业主表数量.AutoSize = true;
            this.label作业主表数量.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label作业主表数量.Location = new System.Drawing.Point(0, 723);
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
            this.panel1.Controls.Add(this.button退出);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button剩余托盘回库);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox扫描条码);
            this.panel1.Controls.Add(this.label扫描条码);
            this.panel1.Controls.Add(this.textBox装配条码);
            this.panel1.Controls.Add(this.radioButton装配指令);
            this.panel1.Controls.Add(this.radioButton托盘号);
            this.panel1.Controls.Add(this.button出库确认条码);
            this.panel1.Controls.Add(this.textBox托盘号装配指令);
            this.panel1.Controls.Add(this.label装配条码);
            this.panel1.Controls.Add(this.label托盘号);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 64);
            this.panel1.TabIndex = 7;
            // 
            // button出库确认条码
            // 
            this.button出库确认条码.Location = new System.Drawing.Point(964, 19);
            this.button出库确认条码.Name = "button出库确认条码";
            this.button出库确认条码.Size = new System.Drawing.Size(110, 32);
            this.button出库确认条码.TabIndex = 6;
            this.button出库确认条码.Text = "出库确认条码";
            this.button出库确认条码.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 770);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label装配指令信息);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 21);
            this.panel3.TabIndex = 2;
            // 
            // label装配指令信息
            // 
            this.label装配指令信息.AutoSize = true;
            this.label装配指令信息.Location = new System.Drawing.Point(0, 4);
            this.label装配指令信息.Name = "label装配指令信息";
            this.label装配指令信息.Size = new System.Drawing.Size(77, 12);
            this.label装配指令信息.TabIndex = 1;
            this.label装配指令信息.Text = "装配指令信息";
            // 
            // dataGridView装配指令信息
            // 
            this.dataGridView装配指令信息.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView装配指令信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView装配指令信息.Location = new System.Drawing.Point(3, 32);
            this.dataGridView装配指令信息.Name = "dataGridView装配指令信息";
            this.dataGridView装配指令信息.RowTemplate.Height = 23;
            this.dataGridView装配指令信息.Size = new System.Drawing.Size(374, 735);
            this.dataGridView装配指令信息.TabIndex = 0;
            // 
            // radioButton托盘号
            // 
            this.radioButton托盘号.AutoSize = true;
            this.radioButton托盘号.Location = new System.Drawing.Point(8, 10);
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
            this.radioButton装配指令.Location = new System.Drawing.Point(73, 10);
            this.radioButton装配指令.Name = "radioButton装配指令";
            this.radioButton装配指令.Size = new System.Drawing.Size(71, 16);
            this.radioButton装配指令.TabIndex = 8;
            this.radioButton装配指令.TabStop = true;
            this.radioButton装配指令.Text = "装配指令";
            this.radioButton装配指令.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.72926F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.27074F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView装配指令信息, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 741F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1374, 770);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // textBox装配条码
            // 
            this.textBox装配条码.Location = new System.Drawing.Point(588, 6);
            this.textBox装配条码.Name = "textBox装配条码";
            this.textBox装配条码.Size = new System.Drawing.Size(211, 21);
            this.textBox装配条码.TabIndex = 9;
            // 
            // textBox扫描条码
            // 
            this.textBox扫描条码.Location = new System.Drawing.Point(588, 35);
            this.textBox扫描条码.Name = "textBox扫描条码";
            this.textBox扫描条码.Size = new System.Drawing.Size(211, 21);
            this.textBox扫描条码.TabIndex = 11;
            // 
            // label扫描条码
            // 
            this.label扫描条码.AutoSize = true;
            this.label扫描条码.Location = new System.Drawing.Point(528, 39);
            this.label扫描条码.Name = "label扫描条码";
            this.label扫描条码.Size = new System.Drawing.Size(53, 12);
            this.label扫描条码.TabIndex = 10;
            this.label扫描条码.Text = "装配条码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(818, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "1、先扫描条码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(818, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "2、确认已经扫描的条码";
            // 
            // Form分拣管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form分拣管理";
            this.Text = "出库确认";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView条码信息)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView装配指令信息)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label装配条码;
        private System.Windows.Forms.Label label托盘号;
        private System.Windows.Forms.TextBox textBox托盘号装配指令;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label装配指令信息;
        private System.Windows.Forms.DataGridView dataGridView装配指令信息;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button设置完成;
        private System.Windows.Forms.Button button到达拣货口;
        private System.Windows.Forms.Label label作业主表数量;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button剩余托盘回库;
        private System.Windows.Forms.Button button设置恢复;
        private System.Windows.Forms.Button button设置暂停;
        private System.Windows.Forms.Button button设置普通;
        private System.Windows.Forms.Button button删除作业;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label条码信息;
        private System.Windows.Forms.DataGridView dataGridView条码信息;
        private System.Windows.Forms.Button button出库确认条码;
        private System.Windows.Forms.RadioButton radioButton装配指令;
        private System.Windows.Forms.RadioButton radioButton托盘号;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox扫描条码;
        private System.Windows.Forms.Label label扫描条码;
        private System.Windows.Forms.TextBox textBox装配条码;
    }
}