using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication10.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        public virtual MyUserInfo UserInfo { get; set; }


    }


    public class MyUserInfo
    {
        public int MyUserInfoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}