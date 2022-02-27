using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            string word, pig_Latin;
            word = txtBox_1.Text; //the word in the textbox is retreived
            pig_Latin = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay"; //conversion of the word
            label2.Text = ("The pig latin version is ") + pig_Latin; //the pig latin version displayed
        }
    }
}
