using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            if (cbselect.SelectedItem.ToString() == "10%")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum.Text);
                conv = 0.1 * n1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "20%")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum.Text);
                conv = 0.2 * n1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "50%")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum.Text);
                conv = 0.5 * n1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "75%")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum.Text);
                conv = 0.75 * n1;
                txtanswer.Text = conv.ToString();
            }
        }
    }
}
