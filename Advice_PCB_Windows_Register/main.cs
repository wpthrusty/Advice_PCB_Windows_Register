using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advice_PCB_Windows_Register
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bottom_toolstip_timetext.Text = DateTime.Now.ToLongTimeString();
            bottom_toolstip_datetext.Text = DateTime.Now.ToLongDateString();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
