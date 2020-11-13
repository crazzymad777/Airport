using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считываем из формы ФИО и номер билета
            DataCenter.TokenData token_data = new DataCenter.TokenData();

            token_data.ticket_number = Convert.ToInt32(textBox4.Text);
            token_data.last_name = textBox1.Text;
            token_data.first_name = textBox2.Text;
            token_data.middle_name = textBox3.Text;

            // Передать значения в объект Терминала выдачи талонов
            ticket_terminal.passData(token_data);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаём объекты Терминала выдачи талонов и Центра сбора данных
            data_center = new DataCenter();
            ticket_terminal = new TicketTerminal(data_center);

            // Загружаем в БД тестовые данные
            data_center.seedTestData();
        }
        TicketTerminal ticket_terminal;
        DataCenter data_center;
    }
}
