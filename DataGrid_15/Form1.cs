using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_15
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (path != "")
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info = False");
                    OleDbCommand cmd = new OleDbCommand(); string commandtext = "select * from StudentDetails";
                    OleDbDataAdapter da = new OleDbDataAdapter(commandtext, con); System.Data.DataTable dt = new System.Data.DataTable(); da.Fill(dt);
                    dataGridViewDetails.DataSource = dt.DefaultView;
                }
            }          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ofd.Filter = "Access 2000-2003 (*.mdb;)|*.mdb"; 
            ofd.ShowDialog();
            path = ofd.FileName; 
            textBoxpath.Text = path;
        }
    }
}
