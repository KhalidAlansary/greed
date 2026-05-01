CREATE TABLE Department (
    department_ID   INT PRIMARY KEY NOT NULL,
    Dep_name        VARCHAR(50) NOT NULL
);

CREATE TABLE Employee (
    E_ID            INT PRIMARY KEY NOT NULL,
    E_fname         VARCHAR(50) NOT NULL,
    E_mname         VARCHAR(50) NOT NULL,
    E_lname         VARCHAR(50) NOT NULL,
    E_mobile_num    VARCHAR(20),
    E_BirthDate     DATE,
    E_national_ID   VARCHAR(20) UNIQUE NOT NULL,
    Salary          INT,
    department_ID   INT,
    supervisor_ID   INT,
    FOREIGN KEY (department_ID) REFERENCES Department(department_ID),
    FOREIGN KEY (supervisor_ID) REFERENCES Employee(E_ID)
);

CREATE TABLE Donor (
    D_ID            INT PRIMARY KEY NOT NULL,
    D_fname         VARCHAR(50) NOT NULL,
    D_mname         VARCHAR(50) NOT NULL,
    D_lname         VARCHAR(50) NOT NULL,
    D_mobile_num    VARCHAR(20)
);

CREATE TABLE Event (
    Event_ID        INT PRIMARY KEY NOT NULL,
    event_name      VARCHAR(150) NOT NULL,
    event_description varchar(1000),
    Start_date      DATETIME NOT NULL,
    Finish_date     DATETIME NOT NULL,
    Event_Address   VARCHAR(200),
    Balance         INT DEFAULT 0
);

CREATE TABLE Item (
    Item_ID         INT PRIMARY KEY NOT NULL,
    item_category   VARCHAR(50) NOT NULL,
    item_name       VARCHAR(50) NOT NULL,
    Description     varchar(1000)
);

CREATE TABLE Donation (
    donation_ID         INT PRIMARY KEY NOT NULL,
    donation_date       DATETIME NOT NULL,
    donation_quantity   INT DEFAULT 1,
    donation_description varchar(1000),
    D_ID                INT,
    Item_ID             INT,
    FOREIGN KEY (D_ID) REFERENCES Donor(D_ID),
    FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID)
);

CREATE TABLE Donation_bank (
    Bank_ID         INT PRIMARY KEY NOT NULL,
    Bank_name       VARCHAR(50) NOT NULL,
    Bank_address    VARCHAR(200),
    Contact_number  VARCHAR(20)
);

CREATE TABLE Person_in_need (
    P_national_ID   VARCHAR(20) PRIMARY KEY NOT NULL,
    P_fname         VARCHAR(50) NOT NULL,
    P_mname         VARCHAR(50) NOT NULL,
    P_lname         VARCHAR(50) NOT NULL,
    address         VARCHAR(200),
    case_description varchar(1000)
);

CREATE TABLE Organizer (
    O_ID            INT PRIMARY KEY NOT NULL,
    O_fname         VARCHAR(50) NOT NULL,
    O_mname         VARCHAR(50),
    O_lname         VARCHAR(50),
    O_mobile_number VARCHAR(20),
    E_ID            INT UNIQUE,
    FOREIGN KEY (E_ID) REFERENCES Employee(E_ID) ON DELETE CASCADE
);

CREATE TABLE Volunteer (
    V_national_ID   VARCHAR(20) PRIMARY KEY NOT NULL,
    V_name         VARCHAR(100),
    V_mobile_number VARCHAR(20),
    V_fname         VARCHAR(50),
    V_mname         VARCHAR(50),
    V_lname         VARCHAR(50)
);

CREATE TABLE Activity (
    activity_name   VARCHAR(100) NOT NULL ,
    Event_ID        INT NOT NULL,
    start_date      DATETIME NOT NULL,
    end_date        DATETIME NOT NULL,
    PRIMARY KEY (activity_name, Event_ID),
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE
);

