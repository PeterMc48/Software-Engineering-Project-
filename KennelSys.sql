--KennelSYS.sql
-- Peter McCafferty
--
--This script builds the Kennel System Database

--DROP ALL TABLES BEFORE BUILDING
Drop Table Bookings;
DROP TABLE Kennels;
DROP TABLE Rates;

--CREATE TABLES
PROMPT CREATE TABLE Rates
PROMPT
CREATE TABLE Rates
(Kennel_Type varchar2(4),
 Description varchar2(20) NOT NULL,
 Rate numeric(4,2) NOT NULL CHECK(Rate >0),
 CONSTRAINT pk_Rates PRIMARY KEY (Kennel_Type));

 PROMPT CREATE TABLE Kennels
 PROMPT
 CREATE TABLE Kennels
 (Kennel_ID numeric(2),
 Kennel_Type varchar(4) NOT NULL,
 Status char(1) NOT Null,
 CONSTRAINT pk_Kennels PRIMARY KEY (Kennel_ID),
 CONSTRAINT fk_Kennels_Rates FOREIGN KEY (Kennel_Type) REFERENCES Rates(Kennel_Type)); 

  PROMPT CREATE TABLE Bookings
  PROMPT
  CREATE TABLE Bookings
  (BookingID numeric(8),
  Kennel_ID numeric(8) NOT NULL,
  Arrival_Date date NOT NULL,
  Departure_Date date NOT NULL,
  CustFirstName varchar2(20) NOT NULL,
  CustLastName varchar2(30) NOT NULL,
  PhoneNo varchar2(15) NOT NULL,
  CuatEmail varchar2(50) NOT NULL,
  DogBreed varchar2(20) NOT NULL,
  DogName varchar2(20)NOT NULL,
  Info varchar2(30),
  Cost numeric(5,2)NOT NULL,
  Status varchar(1) NOT NULL,
  CONSTRAINT pk_Bookings PRIMARY KEY (BookingID),
  CONSTRAINT fk_Bookings_Kennel_ID FOREIGN KEY (Kennel_ID) REFERENCES Kennels(Kennel_ID));
