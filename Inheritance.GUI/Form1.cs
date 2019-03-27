using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance.GUI
{
    public partial class Form1 : Form
    {
        Person[] persons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            label4.Text = DateTime.Now.ToShortDateString();
            persons = new Person[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   

            String name = textBoxName.Text;
            String phone = textBoxPhone.Text;
            DateTime birthday = monthCalendar1.SelectionStart;
            int pol = radioButton1.Checked ? 1 : 2;

            /*
            String symbols = "0987654321,.-=+!@#$%^&*()/";
            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == symbols[i])
                    { 
                        MessageBox.Show("Имя содержит недопустимые символы: " + symbols);
                        return;
                    }
                }
            }
            */
            for (int j = 0; j < name.Length; j++)
            {
                if (!Char.IsLetter(name[j]))
                {
                    MessageBox.Show("Имя содержит недопустимые символы!");
                    return;
                }
            }

            if (phone != "")
            for (int j = 0; j < phone.Length; j++)
            {
                if (!Char.IsNumber(phone[j]))
                {
                    MessageBox.Show("Телефон должен состояь только из цифр!");
                    return;
                }
            }

            if (comboBox1.SelectedIndex == 0)
            {
                Person person = new Person(name, phone, birthday, pol);
                richTextBox1.Text += person.ToString() + "\n\n";
            }
            else
            {
                DateTime income = monthCalendar2.SelectionStart;
                String specialty = textBoxSpecialty.Text;
                if (specialty != "")
                {
                    Student student = new Student(name, phone, birthday, pol, income, specialty);
                    richTextBox1.Text += student.ToString() + "\n\n";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = false;
                label6.Visible = false;
                monthCalendar2.Visible = false;
                textBoxSpecialty.Visible = false;
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                monthCalendar2.Visible = true;
                textBoxSpecialty.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
