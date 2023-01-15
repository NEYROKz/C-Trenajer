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

namespace C___Trenajer
{
    public partial class rating : Form
    {
        private SqlConnection sqlConnection = null;

        public rating()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(rating_MouseDown);
            
            
        }

  
        
        private void label5_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void rating_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void rating_Load(object sender, EventArgs e)
        {
            firstgrade_label.Text = Convert.ToString(DataForm.grade1);
            secondgrade_label.Text = Convert.ToString(DataForm.grade2);
            thirdgrade_label.Text = Convert.ToString(DataForm.grade3);
            fourthgrade_label.Text = Convert.ToString(DataForm.grade4);

            totalgrades_label.Text = Convert.ToString(DataForm.allgrades);


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);


            SqlCommand command = new SqlCommand(
                "SELECT name, surname FROM Students"
                , conn);

            try
            {
                conn.Open();
                SqlDataReader readerz = command.ExecuteReader();
                while (readerz.Read())
                {
                    namestudentz.Text = Convert.ToString(readerz["name"]);
                    namestudentz.AutoSize = true;
                    surnamestudentz.Text = Convert.ToString(readerz["surname"]);
                    surnamestudentz.AutoSize = true;
                }
                readerz.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void namestudentz_Click(object sender, EventArgs e)
        {

        }

        private void totalgrades_label_Click(object sender, EventArgs e)
        {

        }
    }
}
