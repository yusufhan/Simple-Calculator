using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalculator
{
    public partial class Form1 : Form
    {
      int a, b;
      bool dragging;
      Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBS.Enabled = false;
            txtB1.MaxLength = 4;
            txtB2.MaxLength = 4;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {
            txtBS.Text = "";
        }

        private void txtB2_TextChanged(object sender, EventArgs e)
        {
            txtBS.Text = "";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            try { 
            a = Convert.ToInt16(txtB1.Text);
            b = Convert.ToInt16(txtB2.Text);
            txtBS.Text = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter only number characters!");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt16(txtB1.Text);
                b = Convert.ToInt16(txtB2.Text);
                txtBS.Text = a.ToString() + " - " + b.ToString() + " = " + (a - b).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter only number characters!");
            }
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt16(txtB1.Text);
                b = Convert.ToInt16(txtB2.Text);
                txtBS.Text = a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter only number characters!");
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt16(txtB1.Text);
                b = Convert.ToInt16(txtB2.Text);
                txtBS.Text = a.ToString() + " / " + b.ToString() + " = " + (a / b).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter only number characters!");
            }
        }

        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8) {
                e.Handled = false;
            } else { e.Handled = true; }
           
        }
    }
}