-- Composite attributes

CREATE TABLE department_location (
    department_ID   INT NOT NULL,
    location        VARCHAR(200) NOT NULL,
    PRIMARY KEY (department_ID, location),
    FOREIGN KEY (department_ID) REFERENCES Department(department_ID) ON DELETE CASCADE
);

-- Relationship tables

CREATE TABLE Event_Monitors (
    E_ID      INT NOT NULL,
    Event_ID  INT NOT NULL,
    PRIMARY KEY (E_ID, Event_ID),
    FOREIGN KEY (E_ID) REFERENCES Employee(E_ID) ON DELETE CASCADE,
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE
);

CREATE TABLE Event_Volunteers (
    V_national_ID VARCHAR(20) NOT NULL,
    Event_ID      INT NOT NULL,
    PRIMARY KEY (V_national_ID, Event_ID),
    FOREIGN KEY (V_national_ID) REFERENCES Volunteer(V_national_ID) ON DELETE CASCADE,
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE
);

CREATE TABLE Event_Organizers (
    O_ID       INT NOT NULL,
    Event_ID   INT NOT NULL,
    PRIMARY KEY (O_ID, Event_ID),
    FOREIGN KEY (O_ID) REFERENCES Organizer(O_ID) ON DELETE CASCADE,
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE
);

CREATE TABLE Person_Needs (
    P_national_ID   VARCHAR(20) NOT NULL,
    Item_ID         INT NOT NULL,
    Quantity        INT DEFAULT 1,
    PRIMARY KEY (P_national_ID, Item_ID),
    FOREIGN KEY (P_national_ID) REFERENCES Person_in_need(P_national_ID) ON DELETE CASCADE,
    FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID)
);

CREATE TABLE Donation_Items (
    donation_ID   INT NOT NULL,
    Item_ID    INT NOT NULL,
    Quantity    INT DEFAULT 1,
    PRIMARY KEY (donation_ID, Item_ID),
    FOREIGN KEY (donation_ID) REFERENCES Donation(donation_ID) ON DELETE CASCADE,
    FOREIGN KEY (Item_ID) REFERENCES Item(Item_ID)
);

CREATE TABLE Donation_recording (
    donation_ID   INT NOT NULL,
    E_ID      INT NOT NULL,
    PRIMARY KEY (donation_ID, E_ID),
    FOREIGN KEY (donation_ID) REFERENCES Donation(donation_ID) ON DELETE CASCADE,
    FOREIGN KEY (E_ID) REFERENCES Employee(E_ID) ON DELETE CASCADE
);

CREATE TABLE Event_Beneficiaries (
    P_national_ID      VARCHAR(20) NOT NULL,
    Event_ID           INT NOT NULL,
    PRIMARY KEY (P_national_ID, Event_ID),
    FOREIGN KEY (P_national_ID) REFERENCES Person_in_need(P_national_ID) ON DELETE CASCADE,
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE
);

CREATE TABLE Event_Funding_Sources (
    Event_ID   INT NOT NULL,
    Bank_ID       INT NOT NULL,
    PRIMARY KEY (Event_ID, Bank_ID),
    FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID) ON DELETE CASCADE,
    FOREIGN KEY (Bank_ID) REFERENCES Donation_bank(Bank_ID) ON DELETE CASCADE
);


-- 1. Department
INSERT INTO Department (department_ID, Dep_name) VALUES
(1, 'Administration'),
(2, 'Field Operations'),
(3, 'Finance'),
(4, 'Public Relations');

