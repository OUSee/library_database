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
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid dg = new DataGrid();
            Variables.SearchString = Search_TB.Text;

            dataGridView1.DataSource = DB.SelectFrom();
        }
    }
}
