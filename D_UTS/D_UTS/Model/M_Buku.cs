using System;

namespace D_UTS.Model
{
    public class M_Buku
    {
        [Key]
        public int id_buku { get; set; }
        [Required]
        public string judul_buku { get; set; }
        [Required]
        public string tahun_terbit { get; set; }
        [Required]
        public string kategori { get; set; }

    }
}
