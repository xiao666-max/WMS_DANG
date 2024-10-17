
namespace WMS_DANG.入出库
{
    partial class Form入库组盘
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
            this.dataGridView作业主表 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button添加至托盘 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label说明1 = new System.Windows.Forms.Label();
            this.checkBox托盘格子是否满 = new System.Windows.Forms.CheckBox();
            this.checkBox起始时间 = new System.Windows.Forms.CheckBox();
            this.button退出 = new System.Windows.Forms.Button();
            this.label托盘格子是否满 = new System.Windows.Forms.Label();
            this.dateTimePicker起始时间 = new System.Windows.Forms.DateTimePicker();
            this.button盘点确认 = new System.Windows.Forms.Button();
            this.textBox物料 = new System.Windows.Forms.TextBox();
            this.label起始时间 = new System.Windows.Forms.Label();
            this.label托盘号 = new System.Windows.Forms.Label();
            this.ComboBox处理状态 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button移除添加 = new System.Windows.Forms.Button();
            this.button托盘回库 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label托盘位 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label作业主表数量 = new System.Windows.Forms.Label();
            this.dataGridView托盘绑定清单 = new System.Windows.Forms.DataGridView();
            this.label托盘图示 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label作业明细数量 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel选择条件 = new System.Windows.Forms.Panel();
            this.label计划主表信息 = new System.Windows.Forms.Label();
            this.radioButton批次 = new System.Windows.Forms.RadioButton();
            this.radioButton条码 = new System.Windows.Forms.RadioButton();
            this.radioButton图号 = new System.Windows.Forms.RadioButton();
            this.radioButton周转箱 = new System.Windows.Forms.RadioButton();
            this.textBox图号 = new System.Windows.Forms.TextBox();
            this.panel呼叫托盘 = new System.Windows.Forms.Panel();
            this.button呼叫托盘 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView托盘绑定清单)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel选择条件.SuspendLayout();
            this.panel呼叫托盘.SuspendLayout();
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
            // dataGridView作业主表
            // 
            this.dataGridView作业主表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView作业主表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView作业主表.Location = new System.Drawing.Point(0, 0);
            this.dataGridView作业主表.Name = "dataGridView作业主表";
            this.dataGridView作业主表.RowTemplate.Height = 23;
            this.dataGridView作业主表.Size = new System.Drawing.Size(1374, 294);
            this.dataGridView作业主表.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView作业主表);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 294);
            this.panel2.TabIndex = 7;
            // 
            // button添加至托盘
            // 
            this.button添加至托盘.Location = new System.Drawing.Point(648, 43);
            this.button添加至托盘.Name = "button添加至托盘";
            this.button添加至托盘.Size = new System.Drawing.Size(110, 32);
            this.button添加至托盘.TabIndex = 6;
            this.button添加至托盘.Text = "添加至托盘";
            this.button添加至托盘.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel呼叫托盘);
            this.panel1.Controls.Add(this.panel选择条件);
            this.panel1.Controls.Add(this.label说明1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 42);
            this.panel1.TabIndex = 7;
            // 
            // label说明1
            // 
            this.label说明1.AutoSize = true;
            this.label说明1.ForeColor = System.Drawing.Color.DarkRed;
            this.label说明1.Location = new System.Drawing.Point(7, 14);
            this.label说明1.Name = "label说明1";
            this.label说明1.Size = new System.Drawing.Size(197, 12);
            this.label说明1.TabIndex = 13;
            this.label说明1.Text = "添加条码至托盘前请先进行盘点操作";
            // 
            // checkBox托盘格子是否满
            // 
            this.checkBox托盘格子是否满.AutoSize = true;
            this.checkBox托盘格子是否满.Location = new System.Drawing.Point(424, 52);
            this.checkBox托盘格子是否满.Name = "checkBox托盘格子是否满";
            this.checkBox托盘格子是否满.Size = new System.Drawing.Size(15, 14);
            this.checkBox托盘格子是否满.TabIndex = 12;
            this.checkBox托盘格子是否满.UseVisualStyleBackColor = true;
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
            // button退出
            // 
            this.button退出.Location = new System.Drawing.Point(1257, 43);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(110, 32);
            this.button退出.TabIndex = 8;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = true;
            // 
            // label托盘格子是否满
            // 
            this.label托盘格子是否满.AutoSize = true;
            this.label托盘格子是否满.Location = new System.Drawing.Point(445, 53);
            this.label托盘格子是否满.Name = "label托盘格子是否满";
            this.label托盘格子是否满.Size = new System.Drawing.Size(197, 12);
            this.label托盘格子是否满.TabIndex = 9;
            this.label托盘格子是否满.Text = "托盘格子是否满【若托盘满请打勾】";
            // 
            // dateTimePicker起始时间
            // 
            this.dateTimePicker起始时间.Location = new System.Drawing.Point(936, 10);
            this.dateTimePicker起始时间.Name = "dateTimePicker起始时间";
            this.dateTimePicker起始时间.Size = new System.Drawing.Size(221, 21);
            this.dateTimePicker起始时间.TabIndex = 8;
            // 
            // button盘点确认
            // 
            this.button盘点确认.Location = new System.Drawing.Point(7, 43);
            this.button盘点确认.Name = "button盘点确认";
            this.button盘点确认.Size = new System.Drawing.Size(81, 32);
            this.button盘点确认.TabIndex = 7;
            this.button盘点确认.Text = "盘点确认";
            this.button盘点确认.UseVisualStyleBackColor = true;
            // 
            // textBox物料
            // 
            this.textBox物料.Location = new System.Drawing.Point(155, 49);
            this.textBox物料.Name = "textBox物料";
            this.textBox物料.Size = new System.Drawing.Size(97, 21);
            this.textBox物料.TabIndex = 5;
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
            // label托盘号
            // 
            this.label托盘号.AutoSize = true;
            this.label托盘号.Location = new System.Drawing.Point(109, 53);
            this.label托盘号.Name = "label托盘号";
            this.label托盘号.Size = new System.Drawing.Size(41, 12);
            this.label托盘号.TabIndex = 4;
            this.label托盘号.Text = "托盘号";
            // 
            // ComboBox处理状态
            // 
            this.ComboBox处理状态.FormattingEnabled = true;
            this.ComboBox处理状态.Location = new System.Drawing.Point(319, 49);
            this.ComboBox处理状态.Name = "ComboBox处理状态";
            this.ComboBox处理状态.Size = new System.Drawing.Size(99, 20);
            this.ComboBox处理状态.TabIndex = 3;
            this.ComboBox处理状态.Text = "==请选择==";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button移除添加);
            this.panel4.Controls.Add(this.button托盘回库);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label托盘位);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.checkBox起始时间);
            this.panel4.Controls.Add(this.checkBox托盘格子是否满);
            this.panel4.Controls.Add(this.dateTimePicker起始时间);
            this.panel4.Controls.Add(this.textBox物料);
            this.panel4.Controls.Add(this.label起始时间);
            this.panel4.Controls.Add(this.button盘点确认);
            this.panel4.Controls.Add(this.label托盘号);
            this.panel4.Controls.Add(this.button添加至托盘);
            this.panel4.Controls.Add(this.button退出);
            this.panel4.Controls.Add(this.label托盘格子是否满);
            this.panel4.Controls.Add(this.ComboBox处理状态);
            this.panel4.Location = new System.Drawing.Point(5, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 84);
            this.panel4.TabIndex = 7;
            // 
            // button移除添加
            // 
            this.button移除添加.Location = new System.Drawing.Point(993, 43);
            this.button移除添加.Name = "button移除添加";
            this.button移除添加.Size = new System.Drawing.Size(110, 32);
            this.button移除添加.TabIndex = 18;
            this.button移除添加.Text = "移除添加";
            this.button移除添加.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "【将选择的条码和托盘进行绑定】";
            // 
            // label托盘位
            // 
            this.label托盘位.AutoSize = true;
            this.label托盘位.Location = new System.Drawing.Point(272, 53);
            this.label托盘位.Name = "label托盘位";
            this.label托盘位.Size = new System.Drawing.Size(41, 12);
            this.label托盘位.TabIndex = 14;
            this.label托盘位.Text = "托盘位";
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
            // dataGridView托盘绑定清单
            // 
            this.dataGridView托盘绑定清单.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView托盘绑定清单.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView托盘绑定清单.Location = new System.Drawing.Point(0, 0);
            this.dataGridView托盘绑定清单.Name = "dataGridView托盘绑定清单";
            this.dataGridView托盘绑定清单.RowTemplate.Height = 23;
            this.dataGridView托盘绑定清单.Size = new System.Drawing.Size(995, 350);
            this.dataGridView托盘绑定清单.TabIndex = 0;
            // 
            // label托盘图示
            // 
            this.label托盘图示.AutoSize = true;
            this.label托盘图示.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label托盘图示.Location = new System.Drawing.Point(0, 0);
            this.label托盘图示.Name = "label托盘图示";
            this.label托盘图示.Size = new System.Drawing.Size(53, 12);
            this.label托盘图示.TabIndex = 1;
            this.label托盘图示.Text = "托盘图示";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label托盘图示);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 22);
            this.panel6.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
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
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 449);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 404);
            this.panel5.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(379, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(995, 404);
            this.panel8.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 35);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "共[QQQ]条数据";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView托盘绑定清单);
            this.panel9.Location = new System.Drawing.Point(3, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(995, 350);
            this.panel9.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "托盘绑定清单";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 404);
            this.panel7.TabIndex = 3;
            // 
            // panel选择条件
            // 
            this.panel选择条件.Controls.Add(this.textBox图号);
            this.panel选择条件.Controls.Add(this.radioButton图号);
            this.panel选择条件.Controls.Add(this.radioButton周转箱);
            this.panel选择条件.Controls.Add(this.radioButton条码);
            this.panel选择条件.Controls.Add(this.radioButton批次);
            this.panel选择条件.Location = new System.Drawing.Point(256, 3);
            this.panel选择条件.Name = "panel选择条件";
            this.panel选择条件.Size = new System.Drawing.Size(357, 36);
            this.panel选择条件.TabIndex = 14;
            // 
            // label计划主表信息
            // 
            this.label计划主表信息.AutoSize = true;
            this.label计划主表信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label计划主表信息.Location = new System.Drawing.Point(0, 0);
            this.label计划主表信息.Name = "label计划主表信息";
            this.label计划主表信息.Size = new System.Drawing.Size(0, 12);
            this.label计划主表信息.TabIndex = 1;
            // 
            // radioButton批次
            // 
            this.radioButton批次.AutoSize = true;
            this.radioButton批次.Location = new System.Drawing.Point(18, 11);
            this.radioButton批次.Name = "radioButton批次";
            this.radioButton批次.Size = new System.Drawing.Size(47, 16);
            this.radioButton批次.TabIndex = 0;
            this.radioButton批次.TabStop = true;
            this.radioButton批次.Text = "批次";
            this.radioButton批次.UseVisualStyleBackColor = true;
            // 
            // radioButton条码
            // 
            this.radioButton条码.AutoSize = true;
            this.radioButton条码.Location = new System.Drawing.Point(73, 11);
            this.radioButton条码.Name = "radioButton条码";
            this.radioButton条码.Size = new System.Drawing.Size(47, 16);
            this.radioButton条码.TabIndex = 1;
            this.radioButton条码.TabStop = true;
            this.radioButton条码.Text = "条码";
            this.radioButton条码.UseVisualStyleBackColor = true;
            // 
            // radioButton图号
            // 
            this.radioButton图号.AutoSize = true;
            this.radioButton图号.Location = new System.Drawing.Point(195, 11);
            this.radioButton图号.Name = "radioButton图号";
            this.radioButton图号.Size = new System.Drawing.Size(47, 16);
            this.radioButton图号.TabIndex = 3;
            this.radioButton图号.TabStop = true;
            this.radioButton图号.Text = "图号";
            this.radioButton图号.UseVisualStyleBackColor = true;
            // 
            // radioButton周转箱
            // 
            this.radioButton周转箱.AutoSize = true;
            this.radioButton周转箱.Location = new System.Drawing.Point(128, 11);
            this.radioButton周转箱.Name = "radioButton周转箱";
            this.radioButton周转箱.Size = new System.Drawing.Size(59, 16);
            this.radioButton周转箱.TabIndex = 2;
            this.radioButton周转箱.TabStop = true;
            this.radioButton周转箱.Text = "周转箱";
            this.radioButton周转箱.UseVisualStyleBackColor = true;
            // 
            // textBox图号
            // 
            this.textBox图号.Location = new System.Drawing.Point(248, 8);
            this.textBox图号.Name = "textBox图号";
            this.textBox图号.Size = new System.Drawing.Size(97, 21);
            this.textBox图号.TabIndex = 19;
            // 
            // panel呼叫托盘
            // 
            this.panel呼叫托盘.Controls.Add(this.label4);
            this.panel呼叫托盘.Controls.Add(this.button呼叫托盘);
            this.panel呼叫托盘.Location = new System.Drawing.Point(619, 3);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "【生成一个立体库的托盘任务】";
            // 
            // Form入库组盘
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form入库组盘";
            this.Text = "入库计划";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView作业主表)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView托盘绑定清单)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel选择条件.ResumeLayout(false);
            this.panel选择条件.PerformLayout();
            this.panel呼叫托盘.ResumeLayout(false);
            this.panel呼叫托盘.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView作业主表;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button添加至托盘;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox物料;
        private System.Windows.Forms.Label label起始时间;
        private System.Windows.Forms.Label label托盘号;
        private System.Windows.Forms.ComboBox ComboBox处理状态;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Label label作业主表数量;
        private System.Windows.Forms.DataGridView dataGridView托盘绑定清单;
        private System.Windows.Forms.Label label托盘图示;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label作业明细数量;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button盘点确认;
        private System.Windows.Forms.DateTimePicker dateTimePicker起始时间;
        private System.Windows.Forms.Label label托盘格子是否满;
        private System.Windows.Forms.CheckBox checkBox托盘格子是否满;
        private System.Windows.Forms.CheckBox checkBox起始时间;
        private System.Windows.Forms.Label label说明1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label托盘位;
        private System.Windows.Forms.Button button移除添加;
        private System.Windows.Forms.Button button托盘回库;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label计划主表信息;
        private System.Windows.Forms.Panel panel选择条件;
        private System.Windows.Forms.RadioButton radioButton图号;
        private System.Windows.Forms.RadioButton radioButton周转箱;
        private System.Windows.Forms.RadioButton radioButton条码;
        private System.Windows.Forms.RadioButton radioButton批次;
        private System.Windows.Forms.TextBox textBox图号;
        private System.Windows.Forms.Panel panel呼叫托盘;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button呼叫托盘;
    }
}