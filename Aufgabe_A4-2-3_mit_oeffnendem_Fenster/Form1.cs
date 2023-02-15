using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A4_2_3_mit_oeffnendem_Fenster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdDraw_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(TxtHeight.Text);
            int width = Convert.ToInt32(TxtWidth.Text);

            if (!((height >= 50) && (height <= 100) && (width >= 50) && (width <= 100)))
            {
                MessageBox.Show("Es sind nur Werte zwischen 50 und 100 erlaubt!");
            }
            else
            {
                TxtBox.Width = width;
                TxtBox.Height = height;
                LblBoxHeight.Text = Convert.ToString(height);
                LblBoxLength.Text = Convert.ToString(width);
                LblBoxLength.Location = new Point((TxtBox.Location.X + (TxtBox.Width/2-10)), (TxtBox.Location.Y-15));
                LblBoxHeight.Location = new Point((TxtBox.Location.X + TxtBox.Width + 10), (TxtBox.Location.Y + (TxtBox.Height / 2)));

                if (width == height)
                {
                    LblQuadrat.Text = "Quadrat!";
                    LblQuadrat.Location = new Point(TxtBox.Location.X, (TxtBox.Location.Y + TxtBox.Height + 10));
                }
            }

        }
    }
}
