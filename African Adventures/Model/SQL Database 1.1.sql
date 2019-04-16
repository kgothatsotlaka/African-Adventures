CREATE DATABASE INF
GO

USE INF
GO

--Title
CREATE TABLE Title
(TitleID  int identity (1,1) primary key not null,
TitleDescription varchar (50)
)
SET IDENTITY_INSERT Title ON
GO

INSERT INTO Title (TitleID,TitleDescription) VALUES ('','')
SET IDENTITY_INSERT Title OFF
GO

--User_Role_Description
CREATE TABLE User_Role_Description
( UserRoleDescriptionID int identity (1,1) primary key,
UserRoleDescriptionName varchar (50) not null
) 

SET IDENTITY_INSERT User_Role_Description ON
GO
INSERT INTO User_Role_Description (UserRoleDescriptionID,UserRoleDescriptionName) VALUES ('','')
SET IDENTITY_INSERT User_Role_Description OFF
GO
--Employee_Type
CREATE TABLE Employee_Type
(EmployeeTypeID int identity (1,1) primary key not null,
  EmployeeJobDescription varchar (100) not null
)
SET IDENTITY_INSERT Employee_Type ON
GO
INSERT INTO Employee_Type (EmployeeTypeID,EmployeeJobDescription) VALUES ('','')
SET IDENTITY_INSERT Employee_Type OFF
GO
--Gender
CREATE TABLE Gender
( GenderID int identity (1,1) primary key not null,
  GenderType varchar (20) 
)
SET IDENTITY_INSERT Gender ON
GO
INSERT INTO Gender (GenderID,GenderType) VALUES ('','')
SET IDENTITY_INSERT Gender OFF
GO

--Nationality
CREATE TABLE Nationality
(NationalityID int identity (1,1) primary key not null,
  NationalityName varchar (225) 
)
SET IDENTITY_INSERT Nationality ON
GO
INSERT INTO Nationality (NationalityID,NationalityName) VALUES ('','')
SET IDENTITY_INSERT Nationality OFF
GO

--Employee
CREATE TABLE Employee
( EmployeeID  int identity primary key not null,
  EmployeeName varchar (50) ,
  EmployeeSurname varchar (50),
  EmployeeIDNumber char (13) ,
  EmployeeEmail varchar (255),
  EmployeeCellNumber char (10) ,
  EmployeeAddress varchar (255),
  NextOfKinName varchar (50) ,
  NextOfKinNumber char (10),
EmployeeTypeID int references Employee_Type(EmployeeTypeID),
GenderID int references Gender(GenderID),
NationalityID int references Nationality(NationalityID),
TitleID  int references Title(TitleID)
)
SET IDENTITY_INSERT Employee ON
GO
INSERT INTO Employee(EmployeeID,EmployeeName,EmployeeSurname,EmployeeIDNumber,EmployeeEmail,EmployeeCellNumber,EmployeeAddress,NextOfKinName,NextOfKinNumber,EmployeeTypeID,GenderID,NationalityID,TitleID) 
VALUES ('','','','','','','','','','','','','')
SET IDENTITY_INSERT Employee OFF
GO


--Users,
CREATE TABLE Users
(UserID int identity(1,1) primary key not null,
 UserName varchar (50) not null,
 UserPassword varchar (10),
 EmployeeID int references Employee(EmployeeID)
)
SET IDENTITY_INSERT Users ON
GO
INSERT INTO Users (UserID,UserName,UserPassword,EmployeeID) VALUES ('','','','')
SET IDENTITY_INSERT Users OFF
GO

--Active_Users
CREATE TABLE Active_Users
(ActiveUsersID int not null,
UserID int not null,
LogInTimeAndDate datetime not null,
Primary key (ActiveUsersID,UserID),
Foreign key (UserID) References Users(UserID)
)
--SET IDENTITY_INSERT Active_Users ON
--GO
INSERT INTO Active_Users (ActiveUsersID,UserID,LogInTimeAndDate) VALUES ('','','')
--SET IDENTITY_INSERT Active_Users OFF
--GO

--UserAccess
CREATE TABLE UserAccess
( UserRoleDescriptionID int not null,
UserID int not null
CONSTRAINT PK_UserAccess primary key
( UserRoleDescriptionID,
UserID
),
FOREIGN KEY (UserRoleDescriptionID) REFERENCES User_Role_Description (UserRoleDescriptionID),
FOREIGN KEY (UserID) REFERENCES Users (UserID)
)
INSERT INTO UserAccess (UserRoleDescriptionID,UserID) VALUES ('','');



