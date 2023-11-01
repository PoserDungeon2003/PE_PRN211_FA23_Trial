using PE_PRN211_FA23_Trial_SE173445_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_PRN211_FA23_Trial_SE173445_Repo.Repository
{
    public class StaffMemberRepo
    {
        private AirConditionerShop2023DBContext context = new();
        public StaffMember CheckLogin(string username, string password)
        {
            StaffMember member = context.StaffMembers.FirstOrDefault(x => x.EmailAddress.Equals(username) && x.Password.Equals(password));
            return member;
        }
    }
}
