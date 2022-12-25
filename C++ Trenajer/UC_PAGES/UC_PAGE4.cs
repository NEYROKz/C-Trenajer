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

namespace C___Trenajer.UC_PAGES
{
    public partial class UC_PAGE4 : UserControl
    {
        string answers;
        public UC_PAGE4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Завершить процесс?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameconnect(object sender, EventArgs e)
        {
            if(textBox1.Text == "Ответ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void nameleave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Ответ";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void UC_PAGE4_Load(object sender, EventArgs e)
        {
            string s;                         
            string[] tasks = new string[7];
            tasks[0] = "Определите сумму цифр, которые выведет программа при вызове F(60) ? \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                        "if (n > 0) \n" +
                        "{ \n" +
                        "std::cout << ″3″; \n" +
                        "G(n - 1); \n" +
                        "} \n" +
                        "} \n" +
                        " \n " +
                        "void G(int n) \n" +
                        "{ \n" +
                        "std::cout << ″2″; \n" +
                        "if (n > 1) \n" +
                        "{ \n" +
                        "std::cout << ″2″; \n" +
                        "F(n - 2); \n" +
                        "} \n" +
                        "} \n";

            tasks[1] = "Сколько символов 'A' выведет программа при вызове F(10)? \n" +
                        "void F(int n) \n" +
                        "{  \n" +
                        "if (n > 0) \n" +
                        "{  \n" +
                        "std::cout << ″B″;  \n" +
                        "G(n - 1); \n" +
                        "} \n" +
                        "} \n" +
                        " \n" +
                        "void G(int n) \n" +
                        "{ \n" +
                        "if (n > 1) \n" +
                        "{ \n" +
                        "std::cout << ″A″; \n" +
                        "F(n - 2); \n" +
                        "} \n" +
                        "} \n";


            tasks[2] = "При выполнении вызова F(8) на экран было выведено математическое выражение. Вычислите его значение. \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "std::cout << ″2″; \n" +
                       "if (n > 0) \n" +
                       "{ \n" +
                       "std::cout << ″ * ″; \n" +
                       "G(n - 1); \n" +
                       "} \n" +
                       "} \n" +
                       " \n" +
                       "void G(int n) \n" +
                       "{ \n" +
                       "std::cout << ″3″; \n" +
                       "if (n > 1) \n" +
                       "F(n - 2); \n" +
                       "} \n";

            tasks[3] =  "При выполнении приведённой ниже программы на экран было выведено математическое выражение. Вычислите его значение. \n" +
                        "void G(int n); \n" +
                        "void F(int n) \n" +
                        "{ \n" +
                        "std::cout << ″5″; \n" +
                        "if (n > 0) \n" +
                        "{ \n" +
                        "std::cout << " + "; \n" +
                        "G(n - 1); \n" +
                        "} \n" +
                        "} \n" +
                        " \n" +
                        "void G(int n) \n" +
                        "{ \n" +
                        "std::cout << ″2″; \n" +
                        "if (n > 1) \n" +
                        "F(n - 2); \n" +
                        "} \n" +
                        " \n" +
                        "void main() \n" +
                        "{ \n" +
                        "std::cout << ″2*(″; \n" +
                        "F(8); \n" +
                        "std::cout << ″)″ \n" +
                        "} \n" ;


            tasks[4] = "Определите сумму цифр, которые выведет программа при вызове F(90) ? \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "std::cout << ″5″; \n" +
                       "if (n > 0) \n" +
                       "{ \n" +
                       "std::cout << ″2″; \n" +
                       "G(n - 1); \n" +
                       "} \n" +
                       "} \n" +
                       " \n" +
                       "void G(int n) \n" +
                       "{ \n" +
                       "if (n > 1) \n" +
                       "{ \n" +
                       "std::cout << ″3″; \n" +
                       "F(n - 2); \n" +
                       "} \n" +
                       "} \n"; 
            
            
            tasks[5] = "Определите, что выведет на экран программа при вызове F(7). \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "n++; \n" +
                       "if (n > 3) \n" +
                       "{ \n" +
                       "std::cout << n; \n" +
                       "F(n / 3); \n" +
                       "F(n - 3); \n" +
                       "} \n" +
                       "else \n" +
                       "std::cout << n; \n" +
                       "} \n";



            tasks[6] = "Определите, что выведет на экран программа при вызове F(9). \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "if (n > 3) \n" +
                       "{ \n" +
                       "std::cout << n; \n" +
                       "F(n / 3); \n" +
                       "n++; \n" +
                       "F(n - 3); \n" +
                       "} \n" +
                       "else \n" +
                       "std::cout << n; \n" +
                       "} \n";



            string k;
            string[] answer = new string[7];
            answer[0] = "1";
            answer[1] = "2";
            answer[2] = "3";
            answer[3] = "4";
            answer[4] = "5";
            answer[5] = "6";
            answer[6] = "7";


            Random rnd = new Random();
            int u;
            u = rnd.Next(7);
            k = answer[u];
            s = tasks[u];
            label1.Text = s.ToString();

            answers = k;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
