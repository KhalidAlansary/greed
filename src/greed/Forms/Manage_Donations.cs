namespace greed
{
    public partial class Manage_Donations : TableManagementForm
    {
        public Manage_Donations()
            : base(
                "Donation Management",
                "Donation",
                "donation_ID",
                new[]
                {
                    new FieldDefinition("donation_ID", "Donation ID", FieldKind.Integer),
                    new FieldDefinition("donation_date", "Donation Date", FieldKind.Date),
                    new FieldDefinition("donation_quantity", "Quantity", FieldKind.Integer, true),
                    new FieldDefinition("donation_description", "Description", FieldKind.Text, true),
                    new FieldDefinition("D_ID", "Donor ID", FieldKind.Integer, true),
                    new FieldDefinition("Item_ID", "Item ID", FieldKind.Integer, true)
                })
        {
        }
    }
}
