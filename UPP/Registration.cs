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
    public partial class Registration : Form
    {
        MySqlConnection con;
        MySqlCommand command;

        public Registration()
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
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            if (tboxName.Text == "" || tboxFirstName.Text == "" || tboxOtchestvo.Text == "" || tboxSeria.Text == "" ||
                tboxNomer.Text == "" || tBoxLogin.Text == "" || tBoxPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (con == null)
                    return;
                command =
                    new MySqlCommand(
                        "INSERT INTO uppgrajdane ( Name, Familiya, Otchestvo, Seria, Nomer, login, password) Values (\"" +
                        tboxName.Text + "\", \"" + tboxFirstName.Text + "\", \"" + tboxOtchestvo.Text + "\", \"" +
                        tboxSeria.Text + "\", \"" + tboxNomer.Text + "\", \"" + tBoxLogin.Text + "\", \"" +
                        tBoxPassword.Text + "\"" + ")", con);
                command.ExecuteNonQuery();
                command =
                    new MySqlCommand(
                        "INSERT INTO links (adminID) VALUES (NULL)", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно зарегистрировались! Ваш логин: " + tBoxLogin.Text + " пароль: " +
                                tBoxPassword.Text);

                Close();
                //Form2 autorisation = new Form2();
                //autorisation.ShowDialog();
            }
        }
    }
}
