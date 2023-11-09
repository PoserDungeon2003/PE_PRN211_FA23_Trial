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
        private AirConditionerRepo airConditionerRepo = new();

        public frmAirConditionerManagement()
        {
            InitializeComponent();
        }

        private void frmAirConditionerManagement_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = airConditionerRepo.GetAll().Select(x => new
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
            cbSupplierID.DataSource = airConditionerRepo.GetAllCompany().Select(x => new
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
                txtWarranty.Text = row.Cells[2].Value.ToString();
                txtSoundPressureLevel.Text = row.Cells[3].Value.ToString();
                txtFeatureFunction.Text = row.Cells[4].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
                txtDolarPrice.Text = row.Cells[6].Value.ToString();
                cbSupplierID.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtAirConditionerID.Text)
                || !int.TryParse(txtAirConditionerID.Text, out id))
            {
                MessageBox.Show("The Airconditioner ID is invalid. Please select a row to delete",
                    "Invalid AirconditionerID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dialog = MessageBox.Show($"Are you sure you want to delete this product: {id}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                airConditionerRepo.DeleteAirConditionerByID(id);
                LoadInfo();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtAirConditionerID.Text)
                || !int.TryParse(txtAirConditionerID.Text, out id))
            {
                MessageBox.Show("The Airconditioner ID is invalid. Please select a row to update",
                    "Invalid AirconditionerID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CheckValidation())
            {
                try
                {
                    AirConditioner airConditioner = new()
                    {
                        AirConditionerId = int.Parse(txtAirConditionerID.Text),
                        AirConditionerName = txtAirConditionerName.Text,
                        DollarPrice = Double.Parse(txtDolarPrice.Text),
                        FeatureFunction = txtFeatureFunction.Text,
                        Quantity = int.Parse(txtQuantity.Text),
                        SoundPressureLevel = txtSoundPressureLevel.Text,
                        Warranty = txtWarranty.Text,
                        SupplierId = cbSupplierID.SelectedValue.ToString(),
                    };
                    airConditionerRepo.UpdateAnAirConditioner(airConditioner);
                    LoadInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            //frmAirConditionerDetail frmAirConditionerDetail = new();
            //frmAirConditionerDetail.AirConditionerID = int.Parse(txtAirConditionerID.Text);
            //frmAirConditionerDetail.ShowDialog(this);
            //LoadInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAirConditionerDetail frmAirConditionerDetail = new();
            frmAirConditionerDetail.ShowDialog(this);
            LoadInfo();

        }
        private bool CheckValidation()
        {
            if (txtAirConditionerID.Text == string.Empty
                || txtAirConditionerName.Text == string.Empty
                || txtDolarPrice.Text == string.Empty
                || txtFeatureFunction.Text == string.Empty
                || txtQuantity.Text == string.Empty
                || txtSoundPressureLevel.Text == string.Empty
                || txtWarranty.Text == string.Empty)
            {
                MessageBox.Show("All field are required", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (double.TryParse(txtDolarPrice.Text, out _) && double.TryParse(txtQuantity.Text, out _))
            {
                if (double.Parse(txtDolarPrice.Text) < 0 || double.Parse(txtDolarPrice.Text) > 4_000_000
                    || double.Parse(txtQuantity.Text) < 0 || double.Parse(txtQuantity.Text) > 4_000_000)
                {
                    MessageBox.Show("Dolar price or quantity must be greater than or equal to 0 and less than 4.000.000", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid datatype for quantity and dolar price", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!((txtAirConditionerName.Text.Length >= 5) && (txtAirConditionerName.Text.Length <= 90)))
            {
                MessageBox.Show("Air conditioner name must have at least 5 characters, maximum 90 characters", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string[] words = txtAirConditionerName.Text.Split(" ");
            foreach (string word in words)
            {
                if (!Char.IsUpper(word[0]))
                {
                    MessageBox.Show("Each word of air conditional name must begin with the capital letter", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            //Each word of the PetName must begin with the capital letter. PetName is not alowed with special characters.
            if (hasSpecialChar(txtAirConditionerName.Text))
                return true;
            return true;
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

    }
}
