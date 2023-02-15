using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnalyse_Click(object sender, EventArgs e)
        {
            //int value = Convert.ToInt32(TxtInput.Text);
            int zahl = Convert.ToInt32(TxtInput.Text);

            TxtOut.Clear();
            
            if (zahl >= 0)
            {
                TxtOut.Text += "Zahl ist positiv\r\n";
            }
            else
            {
                TxtOut.Text += "Zahl ist negativ\r\n";
            }

            if (zahl % 2 == 0)
            {
                TxtOut.Text += "Zahl ist gerade\r\n";
            }
            else
            {
                TxtOut.Text += "Zahl ist ungerade\r\n";
            }
        }
    }
}