--City
CREATE TABLE City
( CityID  int identity (1,1) primary key not null,
CityName varchar (255) not null,
ProvinceID int
)
SET IDENTITY_INSERT City ON
GO
INSERT INTO City (CityID,CityName,ProvinceID) VALUES ('','','')
SET IDENTITY_INSERT City OFF
GO
--Province
CREATE TABLE Province
(ProvinceID int identity (1,1) primary key not null,
 ProvinceName varchar (255) not null
)
SET IDENTITY_INSERT Province ON
GO
INSERT INTO Province(ProvinceID,ProvinceName) VALUES ('','')
SET IDENTITY_INSERT Province OFF
GO
--Suburb
CREATE TABLE Suburb
(SuburbID int identity (1,1) primary key not null,
SuburbName varchar (255) not null,
SuburdZipCode char (4),
CityID int references City (CityID)
)
SET IDENTITY_INSERT Suburb ON
GO
INSERT INTO Suburb (SuburbID,SuburbName,SuburdZipCode,CityID) VALUES ('','','','')
SET IDENTITY_INSERT Suburb OFF
GO

--Client
CREATE TABLE Client
( ClientID int identity (1,1) primary key not null,
ClientName varchar (50) not null,
ClientSurname varchar (50) not null,
ClientCellNumber char (10) not null,
ClientEmail varchar(255),
ClientAddress varchar (255) not null,
NationalityID int references Nationality(NationalityID),
GenderID int references Gender(GenderID),
SuburbID int references Suburb(SuburbID),
TitleID int references Title(TitleID)
)
SET IDENTITY_INSERT Client ON
GO
INSERT INTO Client(ClientID,ClientName,ClientSurname,ClientCellNumber,ClientEmail,ClientAddress,NationalityID,GenderID,SuburbID,TitleID)
 VALUES ('','','','','','','','','','')
 SET IDENTITY_INSERT Client OFF
GO


--Quotation
CREATE TABLE Quotation
( QuoteID int identity (1,1) primary key not null,
   QuoteDateAndTime datetime,
   QuoteStatus  varchar (50),
   ClientID int references Client (ClientID),
)
 SET IDENTITY_INSERT Quotation ON
GO
INSERT INTO Quotation (QuoteID,QuoteDateAndTime,QuoteStatus,ClientID) VALUES ('','','','')
SET IDENTITY_INSERT Quotation OFF
GO
--Client_Quotation
CREATE TABLE Client_Quotation
( QuoteID int not null,
ClientID int not null
CONSTRAINT PK_Client_Quotation primary key
(QuoteID,
ClientID
),
FOREIGN KEY (QuoteID) REFERENCES Quotation (QuoteID),
FOREIGN KEY (ClientID) REFERENCES Client (ClientID)
)
INSERT INTO Client_Quotation (QuoteID,ClientID) VALUES ('','');

--Payment
CREATE TABLE Payment
(PaymentID int identity (1,1) primary key not null,
   PaymentAmount int not null,
   PaymentDateAndTime datetime,
   PaymentStatus varchar (50),
   QuoteID int references Quotation (QuoteID)
)
INSERT INTO Payment (PaymentAmount,PaymentDateAndTime,PaymentStatus,QuoteID) VALUES ('','','','')

--Booking_Type
CREATE TABLE Booking_Type
( BookingTypeID int identity (1,1) primary key not null,
   BookingTypeDescription varchar (50),
)
SET IDENTITY_INSERT Booking_Type ON
GO
INSERT INTO Booking_Type (BookingTypeID,BookingTypeDescription) VALUES ('','')
SET IDENTITY_INSERT Booking_Type OFF
GO

--Product_Type
CREATE TABLE Product_Type
(ProductTypeID int identity (1,1) primary key not null,
 ProductTypeDescription varchar (255) 
)
SET IDENTITY_INSERT Product_Type ON
GO
INSERT INTO Product_Type (ProductTypeID,ProductTypeDescription) VALUES ('','')
SET IDENTITY_INSERT Product_Type OFF
GO

--Product
CREATE TABLE Product
(ProductID int identity (1,1) primary key not null,
ProductName varchar (50),
ProductQuantity int,
ProductTypeID int references Product_Type(ProductTypeID),
)
SET IDENTITY_INSERT Product ON
GO
INSERT INTO Product (ProductID,ProductName,ProductQuantity,ProductTypeID) VALUES ('','','','')
SET IDENTITY_INSERT Product OFF
GO

