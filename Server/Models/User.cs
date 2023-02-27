using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string RoleCode { get; set; }
        public Role Role { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserSummary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        //Navigation Properties
        public virtual ICollection<Score> Scores { get; set; }


    }
}

