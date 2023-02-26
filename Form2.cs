using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        Person person;
        Form1 form1 = new Form1();
        string gender="df";
        
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(Person person)
        {
            InitializeComponent();
            textBox1.Text=person.Name;
            textBox2.Text = person.Surname;
            dateTimePicker1.Text = person.date;
            textBox4.Text = person.counri;
            textBox5.Text = person.city;
            gender= person.gender;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //person= (Person())sender;
            person = new Person(textBox1.Text.ToString(), textBox2.Text.ToString(),
                        dateTimePicker1.Text.ToString(),textBox4.Text.ToString(),
                        textBox5.Text.ToString(), gender.ToString());            
            form1.listBox1.Items.Add(person.ToString());
            //form1.l.Add(person);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gender = "Чоловік";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                gender = "Жінка";
            }
        }
    }
}
