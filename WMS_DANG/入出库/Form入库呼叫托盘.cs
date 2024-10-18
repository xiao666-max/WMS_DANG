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
    public partial class Form入库呼叫托盘 : Form
    {
        public Form入库呼叫托盘()
        {
            InitializeComponent();

            #region 初始化主表格控件
            DataGridViewColumn newColumnmx图号 = new DataGridViewTextBoxColumn();
            newColumnmx图号.HeaderText = "图号";
            newColumnmx图号.Name = "c图号";
            newColumnmx图号.Width = 300;
            newColumnmx图号.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx图号);

            DataGridViewColumn newColumnmx图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx图号名称.HeaderText = "图号名称";
            newColumnmx图号名称.Name = "c图号名称";
            newColumnmx图号名称.Width = 300;
            newColumnmx图号名称.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx图号名称);


            DataGridViewColumn newColumnmx批次 = new DataGridViewTextBoxColumn();
            newColumnmx批次.HeaderText = "批次";
            newColumnmx批次.Name = "c批次";
            newColumnmx批次.Width = 150;
            newColumnmx批次.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx批次);

            DataGridViewColumn newColumnmx条码 = new DataGridViewTextBoxColumn();
            newColumnmx条码.HeaderText = "条码";
            newColumnmx条码.Name = "c条码";
            newColumnmx条码.Width = 180;
            newColumnmx条码.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(DateTime);
            newColumnmx物料属性.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx物料属性);

            DataGridViewColumn newColumnmx数量 = new DataGridViewTextBoxColumn();
            newColumnmx数量.HeaderText = "数量";
            newColumnmx数量.Name = "c数量";
            newColumnmx数量.ValueType = typeof(int);
            newColumnmx数量.Width = 100;
            dataGridView作业主表.Columns.Add(newColumnmx数量);

            DataGridViewColumn newColumnmx装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx装配条码.HeaderText = "装配条码";
            newColumnmx装配条码.Name = "c装配条码";
            newColumnmx装配条码.ValueType = typeof(int);
            newColumnmx装配条码.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx装配条码);

            DataGridViewColumn newColumnmx牌号 = new DataGridViewTextBoxColumn();
            newColumnmx牌号.HeaderText = "牌号";
            newColumnmx牌号.Name = "c牌号";
            newColumnmx牌号.ValueType = typeof(int);
            newColumnmx牌号.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx牌号);

            DataGridViewColumn newColumnmx主成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx主成品牌号.HeaderText = "主成品牌号";
            newColumnmx主成品牌号.Name = "c主成品牌号";
            newColumnmx主成品牌号.ValueType = typeof(int);
            newColumnmx主成品牌号.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx主成品牌号);

            DataGridViewColumn newColumnmx关重件类型 = new DataGridViewTextBoxColumn();
            newColumnmx关重件类型.HeaderText = "关重件类型";
            newColumnmx关重件类型.Name = "c关重件类型";
            newColumnmx关重件类型.ValueType = typeof(int);
            newColumnmx关重件类型.Width = 150;
            dataGridView作业主表.Columns.Add(newColumnmx关重件类型);

            DataGridViewColumn newColumnmx备注 = new DataGridViewTextBoxColumn();
            newColumnmx备注.HeaderText = "备注";
            newColumnmx备注.Name = "c备注";
            newColumnmx备注.ValueType = typeof(string);
            newColumnmx备注.Width = 200;
            dataGridView作业主表.Columns.Add(newColumnmx备注);


            #endregion

        }

        private void dataGridView作业主表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
