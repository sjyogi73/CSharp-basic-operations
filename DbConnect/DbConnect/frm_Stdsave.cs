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

namespace DbConnect
{
    public partial class Form1 : Form
    {
        String Connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCA-19\Desktop\c sharp\db\Student_db_new.mdb";
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCA-19\Desktop\c sharp\db\Student_db_new.mdb");

        public Form1()
        {
          
                InitializeComponent();
         
        }
        public void connection()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Connstring.ToString());
                MessageBox.Show("Connection Sucess");

            }
            catch
            {
                MessageBox.Show("Connection error");
            }

        }
        public void excute()
        {
            try
            {
                conn.Open();
                Random rnd = new Random();
                String sql = "INSERT INTO tbl_std (std_name,std_reg,std_dept,std_age) VALUES  ('" + txt_name.Text + "','" + txt_reg.Text + "','" + txt_dept.Text + "','" + txt_age.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(" Saved Successfully ");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            connection();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            excute();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_reg.Text = "";
            txt_dept.Text = "";
            txt_age.Text = "";
        }
    }
}
