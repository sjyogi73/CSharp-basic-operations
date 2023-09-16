using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ofd.Filter = "Access 2000-2003 (*.mdb;)|*.mdb";
            ofd.ShowDialog();
            path = ofd.FileName;
            TextBoxPath.Text = path;
        }

        private void ButtonView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (path != "")
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info = False");
                    OleDbCommand cmd = new OleDbCommand(); string commandtext = "select * from StudentDetails";
                    OleDbDataAdapter da = new OleDbDataAdapter(commandtext, con); System.Data.DataTable dt = new System.Data.DataTable(); da.Fill(dt);
                    dataGridViewDetails.ItemsSource = dt.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
