using System;
using System.Collections.Generic;

#nullable disable

namespace PE_PRN211_FA23_Trial_SE173445_Repo.Models
{
    public partial class StaffMember
    {
        public int MemberId { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public int? Role { get; set; }
    }
}
