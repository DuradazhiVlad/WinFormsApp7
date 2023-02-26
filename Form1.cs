using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {

        public List<Person> l = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void ShowPersonInformation(Person person)
        {
            string message = $"Ім'я:{person.Name}; Фамілія:{person.Surname}; Дата народження: {person.date};" +
                   $"Країна: {person.counri}; Місто: {person.city}; Стать: {person.gender}";
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person person = listBox1.SelectedItem as Person;            
                Form2 form2 = new Form2(person);                
                form2.Show();
                
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                Person person = (Person)listBox1.SelectedItem;
                ShowPersonInformation(person);
            }
        }
        

        
    }
}