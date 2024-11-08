using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using D_UTS.Model;
namespace D_UTS.App.Context
{
    internal class ContextAkun : DatabaseWrapper
    {
        private static string table = "akun";

        public static DataTable All()
        {
            string query = @"
        SELECT
            a.id,
            a.username,
            a.password,
            r.nama_role
        FROM
            mahasiswa m
        JOIN
            prodi p ON m.id_prodi = p.id";

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
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


        public static void AddAkun(M_Akun Akun)
        {
            string query = $"INSERT INTO {table} (username,password,id_role) VALUES(@username, @password,1)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", Akun.username),
                new NpgsqlParameter("@nim", Akun.password),
                new NpgsqlParameter("@email", mahasiswaBaru.email),
                new NpgsqlParameter("@semester", mahasiswaBaru.semester),
                new NpgsqlParameter("@id_prodi", mahasiswaBaru.id_prodi)
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
