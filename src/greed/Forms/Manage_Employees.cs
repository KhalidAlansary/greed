namespace greed
{
    public partial class Manage_Employees : TableManagementForm
    {
        public Manage_Employees()
            : base(
                "Employee Management",
                "Employee",
                "E_ID",
                new[]
                {
                    new FieldDefinition("E_ID", "Employee ID", FieldKind.Integer),
                    new FieldDefinition("E_fname", "First Name"),
                    new FieldDefinition("E_mname", "Middle Name"),
                    new FieldDefinition("E_lname", "Last Name"),
                    new FieldDefinition("E_mobile_num", "Mobile Number", FieldKind.Text, true),
                    new FieldDefinition("E_BirthDate", "Birth Date", FieldKind.Date),
                    new FieldDefinition("E_national_ID", "National ID"),
                    new FieldDefinition("Salary", "Salary", FieldKind.Integer, true),
                    new FieldDefinition("department_ID", "Department ID", FieldKind.Integer, true),
                    new FieldDefinition("supervisor_ID", "Supervisor ID", FieldKind.Integer, true)
                })
        {
        }
    }
}
