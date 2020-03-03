namespace PresentationLayer
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
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.txtFemale = new System.Windows.Forms.RadioButton();
            this.txtMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.empEmployeeId = new System.Windows.Forms.Label();
            this.empGender = new System.Windows.Forms.Label();
            this.empState = new System.Windows.Forms.Label();
            this.empCity = new System.Windows.Forms.Label();
            this.empLastName = new System.Windows.Forms.Label();
            this.empMobileNo = new System.Windows.Forms.Label();
            this.empFirstName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // empGrid
            // 
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Location = new System.Drawing.Point(148, 354);
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(622, 150);
            this.empGrid.TabIndex = 39;
            this.empGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtFemale
            // 
            this.txtFemale.AutoSize = true;
            this.txtFemale.Location = new System.Drawing.Point(576, 179);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(59, 17);
            this.txtFemale.TabIndex = 38;
            this.txtFemale.TabStop = true;
            this.txtFemale.Text = "Female";
            this.txtFemale.UseVisualStyleBackColor = true;
            // 
            // txtMale
            // 
            this.txtMale.AutoSize = true;
            this.txtMale.Location = new System.Drawing.Point(444, 179);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(48, 17);
            this.txtMale.TabIndex = 37;
            this.txtMale.TabStop = true;
            this.txtMale.Text = "Male";
            this.txtMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(428, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 36;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(235, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 35;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(235, 172);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNo.TabIndex = 34;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(235, 247);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 33;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(428, 240);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 32;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(659, 114);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 31;
            // 
            // empEmployeeId
            // 
            this.empEmployeeId.AutoSize = true;
            this.empEmployeeId.Location = new System.Drawing.Point(573, 115);
            this.empEmployeeId.Name = "empEmployeeId";
            this.empEmployeeId.Size = new System.Drawing.Size(37, 13);
            this.empEmployeeId.TabIndex = 30;
            this.empEmployeeId.Text = "EmpId";
            // 
            // empGender
            // 
            this.empGender.AutoSize = true;
            this.empGender.Location = new System.Drawing.Point(359, 175);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(42, 13);
            this.empGender.TabIndex = 29;
            this.empGender.Text = "Gender";
            // 
            // empState
            // 
            this.empState.AutoSize = true;
            this.empState.Location = new System.Drawing.Point(161, 247);
            this.empState.Name = "empState";
            this.empState.Size = new System.Drawing.Size(32, 13);
            this.empState.TabIndex = 28;
            this.empState.Text = "State";
            // 
            // empCity
            // 
            this.empCity.AutoSize = true;
            this.empCity.Location = new System.Drawing.Point(359, 247);
            this.empCity.Name = "empCity";
            this.empCity.Size = new System.Drawing.Size(24, 13);
            this.empCity.TabIndex = 27;
            this.empCity.Text = "City";
            // 
            // empLastName
            // 
            this.empLastName.AutoSize = true;
            this.empLastName.Location = new System.Drawing.Point(359, 115);
            this.empLastName.Name = "empLastName";
            this.empLastName.Size = new System.Drawing.Size(55, 13);
            this.empLastName.TabIndex = 26;
            this.empLastName.Text = "LastName";
            // 
            // empMobileNo
            // 
            this.empMobileNo.AutoSize = true;
            this.empMobileNo.Location = new System.Drawing.Point(161, 175);
            this.empMobileNo.Name = "empMobileNo";
            this.empMobileNo.Size = new System.Drawing.Size(52, 13);
            this.empMobileNo.TabIndex = 25;
            this.empMobileNo.Text = "MobileNo";
            // 
            // empFirstName
            // 
            this.empFirstName.AutoSize = true;
            this.empFirstName.Location = new System.Drawing.Point(161, 115);
            this.empFirstName.Name = "empFirstName";
            this.empFirstName.Size = new System.Drawing.Size(54, 13);
            this.empFirstName.TabIndex = 24;
            this.empFirstName.Text = "FirstName";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViewButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 26);
            this.label8.TabIndex = 40;
            this.label8.Text = "Employee Registration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.txtFemale);
            this.Controls.Add(this.txtMale);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.empEmployeeId);
            this.Controls.Add(this.empGender);
            this.Controls.Add(this.empState);
            this.Controls.Add(this.empCity);
            this.Controls.Add(this.empLastName);
            this.Controls.Add(this.empMobileNo);
            this.Controls.Add(this.empFirstName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.RadioButton txtFemale;
        private System.Windows.Forms.RadioButton txtMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label empEmployeeId;
        private System.Windows.Forms.Label empGender;
        private System.Windows.Forms.Label empState;
        private System.Windows.Forms.Label empCity;
        private System.Windows.Forms.Label empLastName;
        private System.Windows.Forms.Label empMobileNo;
        private System.Windows.Forms.Label empFirstName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

