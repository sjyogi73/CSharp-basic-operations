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

namespace dbconnection_13
{
    public partial class Form1 : Form
    {
        bool ErrSts = false;
        DataTable dt = new DataTable();
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\22pca004 C# lab\MCA_C-_Lab\StudentsDB.mdb";
        public Form1()
        {
            InitializeComponent();
            // Add an update button column
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "EDIT",
                Text = "EDIT",
                UseColumnTextForButtonValue = true
            };
            dataGridViewDetails.Columns.Add(updateButtonColumn);

            // Add a delete button column
            //DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            //{
            //    HeaderText = "Delete",
            //    Text = "Delete",
            //    UseColumnTextForButtonValue = true
            //};
            //dataGridViewDetails.Columns.Add(deleteButtonColumn);
            //this.BackgroundImage = Image.FromFile(@"D:\22pca004 C# lab\MCA_C-_Lab\Lab Programs\dbconnection_13\Resourses\srmvcaslogo.png");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxrollno.Text == "")
                {
                    addstatus("Please Enter Roll No...");
                    return;
                }
                if (textBoxname.Text == "")
                {
                    addstatus("Please Enter Name...");
                    return;
                }
                if (textBoxage.Text == "")
                {
                    addstatus("Please Enter age...");
                    return;
                }
                if (radioButtonmale.Checked)
                {
                    students.gender = "Male";
                }
                else if (radioButtonfemale.Checked)
                {
                    students.gender = "Female";
                }
                if (comboBoxcourse.SelectedIndex >= 0 && comboBoxcourse.Text == "Select")
                {
                    addstatus("Please Select Course...");
                    return;
                }
                if (comboBoxsemester.SelectedIndex >= 0 && comboBoxsemester.Text == "Select")
                {
                    addstatus("Please Select Semester...");
                    return;
                }
                if (comboBoxyear.SelectedIndex >= 0 && comboBoxyear.Text == "Select")
                {
                    addstatus("Please Select Year...");
                    return;
                }
                else
                {
                    students.name = textBoxname.Text.ToString();
                    students.rollno = textBoxrollno.Text.ToString();
                    students.age = textBoxage.Text.ToString();
                    students.course = comboBoxcourse.Text.ToString();
                    students.semester = comboBoxsemester.Text.ToString();
                    students.year = comboBoxyear.Text.ToString();

                    using (OleDbConnection con = new OleDbConnection(connstring))
                    {
                        con.Open();
                        string sql = "INSERT INTO StudentDetails ([rollno], [name], [course], [gender], [age], [year], [semester]) VALUES (?, ?, ?, ?, ?, ?, ?)";
                        using (OleDbCommand cmd = new OleDbCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@rollno", students.rollno);
                            cmd.Parameters.AddWithValue("@name", students.name);
                            cmd.Parameters.AddWithValue("@course", students.course);
                            cmd.Parameters.AddWithValue("@gender", students.gender);
                            cmd.Parameters.AddWithValue("@age", students.age);
                            cmd.Parameters.AddWithValue("@year", students.year);
                            cmd.Parameters.AddWithValue("@semester", students.semester);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    loaddata();
                    MessageBox.Show(" Saved Success fully ");
                    //cal clear method to clear all the textbox value in the main document
                }
                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }

        }
        public void addstatus(string Mess)
        {
            MessageBox.Show(Mess);
        }
        public void clear()
        {
            try
            {
                textBoxrollno.Text = "";
                textBoxname.Text = "";
                textBoxage.Text = "";
                radioButtonmale.Checked = true;
                radioButtonfemale.Checked = false;
                comboBoxcourse.Text = "Select";
                comboBoxsemester.Text = "Select";
                comboBoxyear.Text = "Select";
                buttonSave.Enabled = true;
                buttonupdate.Enabled = false;
                buttonDelete.Enabled = false;
                students.rollno = "";
                students.name = "";
                students.gender = "";
                students.age = "";
                students.year = "";
                students.course = "";
                students.semester = "";
                loaddata();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            loaddata();
            clear();
        }
        private void loaddata()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    con.Open();
                    string sql = "SELECT * FROM StudentDetails";
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewDetails.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void dataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            // Check if the user clicked on a button or a hyperlink column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming your delete button/hyperlink is in column index 7 (adjust as needed)
                if (dataGridViewDetails.Columns[e.ColumnIndex] is DataGridViewButtonColumn || dataGridViewDetails.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    // Get the data from the clicked row
                    DataGridViewRow clickedRow = dataGridViewDetails.Rows[e.RowIndex];
                    students.rollno = Convert.ToInt32(clickedRow.Cells["rollno"].Value).ToString(); // Assuming "rollno" is the column name with the unique identifier
                    textBoxrollno.Text = students.rollno;
                    textBoxname.Text = clickedRow.Cells["name"].Value.ToString();
                    textBoxage.Text = (clickedRow.Cells["age"].Value).ToString();
                    if ((clickedRow.Cells["gender"].Value).ToString() == "Male")
                        radioButtonmale.Checked = true;
                    else
                        radioButtonmale.Checked = false;
                    comboBoxcourse.Text = (clickedRow.Cells["course"].Value).ToString();
                    comboBoxsemester.Text =(clickedRow.Cells["semester"].Value).ToString();
                    comboBoxyear.Text = (clickedRow.Cells["year"].Value).ToString();


                        buttonSave.Enabled = false;
                        buttonupdate.Enabled = true;
                        buttonDelete.Enabled = true;
                    }
            }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        
    }

