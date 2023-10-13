namespace exp
{
    public partial class Form1 : Form
    {
        double kvadrat;
        double radius;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "������� ������";
            textBox4.Text = "������� ����� �����";
         //   textBox5.Text = "������� ���� ��������: ";
        }
        private void Button1_Click(object sender, EventArgs? e)
        {
            //����� ���� ������������ �������.
            textBox1.Text = "" + Environment.OSVersion;
            //����� �������� 2, ��� ����� 
            //������������� ����������� �� 3
            //�� �������� f � ����� �����
            // float s = 2.000001f; ///////����� ����� ����������
            //���������� �� ������ ��������� �����
            //���������� ��������� ������ Math +
            //������ Ceiling(������� ��������� � ��������)
            //������ Floor(������� ��������� � ��������)
            //������ Round(������� ��������� � ����������� �� �������)
            //������ Pow(������� �������� � �������)
            //����� ���������� min,max(����� ����� ����������),cos � ��.
            textBox2.Text = "� ��������: " + Math.Ceiling(2.499f) + "."
            + Environment.NewLine + "� ��������: " + Math.Floor(2.499f) + "."
            + Environment.NewLine + "� ������� 2: " + Math.Pow(2.499, 2) + ".";
            //textBox3.Text = "������� ������";
            //textBox4.Text = "������� ����� �����";
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //����� �� ������ ������� ����� ������� enter
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                Button1_Click(button1, null);
            }
            //����� �� ������ ������� ����� ������� esc
            if (e.KeyValue == Convert.ToChar(Keys.Escape))
            {
                Button2_Click(button2, null);
            }
        }
        //������ ��������
        private void Button2_Click(object sender, EventArgs? e)
        {
        //��������
            Close();
        }
        //������ ������� ����� � ������� ����������.
        private void Button3_Click(object sender, EventArgs e)
        {
            //����� ���������� ������
            //���� double
           
            try {
                
                //������������ radius � ��� ����
                radius = Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException) 
            {
            }
            //������������ ����� ����� Math
            //����� ����� �� � �������� ��� ��
            //�������� ���� ������ � ��������
            double area = Math.PI * Math.Pow(radius, 2);
            //���������� ���������� ������� � �����
            textBox3.Text = "" + area.ToString();
        }
        //���������� � �������
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
             //  textBox5.Text = "������� ���� ���: ";
              // string name = Convert.ToString(textBox5.Text);
               //textBox5.Text = "������� c������ ��� ���: " + name.ToString();
           }
           else
               textBox5.Text = "�� �� �����!";
       */
        // }
    }
}