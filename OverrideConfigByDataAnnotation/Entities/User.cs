using System.ComponentModel.DataAnnotations.Schema;

namespace OverrideConfigByDataAnnotation.Entities
{
    [Table("tblUsers")]
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
    }
}
