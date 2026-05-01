namespace greed
{
    public partial class Manage_Volunteers : TableManagementForm
    {
        public Manage_Volunteers()
            : base(
                "Volunteer Management",
                "Volunteer",
                "V_national_ID",
                new[]
                {
                    new FieldDefinition("V_national_ID", "National ID"),
                    new FieldDefinition("V_name", "Full Name", FieldKind.Text, true),
                    new FieldDefinition("V_mobile_number", "Mobile Number", FieldKind.Text, true),
                    new FieldDefinition("V_fname", "First Name", FieldKind.Text, true),
                    new FieldDefinition("V_mname", "Middle Name", FieldKind.Text, true),
                    new FieldDefinition("V_lname", "Last Name", FieldKind.Text, true)
                })
        {
        }
    }
}
