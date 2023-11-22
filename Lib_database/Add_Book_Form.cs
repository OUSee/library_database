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
    public partial class Add_Book_Form : Form
    {
        public Add_Book_Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Finish_button_Click(object sender, EventArgs e)
        {

            string Name = Name_TB.Text;
            string Author = Author_TB.Text;
            string Publisher = Publisher_TB.Text;
            string Genre = Genre_TB.Text;
            int Year = int.Parse(Year_TB.Text);
            int Quantity = int.Parse(Quantity_TB.Text);

            DB.InsertInto("s", Name, Author, Publisher, Genre, Year, Quantity);
            
            this.Close();
                      
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
