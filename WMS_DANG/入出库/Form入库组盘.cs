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
    public partial class Form入库组盘 : Form
    {
        public Form入库组盘()
        {
            InitializeComponent();


            #region 初始化主表格控件
            DataGridViewColumn newColumnmx选择 = new DataGridViewTextBoxColumn();
            newColumnmx选择.HeaderText = "选择";
            newColumnmx选择.Name = "c选择";
            newColumnmx选择.Width = 200;
            newColumnmx选择.ValueType = typeof(string);
            dataGridView主表.Columns.Add(newColumnmx选择);

            DataGridViewColumn newColumnmx图号 = new DataGridViewTextBoxColumn();
            newColumnmx图号.HeaderText = "图号";
            newColumnmx图号.Name = "c图号";
            newColumnmx图号.Width = 300;
            newColumnmx图号.ValueType = typeof(string);
            dataGridView主表.Columns.Add(newColumnmx图号);

            DataGridViewColumn newColumnmx图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx图号名称.HeaderText = "图号名称";
            newColumnmx图号名称.Name = "c图号名称";
            newColumnmx图号名称.Width = 300;
            newColumnmx图号名称.ValueType = typeof(string);
            dataGridView主表.Columns.Add(newColumnmx图号名称);


            DataGridViewColumn newColumnmx批次 = new DataGridViewTextBoxColumn();
            newColumnmx批次.HeaderText = "批次";
            newColumnmx批次.Name = "c批次";
            newColumnmx批次.Width = 150;
            newColumnmx批次.ValueType = typeof(string);
            dataGridView主表.Columns.Add(newColumnmx批次);

            DataGridViewColumn newColumnmx条码 = new DataGridViewTextBoxColumn();
            newColumnmx条码.HeaderText = "条码";
            newColumnmx条码.Name = "c条码";
            newColumnmx条码.Width = 180;
            newColumnmx条码.ValueType = typeof(string);
            dataGridView主表.Columns.Add(newColumnmx条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(string);
            newColumnmx物料属性.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx物料属性);

            DataGridViewColumn newColumnmx目的站台 = new DataGridViewTextBoxColumn();
            newColumnmx目的站台.HeaderText = "目的站台";
            newColumnmx目的站台.Name = "c目的站台";
            newColumnmx目的站台.ValueType = typeof(string);
            newColumnmx目的站台.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx目的站台);

            DataGridViewColumn newColumnmx数量 = new DataGridViewTextBoxColumn();
            newColumnmx数量.HeaderText = "数量";
            newColumnmx数量.Name = "c数量";
            newColumnmx数量.ValueType = typeof(int);
            newColumnmx数量.Width = 100;
            dataGridView主表.Columns.Add(newColumnmx数量);

            DataGridViewColumn newColumnmx装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx装配条码.HeaderText = "装配条码";
            newColumnmx装配条码.Name = "c装配条码";
            newColumnmx装配条码.ValueType = typeof(int);
            newColumnmx装配条码.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx装配条码);

            DataGridViewColumn newColumnmx牌号 = new DataGridViewTextBoxColumn();
            newColumnmx牌号.HeaderText = "牌号";
            newColumnmx牌号.Name = "c牌号";
            newColumnmx牌号.ValueType = typeof(int);
            newColumnmx牌号.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx牌号);

            DataGridViewColumn newColumnmx主成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx主成品牌号.HeaderText = "主成品牌号";
            newColumnmx主成品牌号.Name = "c主成品牌号";
            newColumnmx主成品牌号.ValueType = typeof(int);
            newColumnmx主成品牌号.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx主成品牌号);

            DataGridViewColumn newColumnmx关重件类型 = new DataGridViewTextBoxColumn();
            newColumnmx关重件类型.HeaderText = "关重件类型";
            newColumnmx关重件类型.Name = "c关重件类型";
            newColumnmx关重件类型.ValueType = typeof(int);
            newColumnmx关重件类型.Width = 150;
            dataGridView主表.Columns.Add(newColumnmx关重件类型);

            DataGridViewColumn newColumnmx备注 = new DataGridViewTextBoxColumn();
            newColumnmx备注.HeaderText = "备注";
            newColumnmx备注.Name = "c备注";
            newColumnmx备注.ValueType = typeof(string);
            newColumnmx备注.Width = 200;
            dataGridView主表.Columns.Add(newColumnmx备注);

            #endregion

            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 200;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx托盘号);

            DataGridViewColumn newColumnmx托盘位 = new DataGridViewTextBoxColumn();
            newColumnmx托盘位.HeaderText = "托盘位";
            newColumnmx托盘位.Name = "c托盘位";
            newColumnmx托盘位.Width = 300;
            newColumnmx托盘位.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx托盘位);

            DataGridViewColumn newColumnmx1图号 = new DataGridViewTextBoxColumn();
            newColumnmx1图号.HeaderText = "图号";
            newColumnmx1图号.Name = "c图号";
            newColumnmx1图号.Width = 300;
            newColumnmx1图号.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1图号);

            DataGridViewColumn newColumnmx1图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx1图号名称.HeaderText = "图号名称";
            newColumnmx1图号名称.Name = "c图号名称";
            newColumnmx1图号名称.Width = 300;
            newColumnmx1图号名称.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1图号名称);


            DataGridViewColumn newColumnmx1批次 = new DataGridViewTextBoxColumn();
            newColumnmx1批次.HeaderText = "批次";
            newColumnmx1批次.Name = "c批次";
            newColumnmx1批次.Width = 150;
            newColumnmx1批次.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1批次);

            DataGridViewColumn newColumnmx1条码 = new DataGridViewTextBoxColumn();
            newColumnmx1条码.HeaderText = "条码";
            newColumnmx1条码.Name = "c条码";
            newColumnmx1条码.Width = 180;
            newColumnmx1条码.ValueType = typeof(string);
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1条码);

            DataGridViewColumn newColumnmx1物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx1物料属性.HeaderText = "物料属性";
            newColumnmx1物料属性.Name = "c物料属性";
            newColumnmx1物料属性.ValueType = typeof(string);
            newColumnmx1物料属性.Width = 150;
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1物料属性);

            DataGridViewColumn newColumnmx计划数量 = new DataGridViewTextBoxColumn();
            newColumnmx计划数量.HeaderText = "计划数量";
            newColumnmx计划数量.Name = "c计划数量";
            newColumnmx计划数量.ValueType = typeof(int);
            newColumnmx计划数量.Width = 150;
            dataGridView托盘绑定清单.Columns.Add(newColumnmx计划数量);

            DataGridViewColumn newColumnmx1备注 = new DataGridViewTextBoxColumn();
            newColumnmx1备注.HeaderText = "备注";
            newColumnmx1备注.Name = "c备注";
            newColumnmx1备注.ValueType = typeof(string);
            newColumnmx1备注.Width = 200;
            dataGridView托盘绑定清单.Columns.Add(newColumnmx1备注);

            #endregion
        }
    }
}
