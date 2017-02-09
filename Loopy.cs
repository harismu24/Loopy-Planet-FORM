using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loopy_Planet_Challenge
{
    public partial class Form1 : Form
    {
        double mercuryVal = 0.37;
        double jupiterVal = 2.64;
        double neptuneVal = 1.12;
        double venusVal = 0.88;
        double saturnVal = 1.15;
        double plutoVal = 0.04;
        double marsVal = 0.38;
        double uranusVal = 1.15;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mercury;
            Mercury = txtWeight.Text;
            MessageBox.Show(Mercury);

            string Jupiter;
            Jupiter = txtWeight.Text;
            MessageBox.Show(Jupiter);

            string neptune;
            neptune = txtWeight.Text;
            MessageBox.Show(neptune);

            string venus;
            venus = txtWeight.Text;
            MessageBox.Show(venus);

            string saturn;
            saturn = txtWeight.Text;
            MessageBox.Show(saturn);

            string pluto;
            pluto = txtWeight.Text;
            MessageBox.Show(pluto);

            string mars;
            mars = txtWeight.Text;
            MessageBox.Show(mars);

            string uranus;
            uranus = txtWeight.Text;
            MessageBox.Show(uranus);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("Mercury"))
            {
                double val;
                val = double.Parse(txtWeight.Text.ToString());

                txtResults.Text = (mercuryVal * val).ToString();

                if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("jupiter"))
                {
                  //  double val;
                    val = double.Parse(txtWeight.Text.ToString());
                    txtResults.Text = (jupiterVal * val).ToString();
                }

                if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("neptune"))
                {
                  //  double val;
                    val = double.Parse(txtWeight.Text.ToString());
                    txtResults.Text = (neptuneVal * val).ToString();

                    if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("venus"))
                    {
                        double venus;
                        venus = double.Parse(txtWeight.Text.ToString());
                        txtResults.Text = (venusVal * val).ToString();

                        if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("saturn"))
                        {
                            double saturn;
                            saturn = double.Parse(txtWeight.Text.ToString());
                            txtResults.Text = (saturnVal * val).ToString();

                            if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("pluto"))
                            {
                                double pluto;
                                pluto = double.Parse(txtWeight.Text.ToString());
                                txtResults.Text = (plutoVal * val).ToString();

                                if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("mars"))
                                {
                                    double mars;
                                    mars = double.Parse(txtWeight.Text.ToString());
                                    txtResults.Text = (marsVal * val).ToString();

                            if (txtWeight.Text != "" && cmbPlanet.SelectedItem == ("uranus"))
                                    {
                                        double uranus;
                                        uranus = double.Parse(txtWeight.Text.ToString());
                                        txtResults.Text = (uranusVal * val).ToString();
                                    }


                                }

                            }




                        }

                    }

                }
            }
        }

        private void cmbPlanet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
