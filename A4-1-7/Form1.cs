using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int category = Convert.ToInt32(NumCategory.Value);
            int duration = Convert.ToInt32(NumDuration.Value);
            int way = Convert.ToInt32(NumWay.Value);
            double result =0;

            if (category == 1) //Kleinwagen

            {          

                if (way <= 60) // Gratis km
                {
                    result = duration * 60;
                }
                else  // km Zu berechnen
                {
                    int zusatzkm = way - 60;
                    result += zusatzkm * 0.4;
                    result += duration * 60;
                }

                LblOutput.Text = "Kosten: " + Convert.ToString(result) + " CHF";
            }

            else // Grosswagen
            {
                if (way <= 90) // Gratis km
                {
                    result = duration * 90;
                }
                else // km zu berechnen
                {
                    int zusatzkm = way - 90;
                    result += zusatzkm * 0.6;
                    result += duration * 90;
                }

                LblOutput.Text = "Kosten: " + Convert.ToString(result) + " CHF";
            }

        }
    }
}
