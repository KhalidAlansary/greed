namespace greed
{
    public partial class Manage_Beneficiaries : TableManagementForm
    {
        public Manage_Beneficiaries()
            : base(
                "Beneficiary Management",
                "Person_in_need",
                "P_national_ID",
                new[]
                {
                    new FieldDefinition("P_national_ID", "National ID"),
                    new FieldDefinition("P_fname", "First Name"),
                    new FieldDefinition("P_mname", "Middle Name"),
                    new FieldDefinition("P_lname", "Last Name"),
                    new FieldDefinition("address", "Address", FieldKind.Text, true),
                    new FieldDefinition("case_description", "Case Description", FieldKind.Text, true)
                })
        {
        }
    }
}
