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
    public partial class frmAirConditionerDetail : Form
    {
        public int? AirConditionerID { get; set; }
        private AirConditionerRepo airConditionerRepo = new();
        public frmAirConditionerDetail()
        {
            InitializeComponent();
        }

        private void frmAirConditionerDetail_Load(object sender, EventArgs e)
        {
            cbSupplierID.DataSource = airConditionerRepo.GetAllCompany().Select(x => new
            {
                x.SupplierId,
                x.SupplierName
            }).ToList();
            cbSupplierID.DisplayMember = "SupplierName";
            cbSupplierID.ValueMember = "SupplierId";
            if (this.AirConditionerID != null)
            {
                var airConditioner = airConditionerRepo.GetAnAirConditioners((int)AirConditionerID);
                txtAirConditionerID.Text = airConditioner?.AirConditionerId.ToString();
                txtAirConditionerName.Text = airConditioner?.AirConditionerName;
                txtDolarPrice.Text = airConditioner?.DollarPrice.ToString();
                txtFeatureFunction.Text = airConditioner?.FeatureFunction;
                txtQuantity.Text = airConditioner?.Quantity.ToString();
                txtSoundPressureLevel.Text = airConditioner?.SoundPressureLevel.ToString();
                txtWarranty.Text = airConditioner?.Warranty.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcessData()
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
                if (AirConditionerID != null)
                {
                    airConditionerRepo.UpdateAnAirConditioner(airConditioner);
                    this.Close();
                }
                else
                {
                    if (CheckValidation())
                    {
                        bool existed = airConditionerRepo.CheckExistedItem((int)airConditioner.AirConditionerId);
                        if (!existed)
                        {
                            airConditionerRepo.AddAnAirConditioner(airConditioner);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Duplicated ID, please enter another ID", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                if(double.Parse(txtDolarPrice.Text) < 0 || double.Parse(txtDolarPrice.Text) > 4_000_000 
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