        // Implement the Delete method to delete a student from the database
        private void DeleteStudent()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    con.Open();
                    string sql = "DELETE FROM StudentDetails WHERE rollno = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@rollno", students.rollno);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        // Implement the Update method to update a student's information in the database
        private void UpdateStudent()
        {
            try
            {
                if (textBoxname.Text == "")
                {
                    addstatus("Please Enter Name...");
                    return;
                }
                if (textBoxage.Text == "")
                {
                    addstatus("Please Enter age...");
                    return;
                }
                if (radioButtonmale.Checked)
                {
                    students.gender = "Male";
                }
                else if (radioButtonfemale.Checked)
                {
                    students.gender = "Female";
                }
                if (comboBoxcourse.SelectedIndex >= 0 && comboBoxcourse.Text == "Select")
                {
                    addstatus("Please Select Course...");
                    return;
                }
                if (comboBoxsemester.SelectedIndex >= 0 && comboBoxsemester.Text == "Select")
                {
                    addstatus("Please Select Semester...");
                    return;
                }
                if (comboBoxyear.SelectedIndex >= 0 && comboBoxyear.Text == "Select")
                {
                    addstatus("Please Select Year...");
                    return;
                }
                else
                {
                    students.name = textBoxname.Text.ToString();
                    students.age = textBoxage.Text.ToString();
                    students.course = comboBoxcourse.Text.ToString();
                    students.semester = comboBoxsemester.Text.ToString();
                    students.year = comboBoxyear.Text.ToString();

                    using (OleDbConnection con = new OleDbConnection(connstring))
                    {
                        con.Open();
                        string sql = "UPDATE StudentDetails SET [name] = ?, [course] = ?, [gender] = ?, [age] = ?, [year] = ?, [semester] = ? WHERE [rollno] = ?";
                        using (OleDbCommand cmd = new OleDbCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@name", students.name);
                            cmd.Parameters.AddWithValue("@course", students.course);
                            cmd.Parameters.AddWithValue("@gender", students.gender);
                            cmd.Parameters.AddWithValue("@age", students.age);
                            cmd.Parameters.AddWithValue("@year", students.year);
                            cmd.Parameters.AddWithValue("@semester", students.semester);
                            cmd.Parameters.AddWithValue("@rollno", students.rollno); // Use students.rollno, not rollNo

                            cmd.ExecuteNonQuery();
                        }
                    }
                    clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteStudent();
            loaddata();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            loaddata();
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            clear();
            loaddata();
        }
    }
}
