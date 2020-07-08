using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pract8_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            var newText = Regex.Replace(text, "[абвгдеёжзийклмнопрстуфхцчшщыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЬЭЮЯ]", "");
            textBox2.Text = newText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
