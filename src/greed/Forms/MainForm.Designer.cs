namespace greed
{
    partial class MainForm
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
            this.btnManageEvents = new System.Windows.Forms.Button();
            this.btn_Process_Donations = new System.Windows.Forms.Button();
            this.btn_Assist_Beneficiaries = new System.Windows.Forms.Button();
            this.btn_Volunteer_Hub = new System.Windows.Forms.Button();
            this.btn_Manage_Staff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageEvents
            // 
            this.btnManageEvents.Location = new System.Drawing.Point(69, 32);
            this.btnManageEvents.Name = "btnManageEvents";
            this.btnManageEvents.Size = new System.Drawing.Size(143, 49);
            this.btnManageEvents.TabIndex = 1;
            this.btnManageEvents.Text = "Manage Events";
            this.btnManageEvents.UseVisualStyleBackColor = true;
            this.btnManageEvents.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Process_Donations
            // 
            this.btn_Process_Donations.Location = new System.Drawing.Point(280, 83);
            this.btn_Process_Donations.Name = "btn_Process_Donations";
            this.btn_Process_Donations.Size = new System.Drawing.Size(143, 49);
            this.btn_Process_Donations.TabIndex = 2;
            this.btn_Process_Donations.Text = "Process Donations";
            this.btn_Process_Donations.UseVisualStyleBackColor = true;
            this.btn_Process_Donations.Click += new System.EventHandler(this.btn_Process_Donations_Click);
            // 
            // btn_Assist_Beneficiaries
            // 
            this.btn_Assist_Beneficiaries.Location = new System.Drawing.Point(218, 32);
            this.btn_Assist_Beneficiaries.Name = "btn_Assist_Beneficiaries";
            this.btn_Assist_Beneficiaries.Size = new System.Drawing.Size(143, 49);
            this.btn_Assist_Beneficiaries.TabIndex = 3;
            this.btn_Assist_Beneficiaries.Text = "Assist Beneficiaries";
            this.btn_Assist_Beneficiaries.UseVisualStyleBackColor = true;
            this.btn_Assist_Beneficiaries.Click += new System.EventHandler(this.btn_Assist_Beneficiaries_Click);
            // 
            // btn_Volunteer_Hub
            // 
            this.btn_Volunteer_Hub.Location = new System.Drawing.Point(0, 83);
            this.btn_Volunteer_Hub.Name = "btn_Volunteer_Hub";
            this.btn_Volunteer_Hub.Size = new System.Drawing.Size(143, 49);
            this.btn_Volunteer_Hub.TabIndex = 4;
            this.btn_Volunteer_Hub.Text = "Volunteer Hub";
            this.btn_Volunteer_Hub.UseVisualStyleBackColor = true;
            this.btn_Volunteer_Hub.Click += new System.EventHandler(this.btn_Volunteer_Hub_Click);
            // 
            // btn_Manage_Staff
            // 
            this.btn_Manage_Staff.Location = new System.Drawing.Point(140, 83);
            this.btn_Manage_Staff.Name = "btn_Manage_Staff";
            this.btn_Manage_Staff.Size = new System.Drawing.Size(143, 49);
            this.btn_Manage_Staff.TabIndex = 5;
            this.btn_Manage_Staff.Text = "Manage Staff";
            this.btn_Manage_Staff.UseVisualStyleBackColor = true;
            this.btn_Manage_Staff.Click += new System.EventHandler(this.btn_Manage_Staff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to CharityConnect Operations Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.btn_Volunteer_Hub);
            this.groupBox1.Controls.Add(this.btn_Manage_Staff);
            this.groupBox1.Controls.Add(this.btn_Assist_Beneficiaries);
            this.groupBox1.Controls.Add(this.btn_Process_Donations);
            this.groupBox1.Controls.Add(this.btnManageEvents);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(131, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageEvents;
        private System.Windows.Forms.Button btn_Process_Donations;
        private System.Windows.Forms.Button btn_Assist_Beneficiaries;
        private System.Windows.Forms.Button btn_Volunteer_Hub;
        private System.Windows.Forms.Button btn_Manage_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