--Booking
CREATE TABLE Booking
( BookingID int identity (1,1) primary key not null,
 BookingTypeID int references Booking_Type (BookingTypeID) , 
  ClientID int references Client (ClientID),
  BookingStatus varchar(50),
  ProductID int references Product(ProductID)
)
SET IDENTITY_INSERT Booking ON
GO
INSERT INTO Booking (BookingID,BookingTypeID,ClientID,BookingStatus,ProductID) VALUES ('','','','','')
SET IDENTITY_INSERT Booking OFF
GO

--Booking_Quotation
CREATE TABLE Booking_Quotation
( QuoteID int not null,
BookingID int not null
CONSTRAINT PK_Booking_Quotation primary key
(QuoteID,
BookingID
),
FOREIGN KEY (QuoteID) REFERENCES Quotation (QuoteID),
FOREIGN KEY (BookingID) REFERENCES Client (ClientID)
)
INSERT INTO Booking_Quotation (QuoteID,BookingID) VALUES ('','');


--Refund
CREATE TABLE Refund
(RefundID int identity (1,1) primary key not null,
RefundDescription varchar (255)
)
INSERT INTO Refund (RefundDescription) VALUES ('')

--Sale
CREATE TABLE Sale
(PerSaleID int identity (1,1) primary key not null,
  PerSaleAmount int not null,
  PerSaleDateAndTime datetime not null
)
SET IDENTITY_INSERT Sale ON
GO
INSERT INTO Sale (PerSaleID,PerSaleAmount,PerSaleDateAndTime) VALUES ('','','')
SET IDENTITY_INSERT Sale OFF
GO

--Total_Sales
CREATE TABLE Total_Sales
(TotalSalesID int,
  PerSaleID int
 primary key (TotalSalesID,PerSaleID),
 Foreign key (PerSaleID) References Sale (PerSaleID)
 )
 INSERT INTO Total_Sales (TotalSalesID,PerSaleID)VALUES ('','')

 --Sale_Line
 CREATE TABLE Sale_Line
 (PerSaleID int not null,
 BookingID int not null
 CONSTRAINT PK_Sale_Line primary key
(PerSaleID,
 BookingID
 ),
FOREIGN KEY (PerSaleID) REFERENCES Sale (PerSaleID),
FOREIGN KEY (BookingID) REFERENCES Booking (BookingID)
)
INSERT INTO Sale_Line (PerSaleID,BookingID) VALUES ('','');

--Dimensions
CREATE TABLE Dimensions
(DimensionsID int identity (1,1) primary key not null,
 DimensionSize int
)
SET IDENTITY_INSERT Dimensions ON
GO
INSERT INTO Dimensions (DimensionsID,DimensionSize) VALUES ('','')
SET IDENTITY_INSERT Dimensions OFF
GO

--Product_Price
CREATE TABLE Product_Price
(PriceID int identity (1,1) primary key not null,
   ProductPriceDateAndTime datetime,
   ProductID int references Product (ProductID),
   DimensionsID int references Dimensions(DimensionsID)
)
SET IDENTITY_INSERT Product_Price ON
GO
INSERT INTO Product_Price (PriceID,ProductPriceDateAndTime,ProductID,DimensionsID) VALUES ('','','','')
SET IDENTITY_INSERT Product_Price OFF
GO

--Dimension_Product
CREATE TABLE Dimension_Product
( ProductID int not null,
DimensionsID int not null,
PriceID int not null
CONSTRAINT PK_Dimension_Product primary key      
(ProductID,
DimensionsID  
),    
FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
FOREIGN KEY (DimensionsID) REFERENCES Dimensions (DimensionsID),
)
--SET IDENTITY_INSERT Dimension_Product ON
--GO
INSERT INTO Dimension_Product (ProductID,DimensionsID,PriceID) VALUES ('','','');
--SET IDENTITY_INSERT Dimension_Product OFF
--GO

--Audit_Trail
CREATE TABLE Audit_Trail
(AuditTrailID int identity  primary key not null,
  AuditTrailDateAndTime datetime,
  AuditTrailDescription varchar (255),
 UserID int references Users(UserID)
)
INSERT INTO Audit_Trail (AuditTrailDateAndTime,AuditTrailDescription) VALUES ('','')