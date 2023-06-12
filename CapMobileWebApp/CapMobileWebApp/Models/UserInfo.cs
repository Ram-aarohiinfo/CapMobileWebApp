using Microsoft.AspNetCore.Identity;

namespace CapMobileWebApp.Models
{
    public class UserInfo: IdentityUser<int>
    {
        public int UserId { get; set; }

        public string? EmployeeName { get; set; }

        public string? Designation { get; set; }

        public string? Username { get; set; }

        public string? Apassword { get; set; }

        public int RoleId{ get; set; }

        public string? Userimage { get; set; }

        public int BranchId { get; set; }

        public int Active { get; set; }

        public int UnderofId { get; set; }


        public string? Empcode { get; set; }

        public int UserMobileNo { get; set; }

        public int AssociatedBEId { get; set;}










       










    }
}
