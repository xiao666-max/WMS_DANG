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
    public partial class Form出库计划 : Form
    {
        public Form出库计划()
        {
            InitializeComponent();


            #region 初始化主表格控件
            DataGridViewColumn newColumn计划编号 = new DataGridViewTextBoxColumn();
            newColumn计划编号.HeaderText = "计划编号";
            newColumn计划编号.Name = "c计划编号";
            newColumn计划编号.Width = 200;
            newColumn计划编号.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn计划编号);

            DataGridViewColumn newColumn计划类型 = new DataGridViewTextBoxColumn();
            newColumn计划类型.HeaderText = "计划类型";
            newColumn计划类型.Name = "c计划类型";
            newColumn计划类型.Width = 200;
            newColumn计划类型.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn计划类型);

            DataGridViewColumn newColumn处理状态 = new DataGridViewTextBoxColumn();
            newColumn处理状态.HeaderText = "处理状态";
            newColumn处理状态.Name = "c处理状态";
            newColumn处理状态.Width = 180;
            newColumn处理状态.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn处理状态);

            DataGridViewColumn newColumn入库口 = new DataGridViewTextBoxColumn();
            newColumn入库口.HeaderText = "入库口";
            newColumn入库口.Name = "c入库口";
            newColumn入库口.Width = 180;
            newColumn入库口.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn入库口);

            DataGridViewColumn newColumn创建时间 = new DataGridViewTextBoxColumn();
            newColumn创建时间.HeaderText = "创建时间";
            newColumn创建时间.Name = "c创建时间";
            newColumn创建时间.ValueType = typeof(DateTime);
            newColumn创建时间.Width = 300;
            dataGridView计划主表.Columns.Add(newColumn创建时间);

            DataGridViewColumn newColumnIP地址 = new DataGridViewTextBoxColumn();
            newColumnIP地址.HeaderText = "IP地址";
            newColumnIP地址.Name = "cIP地址";
            newColumnIP地址.ValueType = typeof(string);
            newColumnIP地址.Width = 200;
            dataGridView计划主表.Columns.Add(newColumnIP地址);

            DataGridViewColumn newColumn出库优先级 = new DataGridViewTextBoxColumn();
            newColumn出库优先级.HeaderText = "出库优先级";
            newColumn出库优先级.Name = "c出库优先级";
            newColumn出库优先级.ValueType = typeof(string);
            newColumn出库优先级.Width = 100;
            dataGridView计划主表.Columns.Add(newColumn出库优先级);

            DataGridViewColumn newColumn计划标识 = new DataGridViewTextBoxColumn();
            newColumn计划标识.HeaderText = "计划标识";
            newColumn计划标识.Name = "c计划标识";
            newColumn计划标识.ValueType = typeof(string);
            newColumn计划标识.Width = 200;
            dataGridView计划主表.Columns.Add(newColumn计划标识);

            DataGridViewColumn newColumn备注 = new DataGridViewTextBoxColumn();
            newColumn备注.HeaderText = "备注";
            newColumn备注.Name = "c备注";
            newColumn备注.ValueType = typeof(string);
            newColumn备注.Width = 400;
            dataGridView计划主表.Columns.Add(newColumn备注);

            #endregion


            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx处理状态 = new DataGridViewTextBoxColumn();
            newColumnmx处理状态.HeaderText = "处理状态";
            newColumnmx处理状态.Name = "c处理状态";
            newColumnmx处理状态.Width = 200;
            newColumnmx处理状态.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx处理状态);

            DataGridViewColumn newColumnmx图号 = new DataGridViewTextBoxColumn();
            newColumnmx图号.HeaderText = "图号";
            newColumnmx图号.Name = "c图号";
            newColumnmx图号.Width = 300;
            newColumnmx图号.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx图号);

            DataGridViewColumn newColumnmx图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx图号名称.HeaderText = "图号名称";
            newColumnmx图号名称.Name = "c图号名称";
            newColumnmx图号名称.Width = 300;
            newColumnmx图号名称.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx图号名称);


            DataGridViewColumn newColumnmx批次 = new DataGridViewTextBoxColumn();
            newColumnmx批次.HeaderText = "批次";
            newColumnmx批次.Name = "c批次";
            newColumnmx批次.Width = 150;
            newColumnmx批次.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx批次);

            DataGridViewColumn newColumnmx条码 = new DataGridViewTextBoxColumn();
            newColumnmx条码.HeaderText = "条码";
            newColumnmx条码.Name = "c条码";
            newColumnmx条码.Width = 180;
            newColumnmx条码.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx条码);


            DataGridViewColumn newColumnmx实际条码 = new DataGridViewTextBoxColumn();
            newColumnmx实际条码.HeaderText = "实际条码";
            newColumnmx实际条码.Name = "c实际条码";
            newColumnmx实际条码.Width = 180;
            newColumnmx实际条码.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumnmx实际条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(DateTime);
            newColumnmx物料属性.Width = 150;
            dataGridView计划明细.Columns.Add(newColumnmx物料属性);

            DataGridViewColumn newColumnmx计划数量 = new DataGridViewTextBoxColumn();
            newColumnmx计划数量.HeaderText = "计划数量";
            newColumnmx计划数量.Name = "c计划数量";
            newColumnmx计划数量.ValueType = typeof(int);
            newColumnmx计划数量.Width = 100;
            dataGridView计划明细.Columns.Add(newColumnmx计划数量);

            DataGridViewColumn newColumnmx数量 = new DataGridViewTextBoxColumn();
            newColumnmx数量.HeaderText = "数量";
            newColumnmx数量.Name = "c数量";
            newColumnmx数量.ValueType = typeof(int);
            newColumnmx数量.Width = 100;
            dataGridView计划明细.Columns.Add(newColumnmx数量);

            DataGridViewColumn newColumnmx装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx装配条码.HeaderText = "装配条码";
            newColumnmx装配条码.Name = "c装配条码";
            newColumnmx装配条码.ValueType = typeof(int);
            newColumnmx装配条码.Width = 150;
            dataGridView计划明细.Columns.Add(newColumnmx装配条码);

            DataGridViewColumn newColumnmx牌号 = new DataGridViewTextBoxColumn();
            newColumnmx牌号.HeaderText = "牌号";
            newColumnmx牌号.Name = "c牌号";
            newColumnmx牌号.ValueType = typeof(int);
            newColumnmx牌号.Width = 150;
            dataGridView计划明细.Columns.Add(newColumnmx牌号);

            DataGridViewColumn newColumnmx主成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx主成品牌号.HeaderText = "主成品牌号";
            newColumnmx主成品牌号.Name = "c主成品牌号";
            newColumnmx主成品牌号.ValueType = typeof(int);
            newColumnmx主成品牌号.Width = 150;
            dataGridView计划明细.Columns.Add(newColumnmx主成品牌号);

            DataGridViewColumn newColumnmx关重件类型 = new DataGridViewTextBoxColumn();
            newColumnmx关重件类型.HeaderText = "关重件类型";
            newColumnmx关重件类型.Name = "c关重件类型";
            newColumnmx关重件类型.ValueType = typeof(int);
            newColumnmx关重件类型.Width = 150;
            dataGridView计划明细.Columns.Add(newColumnmx关重件类型);

            DataGridViewColumn newColumnmx备注 = new DataGridViewTextBoxColumn();
            newColumnmx备注.HeaderText = "备注";
            newColumnmx备注.Name = "c备注";
            newColumnmx备注.ValueType = typeof(string);
            newColumnmx备注.Width = 200;
            dataGridView计划明细.Columns.Add(newColumnmx备注);

            #endregion
        }
    }
}
