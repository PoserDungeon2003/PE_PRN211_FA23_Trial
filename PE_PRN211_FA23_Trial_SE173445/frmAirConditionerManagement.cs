using Microsoft.EntityFrameworkCore;
using PE_PRN211_FA23_Trial_SE173445_Repo.Models;
using PE_PRN211_FA23_Trial_SE173445_Repo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_FA23_Trial_SE173445
{
    public partial class frmAirConditionerManagement : Form
    {
        private AirConditionerShop2023DBContext context = new();
        private AirConditionerRepo airConditionerRepo = new();
        public int Role { get; set; }
        public frmAirConditionerManagement()
        {
            InitializeComponent();
        }

        private void frmAirConditionerManagement_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            dataGridView1.DataSource = context.AirConditioners.Include(x => x.Supplier).Select(x => new
            {
                x.AirConditionerId,
                x.AirConditionerName,
                x.Warranty,
                x.SoundPressureLevel,
                x.FeatureFunction,
                x.Quantity,
                x.DollarPrice,
                x.Supplier.SupplierName
            }).ToList();
            cbSupplierID.DataSource = context.SupplierCompanies.Select(x => new
            {
                x.SupplierId,
                x.SupplierName
            }).ToList();
            cbSupplierID.DisplayMember = "SupplierName";
            cbSupplierID.ValueMember = "SupplierId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int role = Convert.ToInt32(this.Tag);
            if (role == 1)
            {
                SearchByQuantityOrFeature();
            }
            else
            {
                MessageBox.Show("You have no permission to access this function!");
            }

        }

        private void SearchByQuantityOrFeature()
        {
            string searchKeyword = txtSearch.Text;
            var searchValue = airConditionerRepo.searchByQuantityOrFeature(searchKeyword);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchValue.Select(x => new
            {
                x.AirConditionerId,
                x.AirConditionerName,
                x.Warranty,
                x.SoundPressureLevel,
                x.FeatureFunction,
                x.Quantity,
                x.DollarPrice,
                x.Supplier.SupplierName
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewProduct(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtAirConditionerID.Text = row.Cells[0].Value.ToString();
                txtAirConditionerName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                txtWarranty.Text = row.Cells[3].Value.ToString();
                txtSoundPressureLevel.Text = row.Cells[4].Value.ToString();
                txtDolarPrice.Text = row.Cells[5].Value.ToString();
                txtFeatureFunction.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtAirConditionerID.Text;
            DialogResult dialog = MessageBox.Show($"Are you sure you want to delte this product: {id}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                airConditionerRepo.DeleteAirConditionerByID(id);
                dataGridView1.DataSource = null;
                LoadInfo();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
