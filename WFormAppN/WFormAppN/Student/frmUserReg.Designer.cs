namespace WFormAppN.Student
{
    partial class frmUserReg
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
            this.Submit = new System.Windows.Forms.Button();
            this.rollno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.cous = new System.Windows.Forms.TextBox();
            this.fathernm = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.ComboBox();
            this.ml = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.ct = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.mob = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(368, 298);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(121, 50);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.submitButton);
            // 
            // rollno
            // 
            this.rollno.Location = new System.Drawing.Point(407, 125);
            this.rollno.Name = "rollno";
            this.rollno.Size = new System.Drawing.Size(100, 20);
            this.rollno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "REGISTRATION FORM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Father Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "City";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(148, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 20);
            this.add.TabIndex = 15;
            // 
            // cous
            // 
            this.cous.Location = new System.Drawing.Point(148, 286);
            this.cous.Multiline = true;
            this.cous.Name = "cous";
            this.cous.Size = new System.Drawing.Size(100, 20);
            this.cous.TabIndex = 16;
            // 
            // fathernm
            // 
            this.fathernm.Location = new System.Drawing.Point(764, 125);
            this.fathernm.Name = "fathernm";
            this.fathernm.Size = new System.Drawing.Size(100, 20);
            this.fathernm.TabIndex = 17;
            this.fathernm.TextChanged += new System.EventHandler(this.fathernm_TextChanged);
            // 
            // st
            // 
            this.st.FormattingEnabled = true;
            this.st.Location = new System.Drawing.Point(148, 232);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(121, 21);
            this.st.TabIndex = 18;
            this.st.SelectedIndexChanged += new System.EventHandler(this.st_SelectedIndexChanged);
            this.st.DropDownClosed += new System.EventHandler(this.st_DropDownClosed);
            // 
            // ml
            // 
            this.ml.AutoSize = true;
            this.ml.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml.Location = new System.Drawing.Point(424, 171);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(65, 26);
            this.ml.TabIndex = 19;
            this.ml.TabStop = true;
            this.ml.Text = "Male";
            this.ml.UseVisualStyleBackColor = true;
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fem.Location = new System.Drawing.Point(539, 171);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(81, 26);
            this.fem.TabIndex = 20;
            this.fem.TabStop = true;
            this.fem.Text = "Female";
            this.fem.UseVisualStyleBackColor = true;
            // 
            // ct
            // 
            this.ct.FormattingEnabled = true;
            this.ct.Location = new System.Drawing.Point(407, 232);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(121, 21);
            this.ct.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(626, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "EmailId";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(626, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "MobileNo";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(764, 229);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 25;
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(764, 171);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(100, 20);
            this.mob.TabIndex = 26;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(-1, 354);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(921, 184);
            this.grid.TabIndex = 27;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(564, 309);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 33);
            this.update.TabIndex = 28;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.updateButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Rollno";
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(148, 131);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(100, 20);
            this.nm.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "State";
            // 
            // frmUserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 543);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.fem);
            this.Controls.Add(this.ml);
            this.Controls.Add(this.st);
            this.Controls.Add(this.fathernm);
            this.Controls.Add(this.cous);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rollno);
            this.Controls.Add(this.Submit);
            this.Name = "frmUserReg";
            this.Text = "frmUserReg";
            this.Load += new System.EventHandler(this.frmUserReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox rollno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.TextBox cous;
        private System.Windows.Forms.TextBox fathernm;
        private System.Windows.Forms.ComboBox st;
        private System.Windows.Forms.RadioButton ml;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.ComboBox ct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}