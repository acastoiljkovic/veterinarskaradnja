using System;
using System.Collections.Generic;
using DataLayer.Models;

namespace DataLayer
{
    public class DbManager
    {
        private String CONNECTION_STRING = "Data Source=.\\SQLEXPRESS;Initial Catalog=vet;" +
                                            " Integrated Security = true";
        private static DbManager instance = null;
        private static Korisnik ulogovanKorisnik = null;
        private System.Data.SqlClient.SqlConnection connection;

        private DbManager()
        {
            connection = new System.Data.SqlClient.SqlConnection(CONNECTION_STRING);
        }

        public static DbManager getInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }

        public List<Korisnik> getAllKorisnik()
        {
            List<Korisnik> lista = new List<Korisnik>();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("select * from Korisnik", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik.ID = (int)reader["ID"];
                    korisnik.Ime = (string)reader["Ime"];
                    korisnik.Prezime = (string)reader["Prezime"];
                    korisnik.Email = (string)reader["Email"];
                    korisnik.Tip = (string)reader["Tip"];
                    lista.Add(korisnik);
                }
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return lista;
        }

        public bool ulogujKorisnika(String email, String lozinka)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("select Lozinka,Ime,Prezime,ID,Tip,vet " +
                "from Korisnik where Email = @email", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            cmd.Parameters.AddWithValue("email", email);
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if ((string)reader["Lozinka"] != null &&
                        (string)reader["Lozinka"] == lozinka)
                    {
                        if (ulogovanKorisnik == null)
                            ulogovanKorisnik = new Korisnik();
                        ulogovanKorisnik.Email = email;
                        ulogovanKorisnik.ID = (int)reader["ID"];
                        ulogovanKorisnik.Ime = (string)reader["Ime"];
                        ulogovanKorisnik.Prezime = (string)reader["Prezime"];
                        ulogovanKorisnik.Tip = (string)reader["Tip"];
                        ulogovanKorisnik.VetID = (int)reader["vet"];
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                reader.Close();
                connection.Close();
            }


            return false;
        }

        public System.Data.DataTable getVeterinarskeRadnje()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("select * from Veterinarska_radnja", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            try
            {

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        public System.Data.DataTable getSveKorisnikeVeterinarskeRadnje(String naziv)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("select * from Korisnik where vet = " +
                "(select ID from Veterinarska_radnja where Naziv = @naziv)", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            cmd.Parameters.AddWithValue("naziv", naziv);
            try
            {

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        public System.Data.DataTable getBrojKorisnika()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
               .SqlCommand("select Tip, count(*) Broj from Korisnik group by tip;",
               connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            try
            {

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                connection.Close();
            }

            return null;

        }

        public System.Data.DataTable getLjubimacForKorisnik(String ime)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("select * from Ljubimac where vlasnik = " +
                "(select ID from Korisnik where Ime = @ime)", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            cmd.Parameters.AddWithValue("ime", ime);
            try
            {

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        public bool dodajLjubimca(Ljubimac ljubimac)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand("insert into Ljubimac(ID,Ime,Tip,Datum_rodjenja,vlasnik) " +
                "values ((select max(ID)+1 from Ljubimac),@ime,@tip,@datum,@vlasnik) "
                , connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            cmd.Parameters.AddWithValue("ime", ljubimac.Ime);
            cmd.Parameters.AddWithValue("tip", ljubimac.Tip);
            cmd.Parameters.AddWithValue("datum", ljubimac.DatumRodjenja.Date);
            cmd.Parameters.AddWithValue("vlasnik", ulogovanKorisnik.ID);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public List<KorisnikLjubimac> getKorisnikLjubimac(String tekst, bool ime, bool prezime, bool ljubimac)
        {
            List<KorisnikLjubimac> listKorisnikLjubimac = new List<KorisnikLjubimac>();
            String sqlQuery = "select Korisnik.Ime ime, Korisnik.Prezime prezime, Ljubimac.Ime naziv" +
                " from Korisnik inner join Ljubimac on Ljubimac.vlasnik = Korisnik.ID ";
            if (ime)
            {
                sqlQuery += "where Korisnik.Ime like '%" + tekst + "%' ";
                if (prezime && ljubimac)
                {
                    sqlQuery += "and Korisnik.Prezime like '%" + tekst + "%' and Ljubimac.Ime like '%" + tekst + "%' ";

                }
                else if (prezime)
                {
                    sqlQuery += "and Korisnik.Prezime like '%" + tekst + "%' ";

                }
                else if (ljubimac)
                {
                    sqlQuery += "and Ljubimac.Ime like '%" + tekst + "%' ";

                }
            }
            else if (prezime)
            {
                sqlQuery += "where Korisnik.Prezime like '%" + tekst + "%' ";
                if (ljubimac)
                {
                    sqlQuery += "and Ljubimac.Ime like '%" + tekst + "%' ";
                }

            }
            else if (ljubimac)
            {
                sqlQuery += "where Ljubimac.Ime like '%" + tekst + "%' ";

            }
            else
            {
                // vracamo sve korisnike i njihove ljubimce ukoliko nije cekiran
                // ni jedan checkbox, zbog toga u else delu ne radimo nista
                // ukoliko zelite da lista bude prazna otkomentarisati liniju ispod
                //return listKorisnikLjubimac;
            }
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient
                .SqlCommand(sqlQuery, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    KorisnikLjubimac korisnik = new KorisnikLjubimac();
                    korisnik.Ime = (string)reader["ime"];
                    korisnik.Prezime = (string)reader["prezime"];
                    korisnik.Ljubimac = (string)reader["naziv"];
                    listKorisnikLjubimac.Add(korisnik);
                }
            }
            catch (Exception e)
            {
                // TODO add exception routine
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return listKorisnikLjubimac;
        }

        public Korisnik getUlogovanKorisnik()
        {
            return ulogovanKorisnik;
        }
    }
}
