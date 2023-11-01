using Microsoft.Extensions.Configuration;
using PE_PRN211_FA23_Trial_SE173445_Repo.Models;
using PE_PRN211_FA23_Trial_SE173445_Repo.Repository;

namespace PE_PRN211_FA23_Trial_SE173445
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StaffMemberRepo staffMemberRepo = new StaffMemberRepo();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            frmAirConditionerManagement management = new();
            var member = staffMemberRepo.CheckLogin(username, password);
            if (member is not null)
            {
                int? role = member.Role;
                if (role == 1)
                {
                    this.Hide();
                    management.Tag = 1;
                    management.ShowDialog();
                    this.Show();
                }
                else if (role == 2)
                {
                    this.Hide();
                    management.Tag = 2;
                    management.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    management.Tag = 3;
                    management.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("You have no permission to access this function!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}