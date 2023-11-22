using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_database
{
    public partial class Y_N_Form : Form
    {
        public Y_N_Form()
        {
            InitializeComponent();
            Message.Text = Variables.MessageText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Variables.ShureForm = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variables.ShureForm = false;
            this.Close();
        }
    }
}
