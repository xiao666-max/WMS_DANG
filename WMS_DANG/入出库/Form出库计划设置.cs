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
    public partial class Form出库计划设置 : Form
    {
        public Form出库计划设置()
        {
            InitializeComponent();

            #region 初始化主表格控件
            DataGridViewColumn newColumn选择 = new DataGridViewTextBoxColumn();
            newColumn选择.HeaderText = "选择";
            newColumn选择.Name = "c选择";
            newColumn选择.Width = 100;
            newColumn选择.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn选择);

            DataGridViewColumn newColumn装配条码 = new DataGridViewTextBoxColumn();
            newColumn装配条码.HeaderText = "装配条码";
            newColumn装配条码.Name = "c装配条码";
            newColumn装配条码.Width = 200;
            newColumn装配条码.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn装配条码);

            DataGridViewColumn newColumn指令编号 = new DataGridViewTextBoxColumn();
            newColumn指令编号.HeaderText = "指令编号";
            newColumn指令编号.Name = "c指令编号";
            newColumn指令编号.Width = 180;
            newColumn指令编号.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn指令编号);

            DataGridViewColumn newColumn指令名称 = new DataGridViewTextBoxColumn();
            newColumn指令名称.HeaderText = "指令名称";
            newColumn指令名称.Name = "c指令名称";
            newColumn指令名称.Width = 180;
            newColumn指令名称.ValueType = typeof(string);
            dataGridView计划主表.Columns.Add(newColumn指令名称);

            DataGridViewColumn newColumn构型 = new DataGridViewTextBoxColumn();
            newColumn构型.HeaderText = "构型";
            newColumn构型.Name = "c构型";
            newColumn构型.ValueType = typeof(DateTime);
            newColumn构型.Width = 100;
            dataGridView计划主表.Columns.Add(newColumn构型);

            DataGridViewColumn newColumn架次 = new DataGridViewTextBoxColumn();
            newColumn架次.HeaderText = "架次";
            newColumn架次.Name = "c架次";
            newColumn架次.ValueType = typeof(string);
            newColumn架次.Width = 100;
            dataGridView计划主表.Columns.Add(newColumn架次);

            DataGridViewColumn newColumn站位编码 = new DataGridViewTextBoxColumn();
            newColumn站位编码.HeaderText = "站位编码";
            newColumn站位编码.Name = "c站位编码";
            newColumn站位编码.ValueType = typeof(string);
            newColumn站位编码.Width = 100;
            dataGridView计划主表.Columns.Add(newColumn站位编码);


            DataGridViewColumn newColumn需求时间 = new DataGridViewTextBoxColumn();
            newColumn需求时间.HeaderText = "需求时间";
            newColumn需求时间.Name = "c需求时间";
            newColumn需求时间.ValueType = typeof(string);
            newColumn需求时间.Width = 200;
            dataGridView计划主表.Columns.Add(newColumn需求时间);

            DataGridViewColumn newColumn任务数量 = new DataGridViewTextBoxColumn();
            newColumn任务数量.HeaderText = "任务数量";
            newColumn任务数量.Name = "c任务数量";
            newColumn任务数量.ValueType = typeof(string);
            newColumn任务数量.Width = 200;
            dataGridView计划主表.Columns.Add(newColumn任务数量);

            DataGridViewColumn newColumn任务项数 = new DataGridViewTextBoxColumn();
            newColumn任务项数.HeaderText = "任务项数";
            newColumn任务项数.Name = "c任务项数";
            newColumn任务项数.ValueType = typeof(string);
            newColumn任务项数.Width = 200;
            dataGridView计划主表.Columns.Add(newColumn任务项数);

            #endregion


            #region 初始化明细表格控件
            DataGridViewColumn newColumn1装配条码 = new DataGridViewTextBoxColumn();
            newColumn1装配条码.HeaderText = "装配条码";
            newColumn1装配条码.Name = "c装配条码";
            newColumn1装配条码.Width = 200;
            newColumn1装配条码.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumn1装配条码);

            DataGridViewColumn newColumn1指令编号 = new DataGridViewTextBoxColumn();
            newColumn1指令编号.HeaderText = "指令编号";
            newColumn1指令编号.Name = "c指令编号";
            newColumn1指令编号.Width = 180;
            newColumn1指令编号.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumn1指令编号);

            DataGridViewColumn newColumn1指令名称 = new DataGridViewTextBoxColumn();
            newColumn1指令名称.HeaderText = "指令名称";
            newColumn1指令名称.Name = "c指令名称";
            newColumn1指令名称.Width = 180;
            newColumn1指令名称.ValueType = typeof(string);
            dataGridView计划明细.Columns.Add(newColumn1指令名称);

            DataGridViewColumn newColumn1构型 = new DataGridViewTextBoxColumn();
            newColumn1构型.HeaderText = "构型";
            newColumn1构型.Name = "c构型";
            newColumn1构型.ValueType = typeof(DateTime);
            newColumn1构型.Width = 100;
            dataGridView计划明细.Columns.Add(newColumn1构型);

            DataGridViewColumn newColumn1架次 = new DataGridViewTextBoxColumn();
            newColumn1架次.HeaderText = "架次";
            newColumn1架次.Name = "c架次";
            newColumn1架次.ValueType = typeof(string);
            newColumn1架次.Width = 100;
            dataGridView计划明细.Columns.Add(newColumn1架次);

            DataGridViewColumn newColumn1站位编码 = new DataGridViewTextBoxColumn();
            newColumn1站位编码.HeaderText = "站位编码";
            newColumn1站位编码.Name = "c站位编码";
            newColumn1站位编码.ValueType = typeof(string);
            newColumn1站位编码.Width = 100;
            dataGridView计划明细.Columns.Add(newColumn1站位编码);


            DataGridViewColumn newColumn1需求时间 = new DataGridViewTextBoxColumn();
            newColumn1需求时间.HeaderText = "需求时间";
            newColumn1需求时间.Name = "c需求时间";
            newColumn1需求时间.ValueType = typeof(string);
            newColumn1需求时间.Width = 200;
            dataGridView计划明细.Columns.Add(newColumn1需求时间);

            DataGridViewColumn newColumn1任务数量 = new DataGridViewTextBoxColumn();
            newColumn1任务数量.HeaderText = "任务数量";
            newColumn1任务数量.Name = "c任务数量";
            newColumn1任务数量.ValueType = typeof(string);
            newColumn1任务数量.Width = 200;
            dataGridView计划明细.Columns.Add(newColumn1任务数量);

            DataGridViewColumn newColumn1任务项数 = new DataGridViewTextBoxColumn();
            newColumn1任务项数.HeaderText = "任务项数";
            newColumn1任务项数.Name = "c任务项数";
            newColumn1任务项数.ValueType = typeof(string);
            newColumn1任务项数.Width = 200;
            dataGridView计划明细.Columns.Add(newColumn1任务项数);


            #endregion

        }
    }
}
