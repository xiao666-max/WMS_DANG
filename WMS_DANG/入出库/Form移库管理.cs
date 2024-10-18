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
    public partial class Form移库管理 : Form
    {
        public Form移库管理()
        {
            InitializeComponent();

            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx区域 = new DataGridViewTextBoxColumn();
            newColumnmx区域.HeaderText = "区域";
            newColumnmx区域.Name = "c区域";
            newColumnmx区域.Width = 80;
            newColumnmx区域.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx区域);

            DataGridViewColumn newColumnmx货位 = new DataGridViewTextBoxColumn();
            newColumnmx货位.HeaderText = "货位";
            newColumnmx货位.Name = "c货位";
            newColumnmx货位.Width = 100;
            newColumnmx货位.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx货位);

            DataGridViewColumn newColumnmx托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 200;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx托盘号);

            DataGridViewColumn newColumnmx图号 = new DataGridViewTextBoxColumn();
            newColumnmx图号.HeaderText = "图号";
            newColumnmx图号.Name = "c图号";
            newColumnmx图号.Width = 300;
            newColumnmx图号.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx图号);

            DataGridViewColumn newColumnmx图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx图号名称.HeaderText = "图号名称";
            newColumnmx图号名称.Name = "c图号名称";
            newColumnmx图号名称.Width = 300;
            newColumnmx图号名称.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx图号名称);


            DataGridViewColumn newColumnmx批次 = new DataGridViewTextBoxColumn();
            newColumnmx批次.HeaderText = "批次";
            newColumnmx批次.Name = "c批次";
            newColumnmx批次.Width = 150;
            newColumnmx批次.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx批次);

            DataGridViewColumn newColumnmx条码 = new DataGridViewTextBoxColumn();
            newColumnmx条码.HeaderText = "条码";
            newColumnmx条码.Name = "c条码";
            newColumnmx条码.Width = 180;
            newColumnmx条码.ValueType = typeof(string);
            dataGridView库存明细.Columns.Add(newColumnmx条码);


            DataGridViewColumn newColumnmx装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx装配条码.HeaderText = "装配条码";
            newColumnmx装配条码.Name = "c装配条码";
            newColumnmx装配条码.ValueType = typeof(int);
            newColumnmx装配条码.Width = 150;
            dataGridView库存明细.Columns.Add(newColumnmx装配条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(DateTime);
            newColumnmx物料属性.Width = 150;
            dataGridView库存明细.Columns.Add(newColumnmx物料属性);

            DataGridViewColumn newColumnmx数量 = new DataGridViewTextBoxColumn();
            newColumnmx数量.HeaderText = "数量";
            newColumnmx数量.Name = "c数量";
            newColumnmx数量.ValueType = typeof(int);
            newColumnmx数量.Width = 100;
            dataGridView库存明细.Columns.Add(newColumnmx数量);


            DataGridViewColumn newColumnmx单位 = new DataGridViewTextBoxColumn();
            newColumnmx单位.HeaderText = "单位";
            newColumnmx单位.Name = "c单位";
            newColumnmx单位.ValueType = typeof(int);
            newColumnmx单位.Width = 150;
            dataGridView库存明细.Columns.Add(newColumnmx单位);

            DataGridViewColumn newColumnmx格子号 = new DataGridViewTextBoxColumn();
            newColumnmx格子号.HeaderText = "格子号";
            newColumnmx格子号.Name = "c格子号";
            newColumnmx格子号.ValueType = typeof(int);
            newColumnmx格子号.Width = 100;
            dataGridView库存明细.Columns.Add(newColumnmx格子号);

            DataGridViewColumn newColumnmx入库时间 = new DataGridViewTextBoxColumn();
            newColumnmx入库时间.HeaderText = "入库时间";
            newColumnmx入库时间.Name = "c入库时间";
            newColumnmx入库时间.ValueType = typeof(int);
            newColumnmx入库时间.Width = 100;
            dataGridView库存明细.Columns.Add(newColumnmx入库时间);

            //DataGridViewColumn newColumnmx关重件类型 = new DataGridViewTextBoxColumn();
            //newColumnmx关重件类型.HeaderText = "关重件类型";
            //newColumnmx关重件类型.Name = "c关重件类型";
            //newColumnmx关重件类型.ValueType = typeof(int);
            //newColumnmx关重件类型.Width = 150;
            //dataGridView库存明细.Columns.Add(newColumnmx关重件类型);

            //DataGridViewColumn newColumnmx成品小号 = new DataGridViewTextBoxColumn();
            //newColumnmx成品小号.HeaderText = "成品小号";
            //newColumnmx成品小号.Name = "c成品小号";
            //newColumnmx成品小号.ValueType = typeof(int);
            //newColumnmx成品小号.Width = 150;
            //dataGridView库存明细.Columns.Add(newColumnmx成品小号);

            DataGridViewColumn newColumnmx备注 = new DataGridViewTextBoxColumn();
            newColumnmx备注.HeaderText = "备注";
            newColumnmx备注.Name = "c备注";
            newColumnmx备注.ValueType = typeof(string);
            newColumnmx备注.Width = 200;
            dataGridView库存明细.Columns.Add(newColumnmx备注);

            #endregion

            #region
            DataGridViewColumn newColumnmx1区域 = new DataGridViewTextBoxColumn();
            newColumnmx1区域.HeaderText = "区域";
            newColumnmx1区域.Name = "c区域";
            newColumnmx1区域.Width = 80;
            newColumnmx1区域.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1区域);

            DataGridViewColumn newColumnmx1货位 = new DataGridViewTextBoxColumn();
            newColumnmx1货位.HeaderText = "货位";
            newColumnmx1货位.Name = "c货位";
            newColumnmx1货位.Width = 100;
            newColumnmx1货位.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1货位);

            DataGridViewColumn newColumnmx1巷道 = new DataGridViewTextBoxColumn();
            newColumnmx1巷道.HeaderText = "巷道";
            newColumnmx1巷道.Name = "c巷道";
            newColumnmx1巷道.Width = 100;
            newColumnmx1巷道.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1巷道);

            DataGridViewColumn newColumnmx1排 = new DataGridViewTextBoxColumn();
            newColumnmx1排.HeaderText = "排";
            newColumnmx1排.Name = "c排";
            newColumnmx1排.Width = 100;
            newColumnmx1排.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1排);

            DataGridViewColumn newColumnmx1层 = new DataGridViewTextBoxColumn();
            newColumnmx1层.HeaderText = "层";
            newColumnmx1层.Name = "c层";
            newColumnmx1层.Width = 100;
            newColumnmx1层.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1层);

            DataGridViewColumn newColumnmx1列 = new DataGridViewTextBoxColumn();
            newColumnmx1列.HeaderText = "列";
            newColumnmx1列.Name = "c列";
            newColumnmx1列.Width = 100;
            newColumnmx1列.ValueType = typeof(string);
            dataGridView货位.Columns.Add(newColumnmx1列);

            #endregion

        }
    }
}
