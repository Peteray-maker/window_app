using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tester
{
    public partial class Form1 : Form
    {
        private Perque new_person;
        public Form1()
        {
            InitializeComponent();
            new_person = new Perque();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int age);
            float.TryParse(textBox3.Text, out float amount);

            new_person.Enq(textBox1.Text, age, amount);
            textBox4.Text = new_person.Print();
        }
    }
}
