using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___Trenajer
{
    public partial class rating : Form
    {
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

        }
    }
}
