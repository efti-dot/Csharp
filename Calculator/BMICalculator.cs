using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            heiComBox.ResetText();
            heiVal.ResetText();
            weiComBox.ResetText();
            weiVal.ResetText();
            p1.BackgroundImage = null;
            label2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(heiVal.Text == "" || heiComBox.Text == "" || weiComBox.Text == "" || weiVal.Text == "")
            {
                MessageBox.Show(
                    "You have left one or more",
                    "Insufficient input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            double height = Convert.ToDouble( heiVal.Text );
            double weight = Convert.ToDouble(weiVal.Text);

            if (heiComBox.Text == "Ft")
                height /= 3.28;
            else if (heiComBox.Text == "cm")
                height /= 100;

            if (weiComBox.Text == "lb")
                weight *= .45359237;
            if (weiComBox.Text == "g")
                weight /= 100;

            double BMI = weight / (height * height);

            if(BMI <= 18.5)
            {
                label2.Text = "Under Weight";
                p1.BackgroundImage = moodimages.Images[0];        
            }
            else if (BMI <= 24.9)
            {
                label2.Text = "Normal Weight";
                p1.BackgroundImage = moodimages.Images[1];
            }
            else if(BMI <= 29.9)
            {
                label2.Text = "Over Weight";
                p1.BackgroundImage = moodimages.Images[2];
            }
            else
            {
                label2.Text = "Obses";
                p1.BackgroundImage = moodimages.Images[0];
            }
        }

        private void checkInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                double val = Convert.ToDouble(box.Text);
            }
            catch {
                MessageBox.Show(
                    "Input format not supported",
                    "Wrong input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }
    }
}
