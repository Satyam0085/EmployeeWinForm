namespace WinFormEmployeeApp
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
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(233, 58);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(75, 22);
            this.txtempid.TabIndex = 0;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(233, 114);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(218, 22);
            this.txtempname.TabIndex = 1;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(233, 165);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(161, 22);
            this.txtcity.TabIndex = 2;
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(108, 58);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(48, 16);
            this.lblempid.TabIndex = 3;
            this.lblempid.Text = "EmpID";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(111, 114);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(72, 16);
            this.lblempname.TabIndex = 4;
            this.lblempname.Text = "EmpName";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(111, 170);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(29, 16);
            this.lblcity.TabIndex = 5;
            this.lblcity.Text = "City";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnsave.Location = new System.Drawing.Point(233, 229);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 37);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnedit.Location = new System.Drawing.Point(347, 229);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 37);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btndelete.Location = new System.Drawing.Point(475, 229);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 37);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}

