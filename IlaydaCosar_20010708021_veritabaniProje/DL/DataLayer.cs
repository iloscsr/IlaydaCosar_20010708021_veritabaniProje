using IlaydaCosar_20010708021_veritabaniProje;  
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilaydaCosar_veritabani.DL
{
    internal static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "ilaydadb",
                UserID = "ilayda",
                Password = "sifre123",
            }
            .ConnectionString
            );
        public static int MusteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.AD);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("ButunMusteriler", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MusteriGuncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.AD);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MusteriSil(string ms)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", ms);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("OdemeDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeGuncelle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("SatisDetay", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

             DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisEkle(Satis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatisEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisGuncelle(Satis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatisGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatisSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunEkle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("UrunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.AD);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("ButunUrunler", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("UrunBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunGuncelle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("UrunGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.AD);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("UrunSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}