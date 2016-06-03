using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UPP
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand command;
        public Form2()
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tboxLogin.Text == "" || tboxPassword.Text == "") 
            {
                MessageBox.Show("Введите логин и пароль!");
                tboxLogin.Clear();
                tboxPassword.Clear();
            }
            else
            {
                string query = "SELECT * FROM admins WHERE login =" + " \"" + tboxLogin.Text + " \"" + "AND password =" + " \"" + tboxPassword.Text + " \"";
                command = new MySqlCommand(query, con);
                MySqlDataReader dread = command.ExecuteReader();

                if (dread.Read())
                {
                    dread.Close();
                    if (tboxLogin.Text == "admin1" && tboxPassword.Text == "123")
                    {
                        Visible = false;
                        Grajdani grajdani = new Grajdani();
                        grajdani.tabControl1.TabPages[3].Parent = null;
                        grajdani.tabControl1.TabPages[2].Parent = null;
                        grajdani.tabControl1.TabPages[0].Parent = null;
                        grajdani.ShowDialog();
                        Visible = true;
                        tboxLogin.Clear();
                        tboxPassword.Clear();
                    }
                    else
                    {
                        if (tboxLogin.Text == "admin2" && tboxPassword.Text == "1234")
                        {
                            Visible = false;
                            Grajdani grajdani = new Grajdani();                           
                            grajdani.tabControl1.TabPages[1].Parent = null;
                            grajdani.tabControl1.TabPages[2].Parent = null;
                            grajdani.tabControl1.TabPages[0].Parent = null;
                            grajdani.ShowDialog();
                            Visible = true;
                            tboxLogin.Clear();
                            tboxPassword.Clear();
                        }
                        else
                        {
                            if (tboxLogin.Text == "admin3" && tboxPassword.Text == "12345")
                            {
                                Visible = false;
                                Grajdani grajdani = new Grajdani();
                                grajdani.tabControl1.TabPages[2].Parent = null;
                                grajdani.tabControl1.TabPages[1].Parent = null;
                                grajdani.tabControl1.TabPages[0].Parent = null;
                                grajdani.ShowDialog();
                                Visible = true;
                                tboxLogin.Clear();
                                tboxPassword.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Неправильный логин или пароль!");
                                tboxLogin.Clear();
                                tboxPassword.Clear();
                            }
                        }
                    }
                }
                else
                {
                    dread.Close();
                    query = "SELECT * FROM uppgrajdane WHERE login =" + " \"" + tboxLogin.Text + " \"" + "AND password =" + " \"" + tboxPassword.Text + " \"";
                    command = new MySqlCommand(query, con);
                    dread = command.ExecuteReader();

                    if (dread.Read())
                    {

                        Visible = false;
                        Grajdani grajdani = new Grajdani(dread);
                        grajdani.tabControl1.TabPages[1].Parent = null;
                        grajdani.tabControl1.TabPages[2].Parent = null;
                        grajdani.tabControl1.TabPages[1].Parent = null;
                        grajdani.ShowDialog();
                        Visible = true;
                        tboxLogin.Clear();
                        tboxPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль!");
                        tboxLogin.Clear();
                        tboxPassword.Clear();
                        dread.Close();
                    }
                }
                
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Visible = false;
            Registration registration = new Registration();
            registration.ShowDialog();
            Visible = true;
        }
    }
}
