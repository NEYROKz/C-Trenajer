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

namespace C___Trenajer.UC_PAGES
{
    public partial class UC_1PAGE1 : UserControl
    {
        int wrong_answers;
        int right_answers;
        public string answers;
        public UC_1PAGE1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_1PAGE1_Load(object sender, EventArgs e)
        {
            



            string k;
            string[] name_tasks = new string[20];
            name_tasks[0] = "Алгоритм вычисления значения функции F(n), задан следующими соотношениями: \n" +
                           "F(1) = 1 \n" +
                           "F(n) = F( n – 1) * (n + 1), при n > 1 \n" +
                           "Чему равно значение функции F(5) ? В ответе запишите только целое число. \n";


            name_tasks[1] = "Алгоритм вычисления значения функции F(n), где n – натуральное число, задан следующими \n" +
                       "соотношениями: Чему равно значение функции F(5)? В ответе запишите только целое число. \n" +
                       "F(1) = 1 \n" +
                       "F(n) = F( n – 1) * (n + 2), при n > 1";



            name_tasks[2] = "Алгоритм вычисления значения функции F(n), задан следующими соотношениями: \n" +
                       "F(1) = 1 \n" +
                       "F(n) = F( n – 1) * (2 * n + 1), при n > 1 \n" +
                       "Чему равно значение функции F(4) ? В ответе запишите только целое число. \n";



            name_tasks[3] = "Алгоритм вычисления значения функции F(n), задан следующими соотношениями: \n" +
                       "F(0) = 1, F(1) = 1 \n" +
                       "F(n) = 3 * F( n – 1) - F(n - 2), при n > 1 \n" +
                       "Чему равно значение функции F(6) ? В ответе запишите только целое число. \n";



            name_tasks[4] = "Алгоритм вычисления значения функции F(n), где n – натуральное число, задан следующими соотношениями: \n" +
                        "F(0) = 1, F(1) = 1 \n" +
                        "F(n) = F(n–1) * F(n - 2) + 1, при n > 1 \n" +
                        "Чему равно значение функции F(6) ? В ответе запишите только целое число. \n";

            name_tasks[5] = "Дан рекурсивный алгоритм. Сколько символов ″*″ будет напечатано на экране при вызове F(7)? \n" +
                "void F(int n) \n" +
                "{ \n" +
                "cout << ″*″; \n" +
                "if (n > 0) \n" +
                "{ \n" +
                "cout << ″*″; \n" +
                "F(n - 2);" +
                "F(n / 2); \n" +
                "} \n" +
                "} \n";

            name_tasks[6] = "Дан рекурсивный алгоритм: \n" +
                "void  F(int n) \n" +
                "{ \n" +
                "cout << ″*″; \n" +
                "if (n > 0) \n" +
                "{ \n" +
                "cout << ″*″; \n" +
                "F(n - 2); \n" +
                "F(n / 2); \n" +
                "F(n / 2); \n" +
                "} \n" +
                "} \n" +
                "Сколько символов ″звездочка″ будет напечатано на экране при выполнении вызова F(7)? \n";

            name_tasks[7] = "Дан рекурсивный алгоритм: \n" +
                        "void F(int n) \n" +
                        "{ \n" +
                        "cout << ″*″; \n" +
                        "if (n > 0) \n" +
                        "{ \n" +
                        "cout << ″*″; \n" +
                        "F(n - 2); \n" +
                        "F(n - 2); \n" +
                        "F(n / 2); \n" +
                        "} \n" +
                        "} \n" +
                        "Сколько символов ″звездочка″ будет напечатано на экране при выполнении вызова F(6)? \n";

            name_tasks[8] = "Дан рекурсивный алгоритм: \n" +
                "void F(int n) \n" +
                "{ \n" +
                "if (n > 0) \n" +
                "{ \n" +
                "F(n - 2); \n" +
                "F(n - 1); \n" +
                "F(n - 1); \n" +
                "} \n" +
                "cout << ″*″;" +
                "} \n" +
                "Сколько символов ″звездочка″ будет напечатано на экране при выполнении вызова F(5)? \n";

            name_tasks[9] = "Определите, что выведет на экран программа при вызове F(9). \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "if (n > 0) \n" +
                       "{ \n" +
                       "F(n – 4); \n" +
                       "F(n / 2); \n" +
                       "std::cout << n; \n" +
                       "} \n" +
                       "} \n";

            name_tasks[10] = "Определите, что выведет на экран программа при вызове F(9). \n" +
                       "void F(int n) \n" +
                       "{ \n" +
                       "if (n > 0) \n" +
                       "{ \n" +
                       "F(n – 4); \n" +
                       "F(n / 3); \n" +
                       "std::cout << n; \n" +
                       "} \n" +
                       "} \n";

            name_tasks[11] = "Задана функция F(n). Определите значение F(15). \n" +
                            "int F(int n) \n" +
                            "{ \n" +
                            "if (n > 3) \n" +
                            "return F(n - 3) + F(n / 3); \n" +
                            "else \n" +
                            "return n; \n" +
                            "} \n";


            name_tasks[12] = "Задана функция F(n). Определите значение F(11). \n" +
                        "int F(int n) \n" +
                        "{ \n" +
                        "if (n > 2) \n" +
                        "return F(n - 2) + F(n / 2); \n" +
                        "else \n" +
                        "return n; \n" +
                        "} \n";

            string s;
            string[] answer = new string[13];
            answer[0] = "1";
            answer[1] = "2";
            answer[2] = "3";
            answer[3] = "4";
            answer[4] = "5";
            answer[5] = "6";
            answer[6] = "7";
            answer[7] = "8";
            answer[8] = "9";
            answer[9] = "10";
            answer[10] = "11";
            answer[11] = "12";
            answer[12] = "13";



            Random rnd = new Random();
            int u;
            u = rnd.Next(13);
            k = answer[u];
            s = name_tasks[u];
            label1.Text = s.ToString();

            answers = k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.ReadOnly = true;
                
            if (textBox1.Text == answers)
            {
                MessageBox.Show("Вверно");
                right_answers++;
                DataForm.grade1 = DataForm.grade1 + 1;
                DataForm.allgrades = DataForm.allgrades + 1;
            }
            else
            {
                MessageBox.Show("Неверно");
                wrong_answers++;
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ответ";
            textBox1.ForeColor = Color.Gray;

        }
    }
}