-- 2. Employee
-- Note: Insert top-level supervisors first to avoid foreign key errors.
INSERT INTO Employee (E_ID, E_fname, E_mname, E_lname, E_mobile_num, E_BirthDate, E_national_ID, Salary, department_ID, supervisor_ID) VALUES
(101, 'Ahmed', 'Ali', 'Hassan', '01012345678', '1980-05-14', '28005140123456', 15000, 1, NULL), -- Does Both (Supervises 102 & 104, Monitors Event 1)
(102, 'Sara', 'Kamal', 'Fahmy', '01123456789', '1985-08-22', '28508220123456', 12000, 2, 101),   -- Supervises (Supervises 103)
(103, 'Omar', 'Tariq', 'Saeed', '01234567890', '1990-11-10', '29011100123456', 9000, 2, 102),    -- Monitors (Monitors Event 2)
(104, 'Mona', 'Ibrahim', 'Adel', '01545678901', '1995-02-05', '29502050123456', 8000, 3, 101);   -- Standard employee

-- 3. Donor
INSERT INTO Donor (D_ID, D_fname, D_mname, D_lname, D_mobile_num) VALUES
(1, 'Khaled', 'Mohamed', 'Nassar', '01099998888'),
(2, 'Laila', 'Hussein', 'Amin', '01188887777'),
(3, 'Youssef', 'Amr', 'Diab', '01277776666');

-- 4. Event
INSERT INTO Event (Event_ID, event_name, event_description, Start_date, Finish_date, Event_Address, Balance) VALUES
(1, 'Winter Clothing Drive', 'Collecting and distributing winter clothes.', '2026-11-01 09:00:00', '2026-11-05 18:00:00', 'Cairo Stadium', 5000),
(2, 'Ramadan Food Baskets', 'Distributing food essentials for the holy month.', '2026-02-15 10:00:00', '2026-02-28 20:00:00', 'Alexandria Sporting Club', 15000),
(3, 'Medical Convoy', 'Free medical checkups and medicine distribution.', '2026-06-10 08:00:00', '2026-06-12 16:00:00', 'Aswan Main Square', 8000);

-- 5. Item
INSERT INTO Item (Item_ID, item_category, item_name, Description) VALUES
(1, 'Clothing', 'Winter Jacket', 'Heavy adult jacket'),
(2, 'Food', 'Rice Sack', '5kg white rice'),
(3, 'Medical', 'First Aid Kit', 'Basic emergency supplies'),
(4, 'Food', 'Cooking Oil', '1 Liter bottle');

-- 6. Donation
INSERT INTO Donation (donation_ID, donation_date, donation_quantity, donation_description, D_ID, Item_ID) VALUES
(1, '2026-01-10 10:30:00', 50, 'Batch of winter jackets', 1, 1),
(2, '2026-01-15 14:00:00', 100, 'Rice for Ramadan', 2, 2),
(3, '2026-02-20 09:15:00', 200, 'Medical kits for the convoy', 3, 3);

-- 7. Donation_bank
INSERT INTO Donation_bank (Bank_ID, Bank_name, Bank_address, Contact_number) VALUES
(1, 'National Bank', '10 Talaat Harb St, Cairo', '19623'),
(2, 'Banque Misr', '15 Saad Zaghloul St, Alex', '19888'),
(3, 'CIB', 'Smart Village, Giza', '19666');

-- 8. Person_in_need
INSERT INTO Person_in_need (P_national_ID, P_fname, P_mname, P_lname, address, case_description) VALUES
('27001010123456', 'Sayed', 'Mahmoud', 'Fouad', 'Shubra, Cairo', 'Requires winter clothing for family of 4'),
('27505050123456', 'Fatma', 'Ali', 'Zayed', 'Mansoura, Dakahlia', 'Needs monthly food supplies'),
('28012120123456', 'Hassan', 'Gaber', 'Nour', 'Luxor, Upper Egypt', 'Requires continuous medical support');

-- 9. Organizer
INSERT INTO Organizer (O_ID, O_fname, O_mname, O_lname, O_mobile_number, E_ID) VALUES
(1, 'Noha', 'Samir', 'Rizk', '01022223333', 104),  -- Linked to Employee 104
(2, 'Tarek', 'Wael', 'Hamed', '01133334444', 102), -- Linked to Employee 102
(3, 'Heba', 'Mostafa', 'Kamal', '01244445555', NULL); -- Only one NULL is allowed


