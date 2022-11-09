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
using MySql.Data.MySqlClient;

namespace atletikaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT Versenyszam FROM `versenyekszamok` WHERE 1;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        versenyszamok versenyszamok = new versenyszamok(dr.GetString("versenyszam"));
                        listBox_versenyszam.Items.Add(versenyszamok);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT Nemzet FROM nemzetek JOIN versenyekszamok ON nemzetek.NemzetId = versenyekszamok.NemzetKod WHERE versenyekszamok.Helyezes LIKE 1;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        nemzetek nemzet = new nemzetek(dr.GetString("nemzet"));
                        listBox_nemzetek.Items.Add(nemzet);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            button_aranyos_nemzetek.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox_nemzetek.SelectedIndex < 0 )
            {
                MessageBox.Show(Environment.NewLine + "Nem választott nemzetet!");
                return;
            }
            if (listBox_versenyszam.SelectedIndex < 0)
            {
                MessageBox.Show(Environment.NewLine + "Nem választott versenyszámot!");
                return;
            }
            if (!(numericUpDown1.Value < 4 && numericUpDown1.Value > 0))
            {
                MessageBox.Show(Environment.NewLine + "Csak érmes helyezéseket tartalmaz a statisztika!");
                return;
            }

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT Nemzet, VersenyzoNev, Eredmeny FROM nemzetek JOIN versenyekszamok " +
                                      $"ON NemzetId WHERE Nemzet = '{listBox_nemzetek.Text}' AND Versenyszam = '{listBox_versenyszam.Text}' AND Helyezes = '{numericUpDown1.Value}'";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    dr.Read();
                    label_neve.Text += " " + dr.GetString("versenyzoNev");
                    label_eredmeny.Text += " " + dr.GetString("eredmeny");
                    label_nemzet.Text += " " + dr.GetString("nemzet");

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            
                
        }

    }
}
