using SWarehouse.Controllers.StatisticalServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewAutoFilter;

namespace SWarehouse.Views
{
    public partial class F13_Statistical : Form
    {
        public F13_Statistical()
        {
            InitializeComponent();
        }

        private void F13_Statistical_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWarehouseDBDataSet.SP_GetProductStatistical' table. You can move, or remove it, as needed.
            this.sP_GetProductStatisticalTableAdapter.Fill(this.sWarehouseDBDataSet.SP_GetProductStatistical);
            // TODO: This line of code loads data into the 'sWarehouseDBDataSet.SP_GetCustomerStatistical' table. You can move, or remove it, as needed.
            this.sP_GetCustomerStatisticalTableAdapter.Fill(this.sWarehouseDBDataSet.SP_GetCustomerStatistical);
            // TODO: This line of code loads data into the 'sWarehouseDBDataSet1.SP_GetProductStatistical' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sWarehouseDBDataSet.SP_GetCustomerStatistical' table. You can move, or remove it, as needed.
            this.dgv_CustomerStatistical.AutoResizeColumns();
           
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            String filterStatus = DataGridViewAutoFilterColumnHeaderCell
                .GetFilterStatus(dgv_CustomerStatistical);
            if (String.IsNullOrEmpty(filterStatus))
            {
                ShowAllLabel.Visible = false;
                filterStatusLabel.Visible = false;
            }
            else
            {
                ShowAllLabel.Visible = true;
                filterStatusLabel.Visible = true;
                filterStatusLabel.Text = filterStatus;
            }
            for (int row = 0; row < dgv_CustomerStatistical.Rows.Count; row++)
            {
                object value = dgv_CustomerStatistical["CustomerStatus", row].Value;
                if (value != null && value.GetType() == typeof(string))
                {
                    string newValue = (string)value;
                    newValue = newValue.Replace("True", "Đang hoạt động");
                    newValue = newValue.Replace("False", "Ngừng hoạt động");
                    dgv_CustomerStatistical["CustomerStatus", row].Value = newValue;
                }
            }
            for (int row = 0; row < dgv_productStatistical.Rows.Count; row++)
            {
                object value = dgv_productStatistical["ProductStatus", row].Value;
                if (value != null && value.GetType() == typeof(string))
                {
                    string newvalue = (string)value;
                    newvalue = newvalue.Replace("True", "Đang bán");
                    newvalue = newvalue.Replace("False", "Ngừng bán");
                    dgv_productStatistical["ProductStatus", row].Value = newvalue;

                }
            }
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dgv_CustomerStatistical.CurrentCell.OwningColumn.HeaderCell as
                    DataGridViewAutoFilterColumnHeaderCell;
                if (filterCell != null)
                {
                    filterCell.ShowDropDownList();
                    e.Handled = true;
                }
            }
        }
        private void showAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgv_CustomerStatistical);
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgv_productStatistical);
        }
        private void dgv_productStatistical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dgv_productStatistical.CurrentCell.OwningColumn.HeaderCell as
                    DataGridViewAutoFilterColumnHeaderCell;
                if (filterCell != null)
                {
                    filterCell.ShowDropDownList();
                    e.Handled = true;
                }
            }
        }

        private void dgv_productStatistical_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_productStatistical.Rows)
            {
                if ((int)row.Cells[4].Value < 50)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
