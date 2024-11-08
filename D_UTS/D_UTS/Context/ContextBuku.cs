using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_UTS.Model;
namespace D_UTS.App.Context
{
    internal class ContextAkun : DatabaseWrapper
    {
        private static string table = "daftar_buku";

        public static DataTable All()
        {
            string query = @"
        SELECT
            id_buku,
            judul_buku,
            tahun_terbit,
            kategori
            FROM
            daftar_buku";

            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        //public static DataTable getMahasiswaById(int id)
        //{
        //    string query = @"
        //        SELECT
        //            m.id,
        //            m.nama,
        //            m.nim,
        //            m.email,
        //            m.semester,
        //            m.id_prodi,
        //            p.nama_prodi  
        //        FROM
        //            mahasiswa m
        //        JOIN
        //            prodi p ON m.id_prodi = p.id
        //        WHERE
        //            m.id = @id";

        //    NpgsqlParameter[] parameters =
        //    {
        //        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
        //    };

        //    DataTable dataMahasiswa = queryExecutor(query, parameters);
        //    return dataMahasiswa;
        //}


        public static void AddBuku(M_Buku bukuBaru)
        {
            string query = $"INSERT INTO {table} (judul_buku, tahun_terbit, kategori) VALUES(@judul_buku, @tahun_terbit, @kategori)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_buku", bukuBaru.judul_buku),
                new NpgsqlParameter("@nim", bukuBaru.tahun_terbit),
                new NpgsqlParameter("@email", bukuBaru.kategori)
            };

            commandExecutor(query, parameters);
        }

        //public static void UpdateMahasiswa(M_Mahasiswa mahasiswa)
        //{
        //    string query = $"UPDATE {table} SET nama = @nama, nim = @nim, email = @email, semester = @semester, id_prodi = @id_prodi WHERE id = @id";

        //    NpgsqlParameter[] parameters =
        //    {
        //        new NpgsqlParameter("@nama", mahasiswa.nama),
        //        new NpgsqlParameter("@nim", mahasiswa.nim),
        //        new NpgsqlParameter("@email", mahasiswa.email),
        //        new NpgsqlParameter("@semester", mahasiswa.semester),
        //        new NpgsqlParameter("@id_prodi", mahasiswa.id_prodi),
        //        new NpgsqlParameter("@id", mahasiswa.id)
        //    };

        //    commandExecutor(query, parameters);
        //}

        //public static void DeleteMahasiswa(int id)
        //{
        //    string query = $"DELETE FROM {table} WHERE id = @id";

        //    NpgsqlParameter[] parameters =
        //    {
        //        new NpgsqlParameter("@id", id)
        //    };

        //    commandExecutor(query, parameters);
        //}
    }
}
