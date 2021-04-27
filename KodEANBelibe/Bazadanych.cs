using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace KodEANBelibe
{
    public partial class Bazadanych : Form
    {
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";



        public Bazadanych()
        {
            InitializeComponent();

        }
        
        private void Bazadanych_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void Fill()
        {
            IPDB.Text = Login.Default.IPDB;
            DBInsertName.Text = Login.Default.INSERT_DB;
            DBInsertTable.Text = Login.Default.INSERT_TB;
            DBName.Text = Login.Default.DB;
            DBTable.Text = Login.Default.TB;
            User.Text = Login.Default.User;

            //Password.Text = Login.Default.Password;
        }

        private void DBSaveButton_Click(object sender, EventArgs e)
        {
            Login.Default.IPDB = IPDB.Text;
            Login.Default.INSERT_DB = DBInsertName.Text;
            Login.Default.INSERT_TB = DBInsertTable.Text;
            Login.Default.DB = DBName.Text;
            Login.Default.TB = DBTable.Text;
            Login.Default.User = User.Text;

            if (!String.IsNullOrEmpty(Password.Text))
            {
                Login.Default.Password = Encrypt(Password.Text);
            }

            Login.Default.Save();

            string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);
            //MessageBox.Show(connectionStatement);

            try
            {
                SqlConnection connection = new SqlConnection(@connectionStatement);
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT TOP(1) * FROM KodyEAN", connection);
                DataTable DBTB = new DataTable();
                sqlda.Fill(DBTB);
                int i = 0;
                foreach (DataRow row in DBTB.Rows)
                {
                    i++;
                }


                if (i==0)
                {
                    //MessageBox.Show(connection.State);
                    MessageBox.Show("Błąd łączenia z bazą danych");
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Błąd łączenia z bazą danych");
            }


        }
























        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