-- 10. Volunteer
INSERT INTO Volunteer (V_national_ID, V_name, V_mobile_number, V_fname, V_mname, V_lname) VALUES
('29801010123456', 'Kareem Tarek Osman', '01055556666', 'Kareem', 'Tarek', 'Osman'),
('29902020123456', 'Salma Ramy Eid', '01166667777', 'Salma', 'Ramy', 'Eid'),
('30003030123456', 'Yasser Nabil Gad', '01277778888', 'Yasser', 'Nabil', 'Gad');

-- 11. Activity
INSERT INTO Activity (activity_name, Event_ID, start_date, end_date) VALUES
('Sorting Clothes', 1, '2026-11-01 09:00:00', '2026-11-02 18:00:00'),
('Packing Baskets', 2, '2026-02-15 10:00:00', '2026-02-20 18:00:00'),
('Pharmacy Setup', 3, '2026-06-10 08:00:00', '2026-06-10 12:00:00');

-- 12. department_location
INSERT INTO department_location (department_ID, location) VALUES
(1, 'Main Headquarters - 5th Settlement'),
(2, 'Logistics Hub - 6th of October'),
(3, 'Main Headquarters - 5th Settlement');

-- 13. Event_Monitors (Satisfying the exact prompt constraints)
INSERT INTO Event_Monitors (E_ID, Event_ID) VALUES
(101, 1), -- Employee 101 monitors (and also supervises)
(103, 2), -- Employee 103 monitors (but does not supervise)
(104, 3);

-- 14. Event_Volunteers
INSERT INTO Event_Volunteers (V_national_ID, Event_ID) VALUES
('29801010123456', 1),
('29902020123456', 2),
('30003030123456', 3),
('29801010123456', 2);

-- 15. Event_Organizers
INSERT INTO Event_Organizers (O_ID, Event_ID) VALUES
(1, 1),
(2, 2),
(3, 3);

-- 16. Person_Needs
INSERT INTO Person_Needs (P_national_ID, Item_ID, Quantity) VALUES
('27001010123456', 1, 4), -- Needs 4 jackets
('27505050123456', 2, 2), -- Needs 2 sacks of rice
('28012120123456', 3, 1); -- Needs 1 first aid kit

-- 17. Donation_Items
INSERT INTO Donation_Items (donation_ID, Item_ID, Quantity) VALUES
(1, 1, 50),
(2, 2, 100),
(3, 3, 200);

-- 18. Donation_recording
INSERT INTO Donation_recording (donation_ID, E_ID) VALUES
(1, 102),
(2, 104),
(3, 103);

-- 19. Event_Beneficiaries
INSERT INTO Event_Beneficiaries (P_national_ID, Event_ID) VALUES
('27001010123456', 1),
('27505050123456', 2),
('28012120123456', 3);

-- 20. Event_Funding_Sources
INSERT INTO Event_Funding_Sources (Event_ID, Bank_ID) VALUES
(1, 1),
(2, 2),
(3, 3);

SELECT * FROM Department;
SELECT * FROM Employee;
SELECT * FROM Donor;
SELECT * FROM Event;
SELECT * FROM Item;
SELECT * FROM Donation;
SELECT * FROM Donation_bank;
SELECT * FROM Person_in_need;
SELECT * FROM Organizer;
SELECT * FROM Volunteer;
SELECT * FROM Activity;
SELECT * FROM department_location;
SELECT * FROM Event_Monitors;
SELECT * FROM Event_Volunteers;
SELECT * FROM Event_Organizers;
SELECT * FROM Person_Needs;
SELECT * FROM Donation_Items;
SELECT * FROM Donation_recording;
SELECT * FROM Event_Beneficiaries;
SELECT * FROM Event_Funding_Sources;
