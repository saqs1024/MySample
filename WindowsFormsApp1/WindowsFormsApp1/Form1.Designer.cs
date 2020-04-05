namespace WindowsFormsApp1
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Lblemail = new System.Windows.Forms.Label();
            this.txtCELL = new System.Windows.Forms.TextBox();
            this.Cell = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(292, 33);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(35, 13);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "Name";
            this.lblfirstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(384, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(384, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // Lblemail
            // 
            this.Lblemail.AutoSize = true;
            this.Lblemail.Location = new System.Drawing.Point(292, 134);
            this.Lblemail.Name = "Lblemail";
            this.Lblemail.Size = new System.Drawing.Size(32, 13);
            this.Lblemail.TabIndex = 3;
            this.Lblemail.Text = "Email";
            // 
            // txtCELL
            // 
            this.txtCELL.Location = new System.Drawing.Point(384, 209);
            this.txtCELL.Name = "txtCELL";
            this.txtCELL.Size = new System.Drawing.Size(100, 20);
            this.txtCELL.TabIndex = 4;
            // 
            // Cell
            // 
            this.Cell.AutoSize = true;
            this.Cell.Location = new System.Drawing.Point(292, 212);
            this.Cell.Name = "Cell";
            this.Cell.Size = new System.Drawing.Size(33, 13);
            this.Cell.TabIndex = 6;
            this.Cell.Text = "CELL";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(292, 276);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(36, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "D-O-B";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(384, 270);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 8;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(373, 345);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.Cell);
            this.Controls.Add(this.txtCELL);
            this.Controls.Add(this.Lblemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblfirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Lblemail;
        private System.Windows.Forms.TextBox txtCELL;
        private System.Windows.Forms.Label Cell;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnsubmit;
    }
}