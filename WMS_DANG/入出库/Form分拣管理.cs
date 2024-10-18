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
    public partial class Form分拣管理 : Form
    {
        public Form分拣管理()
        {
            InitializeComponent();
            //dataGridView出库
            #region 初始化出库表格控件
            DataGridViewColumn newColumn装配条码 = new DataGridViewTextBoxColumn();
            newColumn装配条码.HeaderText = "装配条码";
            newColumn装配条码.Name = "c装配条码";
            newColumn装配条码.Width = 200;
            newColumn装配条码.ValueType = typeof(string);
            dataGridView出库.Columns.Add(newColumn装配条码);


            DataGridViewColumn newColumnmx图号 = new DataGridViewTextBoxColumn();
            newColumnmx图号.HeaderText = "图号";
            newColumnmx图号.Name = "c图号";
            newColumnmx图号.Width = 300;
            newColumnmx图号.ValueType = typeof(string);
            dataGridView出库.Columns.Add(newColumnmx图号);

            DataGridViewColumn newColumnmx图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx图号名称.HeaderText = "图号名称";
            newColumnmx图号名称.Name = "c图号名称";
            newColumnmx图号名称.Width = 300;
            newColumnmx图号名称.ValueType = typeof(string);
            dataGridView出库.Columns.Add(newColumnmx图号名称);

            DataGridViewColumn newColumnmx数量 = new DataGridViewTextBoxColumn();
            newColumnmx数量.HeaderText = "数量";
            newColumnmx数量.Name = "c数量";
            newColumnmx数量.ValueType = typeof(int);
            newColumnmx数量.Width = 100;
            dataGridView出库.Columns.Add(newColumnmx数量);

            DataGridViewColumn newColumnmx批次 = new DataGridViewTextBoxColumn();
            newColumnmx批次.HeaderText = "批次";
            newColumnmx批次.Name = "c批次";
            newColumnmx批次.Width = 150;
            newColumnmx批次.ValueType = typeof(string);
            dataGridView出库.Columns.Add(newColumnmx批次);

            #endregion


            #region 出库计划
            DataGridViewColumn newColumn批次 = new DataGridViewTextBoxColumn();
            newColumn批次.HeaderText = "批次";
            newColumn批次.Name = "c批次";
            newColumn批次.Width = 180;
            newColumn批次.ValueType = typeof(string);
            dataGridView出库计划.Columns.Add(newColumn批次);

            DataGridViewColumn newColumn1条码 = new DataGridViewTextBoxColumn();
            newColumn1条码.HeaderText = "条码";
            newColumn1条码.Name = "c条码";
            newColumn1条码.Width = 200;
            newColumn1条码.ValueType = typeof(string);
            dataGridView出库计划.Columns.Add(newColumn1条码);

            DataGridViewColumn newColumn库存数量 = new DataGridViewTextBoxColumn();
            newColumn库存数量.HeaderText = "库存数量";
            newColumn库存数量.Name = "c库存数量";
            newColumn库存数量.ValueType = typeof(int);
            newColumn库存数量.Width = 200;
            dataGridView出库计划.Columns.Add(newColumn库存数量);

            DataGridViewColumn newColumn1装配条码 = new DataGridViewTextBoxColumn();
            newColumn1装配条码.HeaderText = "装配条码";
            newColumn1装配条码.Name = "c装配条码";
            newColumn1装配条码.Width = 200;
            newColumn1装配条码.ValueType = typeof(string);
            dataGridView出库计划.Columns.Add(newColumn1装配条码);

            DataGridViewColumn newColumn构型 = new DataGridViewTextBoxColumn();
            newColumn构型.HeaderText = "构型";
            newColumn构型.Name = "c构型";
            newColumn构型.ValueType = typeof(DateTime);
            newColumn构型.Width = 100;
            dataGridView出库计划.Columns.Add(newColumn构型);

            DataGridViewColumn newColumn架次 = new DataGridViewTextBoxColumn();
            newColumn架次.HeaderText = "架次";
            newColumn架次.Name = "c架次";
            newColumn架次.ValueType = typeof(string);
            newColumn架次.Width = 100;
            dataGridView出库计划.Columns.Add(newColumn架次);

            DataGridViewColumn newColumn站位编码 = new DataGridViewTextBoxColumn();
            newColumn站位编码.HeaderText = "站位编码";
            newColumn站位编码.Name = "c站位编码";
            newColumn站位编码.ValueType = typeof(string);
            newColumn站位编码.Width = 100;
            dataGridView出库计划.Columns.Add(newColumn站位编码);


            DataGridViewColumn newColumn需求时间 = new DataGridViewTextBoxColumn();
            newColumn需求时间.HeaderText = "需求时间";
            newColumn需求时间.Name = "c需求时间";
            newColumn需求时间.ValueType = typeof(string);
            newColumn需求时间.Width = 200;
            dataGridView出库计划.Columns.Add(newColumn需求时间);

            DataGridViewColumn newColumn任务数量 = new DataGridViewTextBoxColumn();
            newColumn任务数量.HeaderText = "任务数量";
            newColumn任务数量.Name = "c任务数量";
            newColumn任务数量.ValueType = typeof(string);
            newColumn任务数量.Width = 200;
            dataGridView出库计划.Columns.Add(newColumn任务数量);

            DataGridViewColumn newColumn任务项数 = new DataGridViewTextBoxColumn();
            newColumn任务项数.HeaderText = "任务项数";
            newColumn任务项数.Name = "c任务项数";
            newColumn任务项数.ValueType = typeof(string);
            newColumn任务项数.Width = 200;
            dataGridView出库计划.Columns.Add(newColumn任务项数);

            #endregion



            #region 初始化明细表格控件
            DataGridViewColumn newColumnmx托盘号 = new DataGridViewTextBoxColumn();
            newColumnmx托盘号.HeaderText = "托盘号";
            newColumnmx托盘号.Name = "c托盘号";
            newColumnmx托盘号.Width = 150;
            newColumnmx托盘号.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx托盘号);

            DataGridViewColumn newColumnmx1图号 = new DataGridViewTextBoxColumn();
            newColumnmx1图号.HeaderText = "图号";
            newColumnmx1图号.Name = "c图号";
            newColumnmx1图号.Width = 300;
            newColumnmx1图号.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx1图号);

            DataGridViewColumn newColumnmx1图号名称 = new DataGridViewTextBoxColumn();
            newColumnmx1图号名称.HeaderText = "图号名称";
            newColumnmx1图号名称.Name = "c图号名称";
            newColumnmx1图号名称.Width = 300;
            newColumnmx1图号名称.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx1图号名称);


            DataGridViewColumn newColumnmx1批次 = new DataGridViewTextBoxColumn();
            newColumnmx1批次.HeaderText = "批次";
            newColumnmx1批次.Name = "c批次";
            newColumnmx1批次.Width = 150;
            newColumnmx1批次.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx1批次);

            DataGridViewColumn newColumnmx1条码 = new DataGridViewTextBoxColumn();
            newColumnmx1条码.HeaderText = "条码";
            newColumnmx1条码.Name = "c条码";
            newColumnmx1条码.Width = 180;
            newColumnmx1条码.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx1条码);


            DataGridViewColumn newColumnmx装配条码 = new DataGridViewTextBoxColumn();
            newColumnmx装配条码.HeaderText = "装配条码";
            newColumnmx装配条码.Name = "c装配条码";
            newColumnmx装配条码.Width = 180;
            newColumnmx装配条码.ValueType = typeof(string);
            dataGridView目标托盘信息.Columns.Add(newColumnmx装配条码);

            DataGridViewColumn newColumnmx物料属性 = new DataGridViewTextBoxColumn();
            newColumnmx物料属性.HeaderText = "物料属性";
            newColumnmx物料属性.Name = "c物料属性";
            newColumnmx物料属性.ValueType = typeof(DateTime);
            newColumnmx物料属性.Width = 150;
            dataGridView目标托盘信息.Columns.Add(newColumnmx物料属性);

            DataGridViewColumn newColumnmx计划数量 = new DataGridViewTextBoxColumn();
            newColumnmx计划数量.HeaderText = "计划数量";
            newColumnmx计划数量.Name = "c计划数量";
            newColumnmx计划数量.ValueType = typeof(int);
            newColumnmx计划数量.Width = 100;
            dataGridView目标托盘信息.Columns.Add(newColumnmx计划数量);

            DataGridViewColumn newColumnmx1数量 = new DataGridViewTextBoxColumn();
            newColumnmx1数量.HeaderText = "数量";
            newColumnmx1数量.Name = "c数量";
            newColumnmx1数量.ValueType = typeof(int);
            newColumnmx1数量.Width = 100;
            dataGridView目标托盘信息.Columns.Add(newColumnmx1数量);

            DataGridViewColumn newColumnmx1牌号 = new DataGridViewTextBoxColumn();
            newColumnmx1牌号.HeaderText = "牌号";
            newColumnmx1牌号.Name = "c牌号";
            newColumnmx1牌号.ValueType = typeof(int);
            newColumnmx1牌号.Width = 150;
            dataGridView目标托盘信息.Columns.Add(newColumnmx1牌号);

            DataGridViewColumn newColumnmx主成品牌号 = new DataGridViewTextBoxColumn();
            newColumnmx主成品牌号.HeaderText = "主成品牌号";
            newColumnmx主成品牌号.Name = "c主成品牌号";
            newColumnmx主成品牌号.ValueType = typeof(int);
            newColumnmx主成品牌号.Width = 150;
            dataGridView目标托盘信息.Columns.Add(newColumnmx主成品牌号);

            DataGridViewColumn newColumnmx关重件类型 = new DataGridViewTextBoxColumn();
            newColumnmx关重件类型.HeaderText = "关重件类型";
            newColumnmx关重件类型.Name = "c关重件类型";
            newColumnmx关重件类型.ValueType = typeof(int);
            newColumnmx关重件类型.Width = 150;
            dataGridView目标托盘信息.Columns.Add(newColumnmx关重件类型);

            DataGridViewColumn newColumnmx备注 = new DataGridViewTextBoxColumn();
            newColumnmx备注.HeaderText = "备注";
            newColumnmx备注.Name = "c备注";
            newColumnmx备注.ValueType = typeof(string);
            newColumnmx备注.Width = 200;
            dataGridView目标托盘信息.Columns.Add(newColumnmx备注);

            #endregion

        }
    }
}
