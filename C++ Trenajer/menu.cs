using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace C___Trenajer
{

    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class menu : Form
    {
        private SqlConnection sqlConnection = null;
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        int selectedRow;
        public menu()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(menu_MouseDown);
        }

        

        private void adminlabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("answers", "Баллов");

        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            int id = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            string name = (record.GetValue(1) == DBNull.Value) ? string.Empty : record.GetString(1);
            string surname = (record.GetValue(2) == DBNull.Value) ? string.Empty : record.GetString(2);
            int id2 = (record.GetValue(3) == DBNull.Value) ? 0 : (int)record.GetValue(3);
            dgv.Rows.Add(id, name, surname, id2);

        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryStrings = $"select * from Students";

            SqlCommand command = new SqlCommand(
                 queryStrings, sqlConnection);


            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            sqlConnection.Close();
        }




        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapsing_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
          


            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        
       
        

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_surname.Text = row.Cells[2].Value.ToString();
                textBox_grade.Text = row.Cells[3].Value.ToString();
            }
        }

        private void SearchZ(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from Students where concat (id, name, surname, answers) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgv, read);
            }

            read.Close();
            sqlConnection.Close();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            SearchZ(dataGridView1);
        }


        private void UpdateZ()
        {
            sqlConnection.Open();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView1.Rows[index].Cells[3].Value;

                if(rowState == RoWState.Existed)
                {
                    continue;
                }
                if(rowState == RoWState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Students where id = {id}";

                    var command = new SqlCommand(deleteQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[3].Value = RoWState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[3].Value = RoWState.Deleted;
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            UpdateZ();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        
      
    }
}

