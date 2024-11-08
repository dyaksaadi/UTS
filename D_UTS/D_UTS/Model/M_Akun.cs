using System;

namespace D_UTS.Model
{
    public class M_Buku
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("M_Role")]
        public int id_prodi { get; set; }

    }
}