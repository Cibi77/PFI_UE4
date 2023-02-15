using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            int verbrauch = Convert.ToInt32(NumVerbrauch.Value);
            double result = 0;

            if (verbrauch <= 250)
            {
                result = verbrauch * 0.15;
            }

            else if (verbrauch >250 && verbrauch <= 500)
            {
                int zusatzkWh = verbrauch - 250;
                result = (250 * 0.15) + (zusatzkWh * 0.12);
            }
            else // Verbrauch grösser als 500kWh
            {
                int zusatzkWh = verbrauch - 500;
                result = (250 * 0.15) + (250 * 0.12) + (zusatzkWh * 0.11);
            }

            LblResult.Text = "Die " + Convert.ToString(verbrauch) + " kosten " + Convert.ToString(result) + " CHF";

        }
    }
}
