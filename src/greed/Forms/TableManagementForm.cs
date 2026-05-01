using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace greed
{
    public class TableManagementForm : Form
    {
        private const string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=project;Trusted_Connection=True;";

        private readonly string tableName;
        private readonly string primaryKey;
        private readonly List<FieldDefinition> fields;
        private readonly Dictionary<string, Control> inputControls = new Dictionary<string, Control>();
        private readonly DataGridView dataGrid = new DataGridView();

        public TableManagementForm(string title, string tableName, string primaryKey, IEnumerable<FieldDefinition> fields)
        {
            this.tableName = tableName;
            this.primaryKey = primaryKey;
            this.fields = fields.ToList();

            Text = title;
            ClientSize = new Size(1100, 650);
            StartPosition = FormStartPosition.CenterScreen;

            BuildInterface(title);
            LoadGridData();
        }

        private void BuildInterface(string title)
        {
            Label heading = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 18)
            };

            Button backButton = new Button
            {
                Text = "Back to Dashboard",
                Location = new Point(900, 20),
                Size = new Size(160, 35)
            };
            backButton.Click += (sender, args) => Close();

            dataGrid.Location = new Point(20, 75);
            dataGrid.Size = new Size(1040, 310);
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.MultiSelect = false;
            dataGrid.ReadOnly = true;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.SelectionChanged += DataGrid_SelectionChanged;

            GroupBox detailsBox = new GroupBox
            {
                Text = "Record Details",
                Location = new Point(20, 405),
                Size = new Size(1040, 170)
            };

            for (int i = 0; i < fields.Count; i++)
            {
                FieldDefinition field = fields[i];
                int column = i % 4;
                int row = i / 4;
                int left = 20 + (column * 250);
                int top = 30 + (row * 55);

                Label label = new Label
                {
                    Text = field.Label,
                    Location = new Point(left, top),
                    AutoSize = true
                };

                Control input = field.Kind == FieldKind.Date
                    ? new DateTimePicker { Format = DateTimePickerFormat.Short, Location = new Point(left, top + 20), Size = new Size(210, 23) }
                    : new TextBox { Location = new Point(left, top + 20), Size = new Size(210, 23) };

                detailsBox.Controls.Add(label);
                detailsBox.Controls.Add(input);
                inputControls[field.Name] = input;
            }

            Button addButton = new Button { Text = "Add", Location = new Point(20, 595), Size = new Size(110, 35) };
            Button updateButton = new Button { Text = "Update", Location = new Point(145, 595), Size = new Size(110, 35) };
            Button deleteButton = new Button { Text = "Delete", Location = new Point(270, 595), Size = new Size(110, 35) };
            Button refreshButton = new Button { Text = "Refresh", Location = new Point(395, 595), Size = new Size(110, 35) };

            addButton.Click += (sender, args) => AddRecord();
            updateButton.Click += (sender, args) => UpdateRecord();
            deleteButton.Click += (sender, args) => DeleteRecord();
            refreshButton.Click += (sender, args) => LoadGridData();

            Controls.Add(heading);
            Controls.Add(backButton);
            Controls.Add(dataGrid);
            Controls.Add(detailsBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(refreshButton);
        }

        private void LoadGridData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {tableName}", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecord()
        {
            string columns = string.Join(", ", fields.Select(field => field.Name));
            string parameters = string.Join(", ", fields.Select(field => "@" + field.Name));
            string sql = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";
            ExecuteWrite(sql, fields);
        }

        private void UpdateRecord()
        {
            string assignments = string.Join(", ", fields.Where(field => field.Name != primaryKey).Select(field => field.Name + " = @" + field.Name));
            string sql = $"UPDATE {tableName} SET {assignments} WHERE {primaryKey} = @{primaryKey}";
            ExecuteWrite(sql, fields);
        }

        private void DeleteRecord()
        {
            FieldDefinition keyField = fields.First(field => field.Name == primaryKey);
            string sql = $"DELETE FROM {tableName} WHERE {primaryKey} = @{primaryKey}";
            ExecuteWrite(sql, new[] { keyField });
        }

        private void ExecuteWrite(string sql, IEnumerable<FieldDefinition> commandFields)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    foreach (FieldDefinition field in commandFields)
                    {
                        command.Parameters.AddWithValue("@" + field.Name, GetValue(field));
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetValue(FieldDefinition field)
        {
            Control input = inputControls[field.Name];

            if (field.Kind == FieldKind.Date)
            {
                return ((DateTimePicker)input).Value;
            }

            string value = input.Text.Trim();
            if (string.IsNullOrWhiteSpace(value) && field.AllowNull)
            {
                return DBNull.Value;
            }

            if (field.Kind == FieldKind.Integer)
            {
                if (int.TryParse(value, out int intValue))
                {
                    return intValue;
                }

                throw new InvalidOperationException(field.Label + " must be a whole number.");
            }

            return value;
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null || dataGrid.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row = (DataRowView)dataGrid.CurrentRow.DataBoundItem;
            foreach (FieldDefinition field in fields)
            {
                Control input = inputControls[field.Name];
                object value = row[field.Name];

                if (field.Kind == FieldKind.Date && value != DBNull.Value)
                {
                    ((DateTimePicker)input).Value = Convert.ToDateTime(value);
                }
                else
                {
                    input.Text = value == DBNull.Value ? string.Empty : value.ToString();
                }
            }
        }
    }

    public class FieldDefinition
    {
        public FieldDefinition(string name, string label, FieldKind kind = FieldKind.Text, bool allowNull = false)
        {
            Name = name;
            Label = label;
            Kind = kind;
            AllowNull = allowNull;
        }

        public string Name { get; }
        public string Label { get; }
        public FieldKind Kind { get; }
        public bool AllowNull { get; }
    }

    public enum FieldKind
    {
        Text,
        Integer,
        Date
    }
}
