using System.ComponentModel.DataAnnotations;

namespace Tool.Server.Models;

public class Role
{
    [Key]
    public string RoleCode { get; set; }
    public string RoleDiscription { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }

    //Navigation Properties
    public User User { get; set; }


}
