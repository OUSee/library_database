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
    public partial class Edit_Book_Form : Form
    {
        public Edit_Book_Form()
        {
            InitializeComponent();

            Name_TB.Text = Variables.B_Name;
            Author_TB.Text = Variables.B_Author;
            Publisher_TB.Text = Variables.B_Publisher;
            Genre_TB.Text = Variables.B_Genre;
            Year_TB.Text = Variables.B_Year.ToString();
            Quantity_TB.Text = Variables.B_Quantity.ToString() ;

        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            string Name = Name_TB.Text;
            string Author = Author_TB.Text;
            string Publisher = Publisher_TB.Text;
            string Genre = Genre_TB.Text;
            int Year = int.Parse(Year_TB.Text);
            int Quantity = int.Parse(Quantity_TB.Text);
            int ID = Variables.B_ID;

            DB.UpdateEntry("s", Name, Author, Publisher, Genre, Year, Quantity, ID);
     
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
