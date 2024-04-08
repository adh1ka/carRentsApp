using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRentsApps
{
    internal class koneksi
    {
        public static SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-210TKKE\SQLEXPRESS;initial catalog=lks;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();

        public static bool validate(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT * FROM " + namaTabel + " WHERE ";
            for(int i = 0; i < value.Length; i++)
            {
                query += namaKolom[i] + " = ";
                if (namaKolom[i] == "password")
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if(i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }
            }
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close ();
                conn.Close();
                return false;
            }
        }

        public static int getId(string namaTabel, string[] namaKolom, string[] value, string[] kolomID)
        {
            string query = "SELECT " + kolomID + " FROM " + namaTabel + " WHERE ";
            for(int i =0; i < value.Length;i++)
            {
                query += namaKolom[i] + " = ";
                if (namaKolom[i] == "password")
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if (i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }

            }
            conn.Open ();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            int id;
            if (dr.HasRows)
            {
                id = Convert.ToInt32(dr["id"]);
            }
            else
            {
                id = 0;
            }
            dr.Close ();
            conn.Close ();
            return id;
        }
        public static void insert(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "INSERT INTO " + namaTabel +" (";
            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += namaKolom[i];
                if (i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += ") VALUES (";
            for (int i = 0; i < value.Length; i++)
            {
                if (namaKolom[i] == "password") 
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if (i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += ");";
            conn.Open();
            cmd = new SqlCommand (query, conn);
            cmd.ExecuteNonQuery ();
            conn.Close ();
        }
        public static void update(string namaTabel, string[] namaKolom, string[] value, string[] kolomID, int id)
        {
            try
            {
                string query = "UPDATE " + namaTabel + " SET ";
                for (int i = 0;i < namaKolom.Length;i++)
                {
                    if (namaKolom[i] == "password")
                    {
                        query += namaKolom[i] + "HASHBYTES('SHA2_256','" + value[i] + "')";
                    }
                    else
                    {
                        query += namaKolom[i] + " = '" + value[i] + "'";
                    }
                    if(i < namaKolom.Length - 1)
                    {
                        query += ",";
                    } 
                }
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void delete(string namaTabel, string[] kolomID, int id )
        {
            try
            {
                string query = "DELETE FROM " + namaTabel + " WHERE " + kolomID + " = " + id;
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
