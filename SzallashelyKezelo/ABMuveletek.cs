using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SzallashelyKezelo
{
    static class ABMuveletek
    {
        static SqlConnection conn;
        static SqlCommand command;

        public static void Kapcsolodas()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"FOGDKAROLY\SQLEXPRESS";
            builder.InitialCatalog = "szallashely_kezelo";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ToString();

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                command = new SqlCommand();
                command.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Nem sikerült az adatbázishoz kapcsolódni! -> " + ex.Message);
            }
        }

        public static void KapcsolatBontasa()
        {
            try
            {
                conn.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a kapcsolat bontásakor! -> " + ex.Message);
            }
        }

        public static Lista CampingLekeres()
        {
            try
            {
                Lista campingek = new Lista();
                command.Parameters.Clear();
                command.CommandText = "SELECT camping.vizpart, szallashely.id, szallashely.fajta, szallashely.iranyitoszam, szallashely.varos, szallashely.utca, szallashely.hazszam FROM camping INNER JOIN szallashely ON szallashely.id = camping.szallashely_id";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    campingek.Add(new Camping((bool)reader[0], reader[1].ToString(), (Fajta)Enum.Parse(typeof(Fajta), reader[2].ToString(), true), new Cim(reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString())));
                }
                reader.Close();
                return campingek;
            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a camping lekérdezésekor!" + ex.Message);
            }
        }

        public static Lista PanzioLekeres()
        {
            try
            {
                Lista panziok = new Lista();
                command.Parameters.Clear();
                command.CommandText = "SELECT panzio.reggeli AS 'reggeli', epitett_szallashely.szoba_ara AS 'ar', epitett_szallashely.csillagok AS 'csillagok', szallashely.id AS 'id', szallashely.fajta AS 'fajta', szallashely.iranyitoszam AS 'irszam', szallashely.varos AS 'varos', szallashely.utca AS 'utca', szallashely.hazszam AS 'hazszam' FROM panzio INNER JOIN epitett_szallashely ON epitett_szallashely.id = panzio.epitett_id INNER JOIN szallashely ON epitett_szallashely.szallashely_id = szallashely.id";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    panziok.Add(new Panzio((bool)reader["reggeli"], (int)reader["ar"], (byte)reader["csillagok"], (string?)reader["id"], (Fajta)Enum.Parse(typeof(Fajta), reader["fajta"].ToString(), true), new Cim(reader["irszam"].ToString(), reader["varos"].ToString(), reader["utca"].ToString(), reader["hazszam"].ToString())));
                }
                reader.Close();
                return panziok;
            }
            catch (Exception ex)
            {
                throw new Exception("A panzió lekérése nem sikerült! -> " + ex.Message);
            }
        }

        public static Lista SzallodaLekeres()
        {
            try
            {
                Lista szallodak = new Lista();
                command.Parameters.Clear();
                command.CommandText = "SELECT szalloda.wellness AS 'wellness', epitett_szallashely.szoba_ara AS 'ar', epitett_szallashely.csillagok AS 'csillagok', szallashely.id AS 'id', szallashely.fajta AS 'fajta', szallashely.iranyitoszam AS 'irszam', szallashely.varos AS 'varos', szallashely.utca AS 'utca', szallashely.hazszam AS 'hazszam' FROM szalloda INNER JOIN epitett_szallashely ON epitett_szallashely.id = szalloda.epitett_id INNER JOIN szallashely ON epitett_szallashely.szallashely_id = szallashely.id";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    szallodak.Add(new Szalloda((bool)reader["wellness"], (int)reader["ar"], (byte)reader["csillagok"], (string?)reader["id"], (Fajta)Enum.Parse(typeof(Fajta), reader["fajta"].ToString(), true), new Cim(reader["irszam"].ToString(), reader["varos"].ToString(), reader["utca"].ToString(), reader["hazszam"].ToString())));
                }
                reader.Close();
                return szallodak;
            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a szálloda lekérdezésénél! -> " + ex.Message);
            }
        }

        public static void UjSzalloda(Szalloda szalloda)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES(@id, @fajta, @iranyitoszam, @varos, @utca, @hazszam)";
                command.Parameters.AddWithValue("@id", szalloda.Id);
                command.Parameters.AddWithValue("@fajta", szalloda.Fajta.ToString());
                command.Parameters.AddWithValue("@iranyitoszam", szalloda.Cim.Iranyitoszam);
                command.Parameters.AddWithValue("@varos", szalloda.Cim.Varos);
                command.Parameters.AddWithValue("@utca", szalloda.Cim.Utca);
                command.Parameters.AddWithValue("@hazszam", szalloda.Cim.Hazszam);

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.CommandText = "INSERT INTO epitett_szallashely(szallashely_id, szoba_ara, csillagok) OUTPUT INSERTED.id VALUES(@szallashely_id, @szoba_ara, @csillagok)";
                command.Parameters.AddWithValue("@szallashely_id", szalloda.Id);
                command.Parameters.AddWithValue("@szoba_ara", szalloda.Szobaar);
                command.Parameters.AddWithValue("@csillagok", szalloda.Csillagok);

                int id = (int)command.ExecuteScalar();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO szalloda(epitett_id, wellness) VALUES(@epitett_id, @wellness)";
                command.Parameters.AddWithValue("@epitett_id", id);
                command.Parameters.AddWithValue("@wellness", szalloda.WellnessE);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Nem sikerült az új szálloda feltöltése! -> " + ex.Message);
            }
        }

        public static void UjPanzio(Panzio panzio)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES(@id, @fajta, @iranyitoszam, @varos, @utca, @hazszam)";
                command.Parameters.AddWithValue("@id", panzio.Id);
                command.Parameters.AddWithValue("@fajta", panzio.Fajta.ToString());
                command.Parameters.AddWithValue("@iranyitoszam", panzio.Cim.Iranyitoszam);
                command.Parameters.AddWithValue("@varos", panzio.Cim.Varos);
                command.Parameters.AddWithValue("@utca", panzio.Cim.Utca);
                command.Parameters.AddWithValue("@hazszam", panzio.Cim.Hazszam);

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.CommandText = "INSERT INTO epitett_szallashely(szallashely_id, szoba_ara, csillagok) OUTPUT INSERTED.id VALUES(@szallashely_id, @szoba_ara, @csillagok)";
                command.Parameters.AddWithValue("@szallashely_id", panzio.Id);
                command.Parameters.AddWithValue("@szoba_ara", panzio.Szobaar);
                command.Parameters.AddWithValue("@csillagok", panzio.Csillagok);

                int id = (int)command.ExecuteScalar();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO panzio(epitett_id, reggeli) VALUES(@epitett_id, @reggeli)";
                command.Parameters.AddWithValue("@epitett_id", id);
                command.Parameters.AddWithValue("@reggeli", panzio.ReggeliE);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Nem sikerült az új panzió feltöltése! -> " + ex.Message);
            }
        }

        public static void UjCamping(Camping camping)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES(@id, @fajta, @iranyitoszam, @varos, @utca, @hazszam)";
                command.Parameters.AddWithValue("@id", camping.Id);
                command.Parameters.AddWithValue("@fajta", camping.Fajta.ToString());
                command.Parameters.AddWithValue("@iranyitoszam", camping.Cim.Iranyitoszam);
                command.Parameters.AddWithValue("@varos", camping.Cim.Varos);
                command.Parameters.AddWithValue("@utca", camping.Cim.Utca);
                command.Parameters.AddWithValue("@hazszam", camping.Cim.Hazszam);

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.CommandText = "INSERT INTO camping(szallashely_id, vizpart) VALUES(@szallashely_id, @vizpart)";
                command.Parameters.AddWithValue("szallashely_id", camping.Id);
                command.Parameters.AddWithValue("vizpart", camping.VizpartiE);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Az új camping feltöltése nem sikerült! -> " + ex.Message);
            }
        }

        public static void SzallodaTorles(Szalloda szalloda)
        {
            command.Parameters.Clear();
            command.CommandText = "DELETE szalloda FROM szalloda INNER JOIN epitett_szallashely ON szalloda.epitett_id = epitett_szallashely.id WHERE epitett_szallashely.szallashely_id = @id";
            command.Parameters.AddWithValue("@id", szalloda.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM epitett_szallashely WHERE szallashely_id = @id";
            command.Parameters.AddWithValue("@id", szalloda.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM szallashely WHERE id = @id";
            command.Parameters.AddWithValue("@id", szalloda.Id);

            command.ExecuteNonQuery();
        }

        public static void PanzioTorles(Panzio panzio)
        {
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE panzio FROM panzio INNER JOIN epitett_szallashely ON panzio.epitett_id = epitett_szallashely.id WHERE epitett_szallashely.szallashely_id = @id";
            command.Parameters.AddWithValue("@id", panzio.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM epitett_szallashely WHERE szallashely_id = @id";
            command.Parameters.AddWithValue("@id", panzio.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM szallashely WHERE id = @id";
            command.Parameters.AddWithValue("@id", panzio.Id);

            command.ExecuteNonQuery();
        }

        public static void CampingTorles(Camping camping)
        {
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM camping WHERE szallashely_id = @id";
            command.Parameters.AddWithValue("@id", camping.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            command.CommandText = "DELETE FROM szallashely WHERE id = @id";
            command.Parameters.AddWithValue("@id", camping.Id);

            command.ExecuteNonQuery();
        }
    }
}
