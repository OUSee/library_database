using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lib_database
{
    public partial class MainForm : Form
    {
        public static int TryInt(string input)
        {
            if (int.TryParse(input, out int output)) { return output; }
            else { return 100; }
            
            
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form form = new Add_Book_Form();
            form.ShowDialog();
            refresh_this();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {   
            Variables.B_ID = TryInt(Books_DG.CurrentRow.Cells["ID_C"].Value.ToString());
            Variables.B_Name = Books_DG.CurrentRow.Cells["Name_C"].Value.ToString();
            Variables.B_Author = Books_DG.CurrentRow.Cells["Author_C"].Value.ToString();
            Variables.B_Publisher = Books_DG.CurrentRow.Cells["Publisher_C"].Value.ToString();
            Variables.B_Genre = Books_DG.CurrentRow.Cells["Genre_C"].Value.ToString();
            Variables.B_Year = TryInt(Books_DG.CurrentRow.Cells["Year_C"].Value.ToString());
            Variables.B_Quantity = TryInt(Books_DG.CurrentRow.Cells["Quantity_C"].Value.ToString());

            Form form = new Edit_Book_Form();
            form.ShowDialog();
            refresh_this();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Variables.B_ID = TryInt(Books_DG.CurrentRow.Cells["ID_C"].Value.ToString());
            DB.DeleteEntry();
            refresh_this();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Form form = new Search_Form();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lIB_DBDataSet.NewTable". При необходимости она может быть перемещена или удалена.
            this.newTableTableAdapter.Fill(this.lIB_DBDataSet.NewTable);
            Books_DG.Refresh();
        }
        public void refresh_this()
        {
            this.newTableTableAdapter.Fill(this.lIB_DBDataSet.NewTable);
            Books_DG.Refresh();
        }
        private void Books_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
