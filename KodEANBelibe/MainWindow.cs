using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodEANBelibe
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();

            //ListaSymboli.MouseDown += new MouseEventHandler(ListaSymboli_MouseDown);
            ListaSymboli.MouseDoubleClick += new MouseEventHandler(ListaSymboli_MouseDoubleClick);

            this.ActiveControl = Symbol;









        string s = Symbol.Text;
            string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.INSERT_DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);

            ListaSymboli.Items.Clear();

            var Lista = new List<SymbolClass>();

            try
            {
                SqlConnection connection = new SqlConnection(@connectionStatement);
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT TOP(10) tw_Symbol FROM dbo." + Login.Default.INSERT_TB + " WHERE tw_Symbol LIKE '%" + s + "%'", connection);
                DataTable DBTB = new DataTable();
                //MessageBox.Show("SELECT TOP(10) tw_Symbol FROM dbo." + Login.Default.INSERT_TB + " WHERE tw_Symbol LIKE '%" + s + "%'");
                sqlda.Fill(DBTB);

                foreach (DataRow row in DBTB.Rows)
                {
                    Lista.Add(new SymbolClass { Symbol = (string)row["tw_Symbol"] });
                }

                foreach (var item in Lista)
                {
                    string row = item.Symbol;
                    var line = new ListViewItem(row);
                    line.Tag = row;
                    ListaSymboli.Items.Add(line);
                }


            }
            catch
            {
                MessageBox.Show("Błąd łączenia z bazą danych");
            }

        }

        private void Symbol_Change(object sender, EventArgs e)
        {
            if (Symbol.TextLength > 3)
            {
                string s = Symbol.Text;
                string connectionStatement = "Data Source=" + Login.Default.IPDB + ";Initial Catalog=" + Login.Default.INSERT_DB + ";User ID=" + Login.Default.User + ";Password=" + Bazadanych.Decrypt(Login.Default.Password);

                ListaSymboli.Items.Clear();

                var Lista = new List<SymbolClass>();

                try
                {
                    SqlConnection connection = new SqlConnection(@connectionStatement);
                    SqlDataAdapter sqlda = new SqlDataAdapter("SELECT TOP(10) tw_Symbol FROM dbo." + Login.Default.INSERT_TB + " WHERE tw_Symbol LIKE '%" + s + "%'", connection);
                    DataTable DBTB = new DataTable();
                    //MessageBox.Show("SELECT TOP(10) tw_Symbol FROM dbo." + Login.Default.INSERT_TB + " WHERE tw_Symbol LIKE '%" + s + "%'");
                    sqlda.Fill(DBTB);

                    foreach (DataRow row in DBTB.Rows)
                    {
                        Lista.Add(new SymbolClass { Symbol = (string)row["tw_Symbol"]});
                    }

                    foreach (var item in Lista)
                    {
                        string row = item.Symbol;
                        var line = new ListViewItem(row);
                        line.Tag = row;
                        ListaSymboli.Items.Add(line);
                    }
                    //ListaSymboli.Height = 60;
                    ListaSymboli.Visible = true;


                }
                catch
                {
                MessageBox.Show("Błąd łączenia z bazą danych");
                }


        }
        }


        private void NewEAN_Click(object sender, EventArgs e)
        {
            if (!ListaSymboli.Visible && Symbol.TextLength > 3)
            {
                EAN ean = new EAN();
                //EANCode.Text = i.ToString();
                string ReadyEan = ean.GenerateEAN();

                

                bool status = ean.AddToDB(ReadyEan, Symbol.Text);
                if (status)
                {
                    EANCode.Text = ReadyEan;
                }
                else
                {
                    EANCode.Text = "";
                    MessageBox.Show("Rekord o takim Symbolu już istnieje w bazie");
                }
                
                this.ActiveControl = Symbol;
            }
        }

        private void DBButton_Click(object sender, EventArgs e)
        {
            Bazadanych DBSettings = new Bazadanych();
            DBSettings.ShowDialog();
        }

        private void CodeListButton_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.ShowDialog();
        }




        void ListaSymboli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = ListaSymboli.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.Symbol.Text = item.Text;
                ListaSymboli.Visible = false;

            }
            else
            {
                this.ListaSymboli.SelectedItems.Clear();
            }
        }



        //void ListaSymboli_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ListViewHitTestInfo info = ListaSymboli.HitTest(e.X, e.Y);
        //    ListViewItem item = info.Item;

        //    if (item != null)
        //    {
        //        //this.textBox1.Text = item.Text;
        //    }
        //    else
        //    {
        //        this.ListaSymboli.SelectedItems.Clear();
        //    }
        //}

        private void DBButton_Hover(object sender, EventArgs e)
        {
            DBButton.Image = global::KodEANBelibe.Properties.Resources.gear4;
        }
        private void DBButton_HoverLeave(object sender, EventArgs e)
        {
            DBButton.Image = global::KodEANBelibe.Properties.Resources.gear3;
        }

    }

    internal class SymbolClass
    {
        public string Symbol { get; set; }
    }
}
