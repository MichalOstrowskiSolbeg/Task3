-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2022-11-24 18:48:07.864

-- tables
-- Table: Employee
CREATE TABLE Employee (
    ID int  NOT NULL IDENTITY,
    FirstName varchar(50)  NOT NULL,
    LastName varchar(50)  NOT NULL,
    CONSTRAINT Employee_pk PRIMARY KEY  (ID)
);

-- Table: Item
CREATE TABLE Item (
    ID int  NOT NULL IDENTITY,
    Name varchar(50)  NOT NULL,
    CONSTRAINT Item_pk PRIMARY KEY  (ID)
);

-- Table: Reservation
CREATE TABLE Reservation (
    ID int  NOT NULL IDENTITY,
    Employee_ID int  NOT NULL,
    Workplace_ID int  NOT NULL,
    DateFrom date  NOT NULL,
    DateTo date  NOT NULL,
    WhenMade datetime  NOT NULL,
    CONSTRAINT Reservation_pk PRIMARY KEY  (ID)
);

-- Table: Workplace
CREATE TABLE Workplace (
    ID int  NOT NULL IDENTITY,
    Description varchar(50)  NOT NULL,
    Floor int  NOT NULL,
    CONSTRAINT Workplace_pk PRIMARY KEY  (ID)
);

-- Table: Workplace_Item
CREATE TABLE Workplace_Item (
    Item_ID int  NOT NULL,
    Workplace_ID int  NOT NULL,
    Count int  NOT NULL,
    CONSTRAINT Workplace_Item_pk PRIMARY KEY  (Item_ID,Workplace_ID)
);

-- foreign keys
-- Reference: Reservation_Employee (table: Reservation)
ALTER TABLE Reservation ADD CONSTRAINT Reservation_Employee
    FOREIGN KEY (Employee_ID)
    REFERENCES Employee (ID);

-- Reference: Reservation_Workplace (table: Reservation)
ALTER TABLE Reservation ADD CONSTRAINT Reservation_Workplace
    FOREIGN KEY (Workplace_ID)
    REFERENCES Workplace (ID);

-- Reference: Table_4_Item (table: Workplace_Item)
ALTER TABLE Workplace_Item ADD CONSTRAINT Table_4_Item
    FOREIGN KEY (Item_ID)
    REFERENCES Item (ID);

-- Reference: Table_4_Workplace (table: Workplace_Item)
ALTER TABLE Workplace_Item ADD CONSTRAINT Table_4_Workplace
    FOREIGN KEY (Workplace_ID)
    REFERENCES Workplace (ID);

-- End of file.

