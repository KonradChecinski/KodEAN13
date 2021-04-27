using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KodEANBelibe
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }
        public void Lista_Load(object sender, EventArgs e)
        {
            var kody = GetKody();

            foreach (var item in kody)
            {
                var row = new string[] { item.ID.ToString(), item.Symbol, item.Kod };
                var line = new ListViewItem(row);
                line.Tag = row;
                List.Items.Add(line);
            }
        }
        private List<Kody> GetKody()
        {
            var Lista = new List<Kody>();
            

            string connectionStatement = "Data Source="+Login.Default.IPDB+";Initial Catalog="+Login.Default.DB+";User ID="+Login.Default.User+";Password="+ Bazadanych.Decrypt(Login.Default.Password);

            //Lista.Add(new Kody { ID = 0, Symbol = connectionStatement, Kod = "" });

            try
            {
                SqlConnection connection = new SqlConnection(@connectionStatement);
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM KodyEAN", connection);
                DataTable DBTB = new DataTable();

                sqlda.Fill(DBTB);
                foreach(DataRow row in DBTB.Rows)
                {
                    Lista.Add(new Kody { ID = (int)row["Id"], Symbol = (string)row["Symbol"], Kod = (string)row["Kod"] });
                }


            }catch
            {
                MessageBox.Show("Błąd łączenia z bazą danych");
                this.Close();
            }

            
            return Lista;

        }

        private void ListOkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListDeleteButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int id2 = 0;
            if(List.SelectedItems.Count == 0)
            {
                return;
            }
            id = Convert.ToInt32(List.SelectedItems[0].Text);
            id2 = List.SelectedItems[0].Index;
            
            var s = new string[3];
            s = (string[])List.Items[id2].Tag;


            string info = "Czy chcesz usunąć "+s[1]+" o kodzie wewnetrznym: "+s[2]+"? \nKod nie zostanie usunięty z Subiekta. Będzie go można teraz nadpisać nowym kodem lub wpisac ręcznie w Subiekcie.";
            DialogResult dialogResult = MessageBox.Show(info, "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (List.SelectedItems.Count != 0)
                {
                    ListViewItem item = List.Items[id2];
                    //MessageBox.Show(s[1]);

                    string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);

                    SqlConnection connection = new SqlConnection(@connectionStatement);
                    string statement = "DELETE FROM " + Login.Default.TB + " WHERE Id = " + id.ToString();
                    //MessageBox.Show(connectionStatement);
                    //MessageBox.Show(statement);


                    connection.Open();
                    SqlCommand command = new SqlCommand(statement, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Brak zaznaczonego rekordu");
                }
                List.Items.Clear();
                var kody = GetKody();

                foreach (var item in kody)
                {
                    var row = new string[] { item.ID.ToString(), item.Symbol, item.Kod };
                    var line = new ListViewItem(row);
                    line.Tag = row;
                    List.Items.Add(line);
                }
            }
            
        }
    }

    internal class Kody
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string Kod { get; set; }

    }
}
