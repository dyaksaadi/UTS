using System;

namespace D_UTS.Model
{
    public class M_Role
    {
        [Key]
        public int id_role { get; set; }
        [Required]
        public string nama_role { get; set; }
    }
} 
