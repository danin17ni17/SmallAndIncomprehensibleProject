namespace exp
{
    public partial class Form1 : Form
    {
        double kvadrat;
        double radius;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "Введите радиус";
            textBox4.Text = "Введите любое число";
         //   textBox5.Text = "Введите ваше название: ";
        }
        private void Button1_Click(object sender, EventArgs? e)
        {
            //узнаём нашу операционную систему.
            textBox1.Text = "" + Environment.OSVersion;
            //задаём значение 2, оно будет 
            //автоматически округляться до 3
            //НЕ ЗАБЫВАТЬ f В КОНЦЕ ЦИФРЫ
            // float s = 2.000001f; ///////можно через переменную
            //отображаем во втором текстовом боксе
            //округление благодаря классу Math +
            //методу Ceiling(который округляет к большему)
            //методу Floor(который округляет к меньшему)
            //методу Round(который округляет в зависимости от десятых)
            //методу Pow(который возводит в степень)
            //также существуют min,max(между двумя значениями),cos и тд.
            textBox2.Text = "К большему: " + Math.Ceiling(2.499f) + "."
            + Environment.NewLine + "К меньшему: " + Math.Floor(2.499f) + "."
            + Environment.NewLine + "В степени 2: " + Math.Pow(2.499, 2) + ".";
            //textBox3.Text = "Введите радиус";
            //textBox4.Text = "Введите любое число";
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //задаём на отклик первого бокса клавишу enter
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                Button1_Click(button1, null);
            }
            //задаём на отклик первого бокса клавишу esc
            if (e.KeyValue == Convert.ToChar(Keys.Escape))
            {
                Button2_Click(button2, null);
            }
        }
        //кнопка закрытия
        private void Button2_Click(object sender, EventArgs? e)
        {
        //закрытие
            Close();
        }
        //расчёт площади круга в третьем текстбоксе.
        private void Button3_Click(object sender, EventArgs e)
        {
            //задаём переменную радиус
            //типа double
           
            try {
                
                //конвертируем radius в тип дабл
                radius = Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException) 
            {
            }
            //рассчитываем через класс Math
            //задаём число пи и умножаем его на
            //заданный нами радиус в квадрате
            double area = Math.PI * Math.Pow(radius, 2);
            //отображаем полученную площадь в боксе
            textBox3.Text = "" + area.ToString();
        }
        //возведение в квадрат
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                kvadrat = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
            }
            double nadva = Math.Pow(kvadrat, 2);
            textBox4.Text = "" + nadva.ToString();
        }
        Form2 perehod = new();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            perehod.ShowDialog();
            this.Show();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        //   private void Button5_Click(object sender, EventArgs e)
        //  {
        /*   
           string roll = Convert.ToString(textBox5.Text);

           if (roll == "Admin")
           {
             //  textBox5.Text = "Введите ваше имя: ";
              // string name = Convert.ToString(textBox5.Text);
               //textBox5.Text = "Введите cколько вам лет: " + name.ToString();
           }
           else
               textBox5.Text = "Ты не Админ!";
       */
        // }
    }
}