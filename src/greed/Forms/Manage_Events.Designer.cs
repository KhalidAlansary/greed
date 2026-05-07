namespace DB_phase2
{
    partial class Manage_Events
    {
        private System.ComponentModel.IContainer components = null;

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

     
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.back_dashboard = new System.Windows.Forms.Button();
            this.dgv_Eve = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_description = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_balance = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.labelActivitiesTitle = new System.Windows.Forms.Label();
            this.dgv_Activities = new System.Windows.Forms.DataGridView();
            this.colActName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxActivities = new System.Windows.Forms.GroupBox();
            this.labelActName = new System.Windows.Forms.Label();
            this.text_act_name = new System.Windows.Forms.TextBox();
            this.labelActStart = new System.Windows.Forms.Label();
            this.dtp_act_start = new System.Windows.Forms.DateTimePicker();
            this.labelActEnd = new System.Windows.Forms.Label();
            this.dtp_act_end = new System.Windows.Forms.DateTimePicker();
            this.btn_add_act = new System.Windows.Forms.Button();
            this.btn_delete_act = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eve)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activities)).BeginInit();
            this.groupBoxActivities.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Management";
            // 
            // back_dashboard
            // 
            this.back_dashboard.Location = new System.Drawing.Point(951, 12);
            this.back_dashboard.Name = "back_dashboard";
            this.back_dashboard.Size = new System.Drawing.Size(120, 30);
            this.back_dashboard.TabIndex = 1;
            this.back_dashboard.Text = "Back to Dashboard";
            this.back_dashboard.UseVisualStyleBackColor = true;
            this.back_dashboard.Click += new System.EventHandler(this.back_dashboard_Click);
            // 
            // dgv_Eve
            // 
            this.dgv_Eve.AllowUserToAddRows = false;
            this.dgv_Eve.AllowUserToDeleteRows = false;
            this.dgv_Eve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Eve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Eve.ColumnHeadersHeight = 50;
            this.dgv_Eve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDesc,
            this.colStart,
            this.colFinish,
            this.colAddress,
            this.colBalance});
            this.dgv_Eve.Location = new System.Drawing.Point(18, 46);
            this.dgv_Eve.MultiSelect = false;
            this.dgv_Eve.Name = "dgv_Eve";
            this.dgv_Eve.ReadOnly = true;
            this.dgv_Eve.RowHeadersWidth = 51;
            this.dgv_Eve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Eve.Size = new System.Drawing.Size(1059, 230);
            this.dgv_Eve.TabIndex = 2;
            this.dgv_Eve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Eve_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Event_ID";
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "Event ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "event_name";
            this.colName.FillWeight = 120F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "event_description";
            this.colDesc.FillWeight = 200F;
            this.colDesc.HeaderText = "Description";
            this.colDesc.MinimumWidth = 6;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colStart
            // 
            this.colStart.DataPropertyName = "Start_date";
            this.colStart.HeaderText = "Start";
            this.colStart.MinimumWidth = 6;
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            // 
            // colFinish
            // 
            this.colFinish.DataPropertyName = "Finish_date";
            this.colFinish.HeaderText = "Finish";
            this.colFinish.MinimumWidth = 6;
            this.colFinish.Name = "colFinish";
            this.colFinish.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Event_Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.DataPropertyName = "Balance";
            this.colBalance.HeaderText = "Balance";
            this.colBalance.MinimumWidth = 6;
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text_ID);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.text_description);
            this.groupBox1.Controls.Add(this.text_address);
            this.groupBox1.Controls.Add(this.text_balance);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Location = new System.Drawing.Point(18, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Finish Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Balance:";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(90, 25);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(240, 22);
            this.text_ID.TabIndex = 7;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(90, 55);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(240, 22);
            this.text_name.TabIndex = 8;
            // 
            // text_description
            // 
            this.text_description.Location = new System.Drawing.Point(90, 85);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(240, 65);
            this.text_description.TabIndex = 9;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(440, 85);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(200, 22);
            this.text_address.TabIndex = 10;
            // 
            // text_balance
            // 
            this.text_balance.Location = new System.Drawing.Point(440, 128);
            this.text_balance.Name = "text_balance";
            this.text_balance.Size = new System.Drawing.Size(122, 22);
            this.text_balance.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(440, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(728, 140);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 30);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.Btn_add_click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(953, 140);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 30);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(843, 140);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 30);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // labelActivitiesTitle
            // 
            this.labelActivitiesTitle.AutoSize = true;
            this.labelActivitiesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelActivitiesTitle.Location = new System.Drawing.Point(12, 475);
            this.labelActivitiesTitle.Name = "labelActivitiesTitle";
            this.labelActivitiesTitle.Size = new System.Drawing.Size(101, 28);
            this.labelActivitiesTitle.TabIndex = 6;
            this.labelActivitiesTitle.Text = "Activities";
            // 
            // dgv_Activities
            // 
            this.dgv_Activities.AllowUserToAddRows = false;
            this.dgv_Activities.AllowUserToDeleteRows = false;
            this.dgv_Activities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Activities.ColumnHeadersHeight = 29;
            this.dgv_Activities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActName,
            this.colActEventId,
            this.colActStart,
            this.colActEnd,
            this.Event_ID});
            this.dgv_Activities.Location = new System.Drawing.Point(18, 510);
            this.dgv_Activities.MultiSelect = false;
            this.dgv_Activities.Name = "dgv_Activities";
            this.dgv_Activities.ReadOnly = true;
            this.dgv_Activities.RowHeadersWidth = 51;
            this.dgv_Activities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Activities.Size = new System.Drawing.Size(580, 220);
            this.dgv_Activities.TabIndex = 4;
            this.dgv_Activities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Activities_CellContentClick);
            // 
            // colActName
            // 
            this.colActName.DataPropertyName = "activity_name";
            this.colActName.HeaderText = "Activity Name";
            this.colActName.MinimumWidth = 6;
            this.colActName.Name = "colActName";
            this.colActName.ReadOnly = true;
            // 
            // colActEventId
            // 
            this.colActEventId.DataPropertyName = "Event_ID";
            this.colActEventId.HeaderText = "Event ID";
            this.colActEventId.MinimumWidth = 6;
            this.colActEventId.Name = "colActEventId";
            this.colActEventId.ReadOnly = true;
            this.colActEventId.Visible = false;
            // 
            // colActStart
            // 
            this.colActStart.DataPropertyName = "start_date";
            this.colActStart.HeaderText = "Start Date";
            this.colActStart.MinimumWidth = 6;
            this.colActStart.Name = "colActStart";
            this.colActStart.ReadOnly = true;
            // 
            // colActEnd
            // 
            this.colActEnd.DataPropertyName = "end_date";
            this.colActEnd.HeaderText = "End Date";
            this.colActEnd.MinimumWidth = 6;
            this.colActEnd.Name = "colActEnd";
            this.colActEnd.ReadOnly = true;
            // 
            // Event_ID
            // 
            this.Event_ID.DataPropertyName = "Event_ID";
            this.Event_ID.HeaderText = "Event ID";
            this.Event_ID.MinimumWidth = 6;
            this.Event_ID.Name = "Event_ID";
            this.Event_ID.ReadOnly = true;
            // 
            // groupBoxActivities
            // 
            this.groupBoxActivities.Controls.Add(this.labelActName);
            this.groupBoxActivities.Controls.Add(this.text_act_name);
            this.groupBoxActivities.Controls.Add(this.labelActStart);
            this.groupBoxActivities.Controls.Add(this.dtp_act_start);
            this.groupBoxActivities.Controls.Add(this.labelActEnd);
            this.groupBoxActivities.Controls.Add(this.dtp_act_end);
            this.groupBoxActivities.Controls.Add(this.btn_add_act);
            this.groupBoxActivities.Controls.Add(this.btn_delete_act);
            this.groupBoxActivities.Location = new System.Drawing.Point(620, 510);
            this.groupBoxActivities.Name = "groupBoxActivities";
            this.groupBoxActivities.Size = new System.Drawing.Size(457, 220);
            this.groupBoxActivities.TabIndex = 5;
            this.groupBoxActivities.TabStop = false;
            this.groupBoxActivities.Text = "Manage Activities";
            // 
            // labelActName
            // 
            this.labelActName.AutoSize = true;
            this.labelActName.Location = new System.Drawing.Point(20, 40);
            this.labelActName.Name = "labelActName";
            this.labelActName.Size = new System.Drawing.Size(92, 16);
            this.labelActName.TabIndex = 0;
            this.labelActName.Text = "Activity Name:";
            // 
            // text_act_name
            // 
            this.text_act_name.Location = new System.Drawing.Point(120, 37);
            this.text_act_name.Name = "text_act_name";
            this.text_act_name.Size = new System.Drawing.Size(220, 22);
            this.text_act_name.TabIndex = 1;
            // 
            // labelActStart
            // 
            this.labelActStart.AutoSize = true;
            this.labelActStart.Location = new System.Drawing.Point(20, 80);
            this.labelActStart.Name = "labelActStart";
            this.labelActStart.Size = new System.Drawing.Size(69, 16);
            this.labelActStart.TabIndex = 2;
            this.labelActStart.Text = "Start Date:";
            // 
            // dtp_act_start
            // 
            this.dtp_act_start.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_act_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_act_start.Location = new System.Drawing.Point(120, 77);
            this.dtp_act_start.Name = "dtp_act_start";
            this.dtp_act_start.Size = new System.Drawing.Size(220, 22);
            this.dtp_act_start.TabIndex = 3;
            // 
            // labelActEnd
            // 
            this.labelActEnd.AutoSize = true;
            this.labelActEnd.Location = new System.Drawing.Point(20, 120);
            this.labelActEnd.Name = "labelActEnd";
            this.labelActEnd.Size = new System.Drawing.Size(66, 16);
            this.labelActEnd.TabIndex = 4;
            this.labelActEnd.Text = "End Date:";
            // 
            // dtp_act_end
            // 
            this.dtp_act_end.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_act_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_act_end.Location = new System.Drawing.Point(120, 117);
            this.dtp_act_end.Name = "dtp_act_end";
            this.dtp_act_end.Size = new System.Drawing.Size(220, 22);
            this.dtp_act_end.TabIndex = 5;
            // 
            // btn_add_act
            // 
            this.btn_add_act.Location = new System.Drawing.Point(120, 165);
            this.btn_add_act.Name = "btn_add_act";
            this.btn_add_act.Size = new System.Drawing.Size(100, 30);
            this.btn_add_act.TabIndex = 6;
            this.btn_add_act.Text = "Add Activity";
            this.btn_add_act.UseVisualStyleBackColor = true;
            this.btn_add_act.Click += new System.EventHandler(this.btn_add_act_Click);
            // 
            // btn_delete_act
            // 
            this.btn_delete_act.Location = new System.Drawing.Point(240, 165);
            this.btn_delete_act.Name = "btn_delete_act";
            this.btn_delete_act.Size = new System.Drawing.Size(100, 30);
            this.btn_delete_act.TabIndex = 7;
            this.btn_delete_act.Text = "Delete Activity";
            this.btn_delete_act.UseVisualStyleBackColor = true;
            this.btn_delete_act.Click += new System.EventHandler(this.btn_delete_act_Click);
            // 
            // Manage_Events
            // 
            this.ClientSize = new System.Drawing.Size(1095, 750);
            this.Controls.Add(this.groupBoxActivities);
            this.Controls.Add(this.dgv_Activities);
            this.Controls.Add(this.labelActivitiesTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_dashboard);
            this.Controls.Add(this.dgv_Eve);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manage_Events";
            this.Text = "Manage Events";
            this.Load += new System.EventHandler(this.Manage_Events_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eve)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activities)).EndInit();
            this.groupBoxActivities.ResumeLayout(false);
            this.groupBoxActivities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Eve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button back_dashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_balance;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;

        private System.Windows.Forms.Label labelActivitiesTitle;
        private System.Windows.Forms.DataGridView dgv_Activities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActEventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActEnd;
        private System.Windows.Forms.GroupBox groupBoxActivities;
        private System.Windows.Forms.Label labelActName;
        private System.Windows.Forms.Label labelActStart;
        private System.Windows.Forms.Label labelActEnd;
        private System.Windows.Forms.TextBox text_act_name;
        private System.Windows.Forms.DateTimePicker dtp_act_start;
        private System.Windows.Forms.DateTimePicker dtp_act_end;
        private System.Windows.Forms.Button btn_add_act;
        private System.Windows.Forms.Button btn_delete_act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_ID;
    }
}
