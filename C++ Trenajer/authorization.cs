using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace C___Trenajer
{
    public partial class authorization : Form
    {
        private SqlConnection sqlConnection = null;
        public authorization()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          
                SqlCommand command = new SqlCommand(
                  $"INSERT INTO [Students] (name, surname) VALUES (@name, @surname) ",
                  sqlConnection);

                command.Connection = sqlConnection;
                command.Parameters.AddWithValue("name", login.Text);
                command.Parameters.AddWithValue("surname", password.Text);
                command.ExecuteNonQuery();
            

            this.Hide();
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();

          if(login.Text == "admin")
            {
                if(password.Text == "admin")
                {
                    menu newform = new menu();
                    newform.Show();
                    mainwindow.Close();
                }
            }
        }

        private void authorization_Load_1(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();
            


            
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
    
        }

        private void nameconnect(object sender, EventArgs e)
        {
            if (login.Text == "Имя")
            {
                login.Text = "";
                login.ForeColor = Color.Black;

            }
        }

        private void nameleave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Имя";
                login.ForeColor = Color.Gray;

            }
        }

        private void surnameconnect(object sender, EventArgs e)
        {
            if (password.Text == "Фамилия")
            {
                password.Text = "";
                password.ForeColor = Color.Black;

            }
        }

        private void surnameleave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Фамилия";
                password.ForeColor = Color.Gray;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;

        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
