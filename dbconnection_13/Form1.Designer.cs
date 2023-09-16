
namespace dbconnection_13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.textBoxrollno = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.comboBoxcourse = new System.Windows.Forms.ComboBox();
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxsemester = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(71, 329);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(198, 329);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 0;
            this.buttonclear.Text = "CLEAR";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // textBoxrollno
            // 
            this.textBoxrollno.Location = new System.Drawing.Point(180, 27);
            this.textBoxrollno.Name = "textBoxrollno";
            this.textBoxrollno.Size = new System.Drawing.Size(137, 20);
            this.textBoxrollno.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(180, 72);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(137, 20);
            this.textBoxname.TabIndex = 1;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(180, 115);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(137, 20);
            this.textBoxage.TabIndex = 1;
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Location = new System.Drawing.Point(180, 160);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(54, 17);
            this.radioButtonmale.TabIndex = 2;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "MALE";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Location = new System.Drawing.Point(250, 160);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(67, 17);
            this.radioButtonfemale.TabIndex = 2;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "FEMALE";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // comboBoxcourse
            // 
            this.comboBoxcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcourse.FormattingEnabled = true;
            this.comboBoxcourse.Items.AddRange(new object[] {
            "Select",
            "B.sc., Chemistry",
            "B.sc., Physics",
            "B.sc., Maths",
            "B.sc., Computer Science",
            "B.sc., Zoology",
            "B.sc., Botany",
            "B.A., History",
            "B.A., Tamil",
            "B.A., English",
            "B.A., Hindi",
            "M.sc., Chemistry",
            "M.sc., Physics",
            "M.sc., Maths",
            "M.sc., Computer Science",
            "M.sc., Zoology",
            "M.sc., Botany",
            "M.A., History",
            "M.A., Tamil",
            "M.A., English",
            "M.A., Hindi",
            "BCA",
            "MCA",
            "B.com., CA",
            "B.Com., Co"});
            this.comboBoxcourse.Location = new System.Drawing.Point(180, 195);
            this.comboBoxcourse.Name = "comboBoxcourse";
            this.comboBoxcourse.Size = new System.Drawing.Size(137, 21);
            this.comboBoxcourse.TabIndex = 3;
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Items.AddRange(new object[] {
            "Select",
            "1",
            "2",
            "3"});
            this.comboBoxyear.Location = new System.Drawing.Point(180, 239);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(137, 21);
            this.comboBoxyear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ROLL NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "STUDENT NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AGE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "GENDER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "COURSE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "YEAR:";
            // 
            // comboBoxsemester
            // 
            this.comboBoxsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsemester.FormattingEnabled = true;
            this.comboBoxsemester.Items.AddRange(new object[] {
            "Select",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxsemester.Location = new System.Drawing.Point(180, 284);
            this.comboBoxsemester.Name = "comboBoxsemester";
            this.comboBoxsemester.Size = new System.Drawing.Size(137, 21);
            this.comboBoxsemester.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "SEMESTER:";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(348, 27);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(541, 278);
            this.dataGridViewDetails.TabIndex = 5;
            this.dataGridViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetails_CellContentClick);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(735, 329);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 0;
            this.buttonupdate.Text = "UPDATE";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(429, 329);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Location = new System.Drawing.Point(586, 329);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonrefresh.TabIndex = 0;
            this.buttonrefresh.Text = "REFRESH";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 364);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxsemester);
            this.Controls.Add(this.comboBoxyear);
            this.Controls.Add(this.comboBoxcourse);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxrollno);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.TextBox textBoxrollno;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.ComboBox comboBoxcourse;
        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxsemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonrefresh;
    }
}

