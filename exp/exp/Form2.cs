using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//во первых, отображать "ошибку" когда вводится длинное число++++++++++
//во вторых, при нажатии на текстбоксы убирать надписи+++++++
//и желательно всё выводить в одну строку
namespace exp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Введите первое число!";
            textBox2.Text = "Введите второе число!";
            textBox3.Text = "Введите третье число!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                do
                {
                    //textBox1.Text = "Введите первое число!";
                    int a = Convert.ToInt32(textBox1.Text);

                   
                    //textBox2.Text = "Введите второе число!";
                    int b = Convert.ToInt32(textBox2.Text);
                   
                    //textBox3.Text = "Введите третье число!";
                    int c = Convert.ToInt32(textBox3.Text);


                    if (a > b && a > c)
                    {
                        textBox4.Text = $"Число: {a} наибольшее";
                    }
                    else if (b > a && b > c) textBox4.Text = $"Число: {b} наибольшее";// + Environment.NewLine + $"Больше чем число: {a}" + Environment.NewLine + $"И число: {c}"; ;
                    {
                        if (c > b && c > a) textBox4.Text = $"Число: {c} наибольшее";// + Environment.NewLine + $"Больше чем число: {a}" + Environment.NewLine + $"И число: {b}";
                    }
                } while (false);
            }
            catch (FormatException)
            {
            }
            catch(OverflowException)       
            {
            }
            if (textBox1.TextLength > 11)
            {
                textBox1.Text = "Число слишком большое";
                textBox4.Text = "Ошибка";
            }
            if (textBox2.TextLength > 11)
            {
                textBox2.Text = "Число слишком большое";
                textBox4.Text = "Ошибка";
            }
            if (textBox3.TextLength > 11)
            {
                textBox3.Text = "Число слишком большое";
                textBox4.Text = "Ошибка";
            }
        }
        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
