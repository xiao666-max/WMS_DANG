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
    public partial class Form作业管理 : Form
    {
        public Form作业管理()
        {
            InitializeComponent();

            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx作业类型 = new DataGridViewTextBoxColumn();
            newColumnmx作业类型.HeaderText = "作业类型";
            newColumnmx作业类型.Name = "c作业类型";
            newColumnmx作业类型.Width = 120;
            newColumnmx作业类型.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx作业类型);

            DataGridViewColumn newColumnmx托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 150;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx托盘号);

            DataGridViewColumn newColumnmx任务号 = new DataGridViewTextBoxColumn();
            newColumnmx任务号.HeaderText = "任务号";
            newColumnmx任务号.Name = "c任务号";
            newColumnmx任务号.Width = 150;
            newColumnmx任务号.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx任务号);

            DataGridViewColumn newColumnmx起始货位 = new DataGridViewTextBoxColumn();
            newColumnmx起始货位.HeaderText = "起始货位";
            newColumnmx起始货位.Name = "c起始货位";
            newColumnmx起始货位.Width = 200;
            newColumnmx起始货位.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx起始货位);

            DataGridViewColumn newColumnmx目的货位 = new DataGridViewTextBoxColumn();
            newColumnmx目的货位.HeaderText = "目的货位";
            newColumnmx目的货位.Name = "c目的货位";
            newColumnmx目的货位.Width = 200;
            newColumnmx目的货位.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx目的货位);

            DataGridViewColumn newColumnmx故障类型 = new DataGridViewTextBoxColumn();
            newColumnmx故障类型.HeaderText = "故障类型";
            newColumnmx故障类型.Name = "c故障类型";
            newColumnmx故障类型.Width = 120;
            newColumnmx故障类型.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx故障类型);

            DataGridViewColumn newColumnmx优先级 = new DataGridViewTextBoxColumn();
            newColumnmx优先级.HeaderText = "优先级";
            newColumnmx优先级.Name = "c优先级";
            newColumnmx优先级.Width = 120;
            newColumnmx优先级.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx优先级);

            DataGridViewColumn newColumnmx作业状态 = new DataGridViewTextBoxColumn();
            newColumnmx作业状态.HeaderText = "作业状态";
            newColumnmx作业状态.Name = "c作业状态";
            newColumnmx作业状态.Width = 120;
            newColumnmx作业状态.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx作业状态);

            DataGridViewColumn newColumnmx设备 = new DataGridViewTextBoxColumn();
            newColumnmx设备.HeaderText = "设备";
            newColumnmx设备.Name = "c设备";
            newColumnmx设备.Width = 120;
            newColumnmx设备.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx设备);

            DataGridViewColumn newColumnmx目的站台 = new DataGridViewTextBoxColumn();
            newColumnmx目的站台.HeaderText = "目的站台";
            newColumnmx目的站台.Name = "c目的站台";
            newColumnmx目的站台.Width = 120;
            newColumnmx目的站台.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx目的站台);

            DataGridViewColumn newColumnmx创建时间 = new DataGridViewTextBoxColumn();
            newColumnmx创建时间.HeaderText = "创建时间";
            newColumnmx创建时间.Name = "c创建时间";
            newColumnmx创建时间.Width = 120;
            newColumnmx创建时间.ValueType = typeof(string);
            dataGridView作业主表.Columns.Add(newColumnmx创建时间);

            #endregion

            #region 初始化作业明细表格控件
            DataGridViewColumn newColumnmx1图号 = new DataGridViewTextBoxColumn();
            newColumnmx1图号.HeaderText = "图号";
            newColumnmx1图号.Name = "c图号";
            newColumnmx1图号.Width = 120;
            newColumnmx1图号.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1图号);

            DataGridViewColumn newColumnmx1图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx1图号名称.HeaderText = "图号名称";
            newColumnmx1图号名称.Name = "c图号名称";
            newColumnmx1图号名称.Width = 120;
            newColumnmx1图号名称.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1图号名称);

            DataGridViewColumn newColumnmx1批次 = new DataGridViewTextBoxColumn();
            newColumnmx1批次.HeaderText = "批次";
            newColumnmx1批次.Name = "c批次";
            newColumnmx1批次.Width = 120;
            newColumnmx1批次.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1批次);

            DataGridViewColumn newColumnmx1条码 = new DataGridViewTextBoxColumn();
            newColumnmx1条码.HeaderText = "条码";
            newColumnmx1条码.Name = "c条码";
            newColumnmx1条码.Width = 120;
            newColumnmx1条码.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1条码);

            DataGridViewColumn newColumnmx1物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx1物料属性.HeaderText = "物料属性";
            newColumnmx1物料属性.Name = "c物料属性";
            newColumnmx1物料属性.Width = 120;
            newColumnmx1物料属性.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1物料属性);

            DataGridViewColumn newColumnmx1数量 = new DataGridViewTextBoxColumn();
            newColumnmx1数量.HeaderText = "数量";
            newColumnmx1数量.Name = "c数量";
            newColumnmx1数量.Width = 120;
            newColumnmx1数量.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1数量);

            DataGridViewColumn newColumnmx1单位 = new DataGridViewTextBoxColumn();
            newColumnmx1单位.HeaderText = "单位";
            newColumnmx1单位.Name = "c单位";
            newColumnmx1单位.Width = 120;
            newColumnmx1单位.ValueType = typeof(string);
            dataGridView作业明细.Columns.Add(newColumnmx1单位);

            #endregion
        }
    }
}
