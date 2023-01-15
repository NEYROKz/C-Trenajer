using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___Trenajer.UC_PAGES
{
    public partial class UC_PAGE3 : UserControl
    {
        string answers;
        public UC_PAGE3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            







        }

        private void UC_PAGE3_Load(object sender, EventArgs e)
        {
            string s;
            string[] tasks = new string[6];
            tasks[0] =
            "Что выведет программа при вызове F(5)? \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n >= 3) \n" +
            "{ \n" +
            "std::cout << n + 1; \n" +
            "F(n - 1); \n" +
            "F(n - 2); \n" +
            "} \n" +
            "} \n";

            tasks[1] =
            "Что выведет программа при вызове F(7)?  \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n >= 3) \n" +
            "{ \n" +
            "std::cout << n; \n" +
            "F(n - 3); \n" +
            "F(n - 2); \n" +
            "} \n" +
            "} \n";

            tasks[2] =
            "Что выведет программа при вызове F(8)? \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n > 3) \n" +
            "{ \n" +
            "std::cout << n; \n" +
            "F(n - 3); \n" +
            "F(n - 2); \n" +
            "} \n" +
            "} \n";

            tasks[3] =
            "Что выведет программа при вызове F(-1)? \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n < 3) \n" +
            "{ \n" +
            "std::cout << n; \n" +
            "F(n + 3); \n" +
            "F(n + 2); \n" +
            "} \n" +
            "} \n";

            tasks[4] =
            "Определите, что выведет на экран программа при вызове F(9). \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n > 3) \n" +
            "{ \n" +
            "std::cout << n; \n" +
            "F(n - 3); \n" +
            "n++; \n" +
            "F(n / 3); \n" +
            "} \n" +
            "else \n" +
            "std::cout << n; \n" +
            "} \n";

            tasks[5] =
            "Определите, что выведет на экран программа при вызове F(9). \n" +
            "void F(int n) \n" +
            "{ \n" +
            "if (n > 3) \n" +
            "{ \n" +
            "std::cout << n; \n" +
            "n++; \n" +
            "F(n / 3); \n" +
            "F(n - 3); \n" +
            "} \n" +
            "else  \n" +
            "std::cout << n; \n" +
            "} \n";


            string k;
            string[] answer = new string[6];
            answer[0] = "1";
            answer[1] = "2";
            answer[2] = "3";
            answer[3] = "4";
            answer[4] = "5";
            answer[5] = "6";

            Random rnd = new Random();
            int u;
            u = rnd.Next(tasks.Length);
            s = tasks[u];
            k = answer[u];
            label1.Text = s.ToString();


            answers = k;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nameconnect(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ответ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void nameleave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ответ";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.ReadOnly = true;
            if (textBox1.Text == answers)
            {
                MessageBox.Show("Вверно");
                DataForm.grade3 = DataForm.grade3 + 1;
                DataForm.allgrades = DataForm.allgrades + 1;
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }
    }
}
