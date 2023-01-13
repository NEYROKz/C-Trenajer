using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace C___Trenajer
{
    public partial class UC_2PAGE : UserControl
    {
        int wrong_answers;
        int right_answers;
        public string answers;




        public UC_2PAGE()
        {
            
            InitializeComponent();
            
        }

 
        private void UC_2PAGE_Load(object sender, EventArgs e)
        {

           


            // задания
            string s;
            string[] tasks = new string[5];


            tasks[0] = "Алгоритм вычисления значений функций F(n) и G(n), задан соотношениями: \n" +
                            "F(1) = 2; G(1) = 1; \n" +
                            "F(n) = F(n–1) – G(n–1), \n" +
                            "G(n) = F(n–1) + G(n–1), при n >= 2 \n" +
                            "Чему равно значение величины F(5) / G(5) ? В ответе запишите только целое число. \n";



            tasks[1] = "Алгоритм вычисления значений функций F(n) и G(n), задан соотношениями: \n" +
                            "F(1) = 1; G(1) = 1; \n" +
                            "F(n) = F(n–1) – G(n–1), \n" +
                            "G(n) = F(n–1) + 2 * G(n–1), при n >= 2 \n" +
                            "Чему равно значение величины F(5) / G(5) ? В ответе запишите только целое число. \n";



            tasks[2] = "Алгоритм вычисления значений функций F(n) и G(n), задан соотношениями: \n" +
                             "F(1) = 1; G(1) = 1; \n" +
                             "F(n) = F(n–1) – 2 * G(n–1),  \n" +
                             "G(n) = F(n–1) + G(n–1), при n >= 2 \n" +
                             "Чему равно значение величины G(5) / F(5) ? В ответе запишите только целое число. \n";



            tasks[3] = "Алгоритм вычисления значений функций F(n) и G(n), задан соотношениями: \n" +
                             "F(1) = 1; G(1) = 1; \n" +
                             "F(n) = 2 * F(n–1) – G(n–1),  \n" +
                             "G(n) = F(n–1) + 2 * G(n–1), при n >= 2 \n" +
                             "Чему равно значение величины G(5) + F(5) ? В ответе запишите только целое число. \n";

            tasks[4] = "Алгоритм вычисления значений функций F(n) и G(n), задан соотношениями: \n" +
                             "F(1) = 1; G(1) = 1; \n" +
                             "F(n) = 2 * F(n–1) – G(n–1),  \n" +
                             "G(n) = 2 * F(n–1) + G(n–1), при n >= 2 \n" +
                             "Чему равно значение величины F(5) - G(5) ? В ответе запишите только целое число. \n";

            // ответы
            string k;
            string[] answer = new string[5];
            answer[0] = "1";
            answer[1] = "2";
            answer[2] = "3";
            answer[3] = "4";
            answer[4] = "5";



            // вывод вопросов
            Random rnd = new Random();
            int u;
            u = rnd.Next(5);
            //k = answer[u];
            s = tasks[u];
            k = answer[u];
            label1.Text = s.ToString();


            answers = k;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void connectlabel(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == answers)
            {
                MessageBox.Show("Вверно");
                right_answers++;
                DataForm.grade2 = DataForm.grade2 + 1;
            }
            else
            {
                MessageBox.Show("Неверно");
                wrong_answers++;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
