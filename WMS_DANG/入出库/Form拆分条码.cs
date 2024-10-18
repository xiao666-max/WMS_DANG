using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_DANG.入出库
{
    public partial class Form拆分条码 : Form
    {
        public Form拆分条码()
        {
            InitializeComponent();

            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx选择 = new DataGridViewTextBoxColumn();
            newColumnmx选择.HeaderText = "选择";
            newColumnmx选择.Name = "c选择";
            newColumnmx选择.Width = 100;
            newColumnmx选择.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx选择);

            DataGridViewColumn newColumnmx托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 150;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx托盘号);

            DataGridViewColumn newColumnmx1图号 = new DataGridViewTextBoxColumn();
            newColumnmx1图号.HeaderText = "图号";
            newColumnmx1图号.Name = "c图号";
            newColumnmx1图号.Width = 300;
            newColumnmx1图号.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx1图号);

            DataGridViewColumn newColumnmx1图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx1图号名称.HeaderText = "图号名称";
            newColumnmx1图号名称.Name = "c图号名称";
            newColumnmx1图号名称.Width = 300;
            newColumnmx1图号名称.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx1图号名称);

            DataGridViewColumn newColumnmx1批次 = new DataGridViewTextBoxColumn();
            newColumnmx1批次.HeaderText = "批次";
            newColumnmx1批次.Name = "c批次";
            newColumnmx1批次.Width = 150;
            newColumnmx1批次.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx1批次);

            DataGridViewColumn newColumnmx1条码 = new DataGridViewTextBoxColumn();
            newColumnmx1条码.HeaderText = "条码";
            newColumnmx1条码.Name = "c条码";
            newColumnmx1条码.Width = 180;
            newColumnmx1条码.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx1条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(DateTime);
            newColumnmx物料属性.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx物料属性);


            DataGridViewColumn newColumnmx1数量 = new DataGridViewTextBoxColumn();
            newColumnmx1数量.HeaderText = "数量";
            newColumnmx1数量.Name = "c数量";
            newColumnmx1数量.ValueType = typeof(int);
            newColumnmx1数量.Width = 100;
            dataGridView作业主表.Columns.Add(newColumnmx1数量);

            DataGridViewColumn newColumnmx1装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx1装配条码.HeaderText = "条码";
            newColumnmx1装配条码.Name = "c条码";
            newColumnmx1装配条码.Width = 180;
            newColumnmx1装配条码.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx1装配条码);

            DataGridViewColumn newColumnmx成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx成品牌号.HeaderText = "成品牌号";
            newColumnmx成品牌号.Name = "c成品牌号";
            newColumnmx成品牌号.ValueType = typeof(int);
            newColumnmx成品牌号.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx成品牌号);

            DataGridViewColumn newColumnmx军种 = new DataGridViewTextBoxColumn();
            newColumnmx军种.HeaderText = "军种";
            newColumnmx军种.Name = "c军种";
            newColumnmx军种.ValueType = typeof(int);
            newColumnmx军种.Width = 100;
            dataGridView作业主表.Columns.Add(newColumnmx军种);

            DataGridViewColumn newColumnmx成品小号 = new DataGridViewTextBoxColumn();
            newColumnmx成品小号.HeaderText = "成品小号";
            newColumnmx成品小号.Name = "c成品小号";
            newColumnmx成品小号.ValueType = typeof(int);
            newColumnmx成品小号.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx成品小号);

            #endregion

            #region 初始化明细表格控件

            DataGridViewColumn newColumnmx2托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 150;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx2托盘号);

            DataGridViewColumn newColumnmx2图号 = new DataGridViewTextBoxColumn();
            newColumnmx2图号.HeaderText = "图号";
            newColumnmx2图号.Name = "c图号";
            newColumnmx2图号.Width = 300;
            newColumnmx2图号.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx2图号);

            DataGridViewColumn newColumnmx2图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx2图号名称.HeaderText = "图号名称";
            newColumnmx2图号名称.Name = "c图号名称";
            newColumnmx2图号名称.Width = 300;
            newColumnmx2图号名称.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx2图号名称);

            DataGridViewColumn newColumnmx2批次 = new DataGridViewTextBoxColumn();
            newColumnmx2批次.HeaderText = "批次";
            newColumnmx2批次.Name = "c批次";
            newColumnmx2批次.Width = 150;
            newColumnmx2批次.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx2批次);

            DataGridViewColumn newColumnmx2条码 = new DataGridViewTextBoxColumn();
            newColumnmx2条码.HeaderText = "条码";
            newColumnmx2条码.Name = "c条码";
            newColumnmx2条码.Width = 180;
            newColumnmx2条码.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx2条码);

            DataGridViewColumn newColumnmx2物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx2物料属性.HeaderText = "物料属性";
            newColumnmx2物料属性.Name = "c物料属性";
            newColumnmx2物料属性.ValueType = typeof(DateTime);
            newColumnmx2物料属性.Width = 150;
            dataGridView作业明细.Columns.Add(newColumnmx2物料属性);


            DataGridViewColumn newColumnmx2数量 = new DataGridViewTextBoxColumn();
            newColumnmx2数量.HeaderText = "数量";
            newColumnmx2数量.Name = "c数量";
            newColumnmx2数量.ValueType = typeof(int);
            newColumnmx2数量.Width = 100;
            dataGridView作业明细.Columns.Add(newColumnmx2数量);

            DataGridViewColumn newColumnmx2装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx2装配条码.HeaderText = "条码";
            newColumnmx2装配条码.Name = "c条码";
            newColumnmx2装配条码.Width = 180;
            newColumnmx2装配条码.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx2装配条码);

            DataGridViewColumn newColumnmx2成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx2成品牌号.HeaderText = "成品牌号";
            newColumnmx2成品牌号.Name = "c成品牌号";
            newColumnmx2成品牌号.ValueType = typeof(int);
            newColumnmx2成品牌号.Width = 150;
            dataGridView作业明细.Columns.Add(newColumnmx2成品牌号);

            DataGridViewColumn newColumnmx2军种 = new DataGridViewTextBoxColumn();
            newColumnmx2军种.HeaderText = "军种";
            newColumnmx2军种.Name = "c军种";
            newColumnmx2军种.ValueType = typeof(int);
            newColumnmx2军种.Width = 100;
            dataGridView作业明细.Columns.Add(newColumnmx2军种);

            DataGridViewColumn newColumnmx2成品小号 = new DataGridViewTextBoxColumn();
            newColumnmx2成品小号.HeaderText = "成品小号";
            newColumnmx2成品小号.Name = "c成品小号";
            newColumnmx2成品小号.ValueType = typeof(int);
            newColumnmx2成品小号.Width = 150;
            dataGridView作业明细.Columns.Add(newColumnmx2成品小号);

            #endregion

        }
    }
}
