using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C___Trenajer
{
    public partial class MainWindow : Form
    {
        private SqlConnection sqlConnection = null;
        public MainWindow()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MainWindow_MouseDown);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
 
            siticoneShadowForm1.SetShadowForm(this);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);



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
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            siticoneButton1.Controls.Clear();
            siticoneButton1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void firstpage(object sender, EventArgs e)
        {

        }

        private void secondpage(object sender, EventArgs e)
        {

        }

        private void thirdpage(object sender, EventArgs e)
        {

        }

        private void fourpage(object sender, EventArgs e)
        {

        }



        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked)
            {
                uC_2PAGE1.BringToFront();
            }
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked)
            {
                uC_PAGE31.BringToFront();
            }
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked)
            {
                uC_PAGE41.BringToFront();
            }
        }

        private void uC_1PAGE1_Load(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_1PAGE2_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked)
            {
                uC_1PAGE1.BringToFront();
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {



        }

        private void collapsing_Click(object sender, EventArgs e)
        {



            this.WindowState = FormWindowState.Minimized;

        }

        private void uC_1PAGE1_Load_1(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
          
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapsing1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_MouseDown_1(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(siticoneButton5.Checked)
            {
                uC_1PAGE11.BringToFront();
            }
        }

        private void siticoneButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton6.Checked)
            {
                uC_2PAGE2.BringToFront();
            }
        }

        private void siticoneButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton7.Checked)
            {
                uC_PAGE32.BringToFront();
            }
        }

        private void siticoneButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton8.Checked)
            {
                uC_PAGE42.BringToFront();
            }
        }

        private void uC_1PAGE11_Load(object sender, EventArgs e)
        {

        }
    }
}
