using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UPP
{
    public partial class Grajdani : Form
    {
        MySqlConnection con;
        MySqlCommand command;

        public Grajdani()
        {
            InitializeComponent();
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "7300",
                Database = "test"
            };
            con = new MySqlConnection(builder.ToString());
            con.Open();
            Vova();
        }

        public Grajdani(MySqlDataReader dr) : this()
        {
            tboxFirstName.Text = dr.GetString(1);
            tboxName.Text = dr.GetString(2);
            tboxOtchestvo.Text = dr.GetString(3);
            tboxSeria.Text = dr.GetString(4);
            tboxNomer.Text = dr.GetString(5);
            if (dr.IsDBNull(7))
            {
                tboxStatus.Text = "";
            }
            else
            {
                tboxStatus.Text = dr.GetString(7);
            }
            dr.Close();
        }

        void Vova()
        {
            string query = "SELECT COUNT(*) FROM uppgrajdane";
            command = new MySqlCommand(query, con);
            MySqlDataReader dread = command.ExecuteReader();
            dread.Read();
            dread.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tboxObrashenie.Text == "")
            {
                MessageBox.Show("Заполните Ваше обращение!");
            }
            else
            {
                if (con == null)
                    return;
                command =
                    new MySqlCommand(
                        "SELECT ID FROM uppgrajdane WHERE name=" + "\"" + tboxName.Text + "\"", con);
                MySqlDataReader dread = command.ExecuteReader();
                dread.Read();
                int id = dread.GetInt32(0);
                dread.Close();
                command =
                    new MySqlCommand(
                        "UPDATE uppgrajdane SET Obrashenie =" + "\"" + tboxObrashenie.Text + "\"" + " WHERE name=" + "\"" + tboxName.Text + "\"", con);
                command.ExecuteNonQuery();
                command =
                    new MySqlCommand(
                        "UPDATE links SET adminID =" + (comboBox_otdel.SelectedIndex + 1) + " WHERE userID =" + id, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Ваше обращение, успешно подано! Ождидайте рассмотрения в течении трех суток!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                  "SELECT t.ID, t.Familiya, t.Name, t.Otchestvo, t.Seria, t.Nomer, t.Obrashenie, t.Status FROM uppgrajdane AS t, links AS l, admins AS a WHERE a.ID = 1 AND l.adminID = 1 AND t.ID = l.userID", con);
            MySqlDataReader dread = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dread);
            dataGridView1.DataSource = dt;
        }

        private void btnAcceptStatus_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                    "UPDATE uppgrajdane SET " + dataGridView1.Columns[7].Name + "=\"" + comboBox1.Text + "\"" +  " WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value, con);
            command.ExecuteNonQuery();
            btnLoad_Click(new object(), new EventArgs());
        }

        private void Grajdani_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnLoadPens_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                  "SELECT t.ID, t.Familiya, t.Name, t.Otchestvo, t.Seria, t.Nomer, t.Obrashenie, t.Status FROM uppgrajdane AS t, links AS l, admins AS a WHERE a.ID = 2 AND l.adminID = 2 AND t.ID = l.userID", con);
            MySqlDataReader dread = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dread);
            dataGridView2.DataSource = dt;
        }

        private void btnLoadJKH_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                  "SELECT t.ID, t.Familiya, t.Name, t.Otchestvo, t.Seria, t.Nomer, t.Obrashenie, t.Status FROM uppgrajdane AS t, links AS l, admins AS a WHERE a.ID = 3 AND l.adminID = 3 AND t.ID = l.userID", con);
            MySqlDataReader dread = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dread);
            dataGridView3.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                    "UPDATE uppgrajdane SET " + dataGridView2.Columns[7].Name + "=\"" + comboBox2.Text + "\"" + " WHERE ID=" + dataGridView2.CurrentRow.Cells[0].Value, con);
            command.ExecuteNonQuery();
            btnLoadPens_Click(new object(), new EventArgs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con == null)
                return;
            command =
                new MySqlCommand(
                    "UPDATE uppgrajdane SET " + dataGridView3.Columns[7].Name + "=\"" + comboBox3.Text + "\"" + " WHERE ID=" + dataGridView3.CurrentRow.Cells[0].Value, con);
            command.ExecuteNonQuery();
            btnLoadJKH_Click(new object(), new EventArgs());
        }
    }
}
