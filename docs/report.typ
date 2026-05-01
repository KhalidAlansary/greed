= CharityConnect Project Report

== Project Theme

CharityConnect is a charity operations management application. It helps a small charity track events, donations, beneficiaries, volunteers, and employees using a Windows Forms interface backed by a SQL Server relational database.

== Database Architecture

The database script is located at `src/greed/Database/charity_db.sql`. It defines the charity schema with core entities such as departments, employees, donors, events, items, donations, donation banks, beneficiaries, organizers, volunteers, activities, and relationship tables for event monitors, event volunteers, event organizers, beneficiary needs, donation items, donation recording, event beneficiaries, and funding sources.

Every table in the script includes at least three rows of sample seed data. The data covers realistic charity operations, including food baskets, clothing drives, medical events, donors, staff, volunteers, and people in need.

== Application Forms

The application provides five management forms plus a dashboard for navigation.

#table(
  columns: (1fr, 2fr),
  [*Form*], [*Functionality*],
  [Main Dashboard], [Acts as the central menu. It opens each management form and returns to the same dashboard when a management form is closed.],
  [Event Management], [Displays charity events and supports adding, updating, and deleting event records.],
  [Donation Management], [Displays donation records and supports inserting, updating, and deleting donations linked to donors and items.],
  [Beneficiary Management], [Displays people in need and supports maintaining beneficiary case details.],
  [Volunteer Management], [Displays volunteer records and supports maintaining volunteer identity and contact details.],
  [Employee Management], [Displays employees and supports maintaining staff records, salaries, department links, and supervisors.],
)

== Database Interactions

The management forms retrieve records from SQL Server and display them in data grids. The forms also provide buttons for insert, update, and delete operations. Most forms reuse `TableManagementForm`, which centralizes the select, insert, update, and delete logic for the selected table. Event management has its own form-specific implementation for event fields.

== Navigation Flow

The user starts at the Main Dashboard, chooses one of the management options, completes the required database work, then uses Back to Dashboard to return.

The navigation diagram is stored at `docs/diagrams/form-navigation.mmd`.

```mermaid
flowchart TD
    Dashboard[Main Dashboard]
    Events[Event Management]
    Donations[Donation Management]
    Beneficiaries[Beneficiary Management]
    Volunteers[Volunteer Management]
    Employees[Employee Management]

    Dashboard -->|Manage Events| Events
    Dashboard -->|Process Donations| Donations
    Dashboard -->|Assist Beneficiaries| Beneficiaries
    Dashboard -->|Volunteer Hub| Volunteers
    Dashboard -->|Manage Staff| Employees

    Events -->|Back to Dashboard| Dashboard
    Donations -->|Back to Dashboard| Dashboard
    Beneficiaries -->|Back to Dashboard| Dashboard
    Volunteers -->|Back to Dashboard| Dashboard
    Employees -->|Back to Dashboard| Dashboard
```

== Assignment Coverage

#table(
  columns: (2fr, 1fr, 2fr),
  [*Requirement*], [*Status*], [*Evidence*],
  [Relational database schema], [Complete], [`src/greed/Database/charity_db.sql` contains the `CREATE TABLE` statements.],
  [At least three sample rows per table], [Complete], [`src/greed/Database/charity_db.sql` contains `INSERT INTO` seed data for every table.],
  [At least five distinct forms], [Complete], [Events, Donations, Beneficiaries, Volunteers, and Employees, plus the Main Dashboard.],
  [Seamless form navigation], [Complete], [Dashboard buttons open each form, and Back to Dashboard closes the child form to return to the dashboard.],
  [Select operation], [Complete], [Data grids load records from SQL Server.],
  [Insert operation], [Complete], [Add buttons insert records.],
  [Update operation], [Complete], [Update buttons modify selected records.],
  [Delete operation], [Complete], [Delete buttons remove records by primary key.],
  [SQL script deliverable], [Complete], [`src/greed/Database/charity_db.sql`.],
  [Documentation deliverable], [Complete], [`docs/report.typ` and `docs/diagrams/form-navigation.mmd`.],
)
