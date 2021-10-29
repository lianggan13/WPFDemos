using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartParking.Server.Model
{
    [Table("sys_user_info")]
    public class SysUser
    {
        [Key]   // 主键
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // 自增
        [Column("id")]
        public int UserId { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("user_icon")]
        public string UserIcon { get; set; }
        [Column("real_name")]
        public string RealName { get; set; }
        [Column("age")]
        public int Age { get; set; }

        //[NotMapped]
        //public List<MenuInfo> Menus { get; set; }
    }
}
