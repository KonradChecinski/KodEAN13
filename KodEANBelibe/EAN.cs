using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace KodEANBelibe
{
    class EAN
    {
        public double GenerateKontrolny(char[] eanSource)
        {
            //string ean1 = "007567816412";

            char[] ean = new char[13];

            for (int i = 0; i < 13; i++)
            {
                ean[i] = '0';
            }

            //ean = eanSource.ToCharArray();

            ean = eanSource;
            ean[0] = '1';

            
            double suma = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    suma += Char.GetNumericValue(ean[i]);
                }
                else
                {
                    suma += 3*Char.GetNumericValue(ean[i]);
                }
                
            }

            double reszta = 0;
            reszta = suma % 10;
            reszta = 10 - reszta;
            if (reszta == 10) reszta = 0;

            return reszta;
        }

        public string GenerateEAN()
        {
            char[] ean = new char[13];

            for (int i = 0; i < 13; i++)
            {
                ean[i] = '0';
            }

            //ean[7]
            //ean[8]
            //ean[9]
            //ean[10]
            //ean[11]

            //ean[12]

            string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);
            SqlConnection connection = new SqlConnection(@connectionStatement);
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT TOP(1) Id FROM KodyEAN ORDER BY id DESC", connection);
            DataTable DBTB = new DataTable();

            sqlda.Fill(DBTB);
            int id = 0;
            if (DBTB.Rows.Count != 0)
            {
                id = (int)DBTB.Rows[0]["Id"];
            }
            id++;

            if (id > 99999)
            {
                MessageBox.Show("Więcej kodów nie mogę wygenerować");
                return "";
            }
            int reszta = id % 10;
            ean[11] = reszta.ToString().ToCharArray()[0];
            id /= 10;
            reszta = id % 10;
            ean[10] = reszta.ToString().ToCharArray()[0];
            id /= 10;
            reszta = id % 10;
            ean[9] = reszta.ToString().ToCharArray()[0];
            id /= 10;
            reszta = id % 10;
            ean[8] = reszta.ToString().ToCharArray()[0];
            id /= 10;
            reszta = id % 10;
            ean[7] = reszta.ToString().ToCharArray()[0];


            double kontrolny = this.GenerateKontrolny(ean);

            try
            {
                ean[12] = kontrolny.ToString().ToCharArray()[0];
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            string ReadyEan = new string(ean);
            return ReadyEan;

        }

        public bool AddToDB(string ean, string symbol)
        {
            string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);
            string connectionStatement2 = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.INSERT_DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);

            //Lista.Add(new Kody { ID = 0, Symbol = connectionStatement, Kod = "" });

            try
            {
               
                SqlConnection connection = new SqlConnection(@connectionStatement);
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM KodyEAN WHERE Symbol LIKE '"+symbol+"'", connection);
                DataTable DBTB = new DataTable();
                sqlda.Fill(DBTB);

                if(DBTB.Rows.Count == 0)
                {
                    SqlConnection connection2 = new SqlConnection(@connectionStatement);
                    string statement = "INSERT INTO " + Login.Default.TB + " (Symbol, Kod) VALUES ('" + symbol + "', '" + ean + "')";


                    connection2.Open();
                    SqlCommand command = new SqlCommand(statement, connection2);
                    command.ExecuteNonQuery();
                    

                    

                    SqlConnection connection3 = new SqlConnection(@connectionStatement2);
                    connection3.Open();

                    SqlDataAdapter sqlda2 = new SqlDataAdapter("SELECT tw_PodstKodKresk FROM " + Login.Default.INSERT_TB + "  WHERE tw_Symbol = '" + symbol + "'", connection3);
                    DataTable DBTB2 = new DataTable();
                    sqlda2.Fill(DBTB2);

                    if((string)DBTB2.Rows[0]["tw_PodstKodKresk"] != "")
                    {
                        string statement3 = "UPDATE " + Login.Default.TB + " SET PoprzedniKod = '" + (string)DBTB2.Rows[0]["tw_PodstKodKresk"] + "' WHERE Symbol = '" + symbol + "'";
                        SqlCommand command3 = new SqlCommand(statement3, connection2);
                        command3.ExecuteNonQuery();
                    }
                    connection2.Close();

                    string statement4 = "UPDATE " + Login.Default.INSERT_TB + " SET tw_PodstKodKresk = '"+ean+"' WHERE tw_Symbol = '"+symbol+"'";
                    SqlCommand command4 = new SqlCommand(statement4, connection3);
                    command4.ExecuteNonQuery();

                    connection3.Close();


                    return true;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
