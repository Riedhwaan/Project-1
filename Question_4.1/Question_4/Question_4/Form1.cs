using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4
{
    public partial class Form1 : Form
    {
        
        Double First_Number;
        Double Second_Number;
        Double Final_Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
       
                First_Number = Convert.ToDouble(txtBox_1.Text);
                Second_Number = Convert.ToDouble(txtBox_2.Text);
                Result = (First_Number + Second_Number);
                MessageBox.Show("The Result is: " + Final_Result);
           
        }

        private void btn_SUBTRACT_Click(object sender, EventArgs e)
        {
            
                First_Number = Convert.ToDouble(txtBox_1.Text);
                Second_Number = Convert.ToDouble(txtBox_2.Text);
                Result = (First_Number - Second_Number);
                MessageBox.Show("The Result is: " + Final_Result);
            
        }

        private void btn_MULTIPLY_Click(object sender, EventArgs e)
        {
            
                First_Number = Convert.ToDouble(txtBox1.Text);
                Second_Number = Convert.ToDouble(txtBox2.Text);
                Result = (First_Number * Second_Number);
                MessageBox.Show("The Result is: " + Final_Result);
            
        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
        {
            
                txtBox_1.Text = "";
                txtBox_2.Text = "";

            
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            
                DialogResult dialogResult = MessageBox.Show("Are You sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            
        }

        private void rBtn_IWantToAdd_CheckedChanged(object sender, EventArgs e)
        {
            
                btn_ADD.Enabled = true;
                btn_ADD.Visible = true;
                btn_SUBTRACT.Visible = true;
                btn_MULTIPLY.Visible = true;
            
        }

        private void rBtn_IWantToSubtract_CheckedChanged(object sender, EventArgs e)
        {
            
                btn_SUBTRACT.Enabled = true;
                btn_SUBTRACT.Visible = true;
                btn_ADD.Visible = true;
                btn_MULTIPLY.Visible = true;
            
        }

        private void rBtn_IWantToMultiply_CheckedChanged(object sender, EventArgs e)
        {
            
                btn_MULTIPLY.Enabled = true;
                btn_MULTIPLY.Visible = true;
                btn_SUBTRACT.Visible = true;
                btn_ADD.Visible = true;
            
        }
    }
}
