-- C:\Users\nguye\OneDrive\Tài liệu\SQL Server Management Studio

/*
-- Tạo database ParkingLotManagement (Có thể gây ra lỗi, nên bỏ qua và tự tạo thử công)
USE master
GO
ALTER DATABASE ParkingLotManagement SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
DROP DATABASE ParkingLotManagement
GO

create database ParkingLotManagement
go




-- Sau khi tạo database ParkingLotManagement, chạy khối code bên dưới 1 LẦN DUY NHẤT
use ParkingLotManagement;

create table Customer ( 
	CustomerID varchar(100), 
	Name varchar(100),
	CitizenNumber varchar(20),
	PhoneNumber varchar(20), 
	Address varchar(100),
	primary key (CustomerID)
)

create table ParkingSpot (
	ParkingSpotID varchar(100), 
	BeingOccupied int, 
	DesignatedFor varchar(50), 
	Capacity int,
	primary key (ParkingSpotID)
)

create table Specialization (
	SpecializationID varchar(100), 
	SpecializationName varchar(100),
	primary key (SpecializationID)
)

create table Employee (
	EmployeeID varchar(100), 
	EmployeeType varchar(100), 
	EmployeeName varchar(100), 
	BirthDay datetime, 
	Gender varchar(20), 
	Address varchar(100), 
	PhoneNumber varchar(20),
	primary key (EmployeeID)
)

create table Contract (
	ContractID varchar(100),
	RentalStartDate datetime, 
	RentalEndDate datetime, 
	RentalDurationInDays int, 
	Price int, 
	PaymentStatus int,
	primary key (ContractID)
)

create table RentalContract (
	ContractID varchar(100),
	Renter varchar(100),
	primary key (ContractID),
	foreign key (ContractID) references Contract(ContractID)
)

create table MaintenanceContract (
	ContractID varchar(100),
	WarrantyDurationInMonths int, 
	primary key (ContractID),
	foreign key (ContractID) references Contract(ContractID)
)


create table Receipt (
	ReceiptID varchar(100), 
	TotalCost int,  
	CustomerID varchar(100), 
	ContractID varchar(100),
	primary key (ReceiptID),
	foreign key (CustomerID) references Customer(CustomerID),
	foreign key (ContractID) references Contract(ContractID)
) 


create table ExcelsIn (
	EmployeeID varchar(100), 
	SpecializationID varchar(100),
	primary key (EmployeeID, SpecializationID),
	foreign key (EmployeeID) references Employee(EmployeeID),
	foreign key (SpecializationID) references Specialization(SpecializationID)
)

create table Job (
	JobID varchar(100), 
	SpecializationID varchar(100), 
	JobName varchar(100),
	JobValue int,
	primary key (JobID),
	foreign key (SpecializationID) references Specialization(SpecializationID)
)

create table WorkSkill (
	EmployeeID varchar(100), 
	JobID varchar(100),
	primary key (EmployeeID, JobID),
	foreign key (EmployeeID) references Employee(EmployeeID),
	foreign key (JobID) references Job(JobID)
)

create table Vehicle (
	VehicleID varchar(100), 
	LicensePlate varchar(20), 
	Occupancy int, 
	TypeOfVehicle varchar(20), 
	CustomerID varchar(100), 
	ParkingSpotID varchar(100),
	primary key (VehicleID),
	foreign key (CustomerID) references Customer(CustomerID),
	foreign key (ParkingSpotID) references ParkingSpot(ParkingSpotID)
)  

create table ContractSigning (
	VehicleID varchar(100), 
	ContractID varchar(100),
	primary key (VehicleID, ContractID),
	foreign key (VehicleID) references Vehicle(VehicleID),
	foreign key (ContractID) references Contract(ContractID)
)

create table ContractDetail (
	ContractID varchar(100), 
	JobID varchar(100), 
	CustomerID varchar(100), 
	Wage DECIMAL(5,2),
	primary key (ContractID, JobID, CustomerID),
	foreign key (ContractID) references Contract(ContractID),
	foreign key (JobID) references Job(JobID),
	foreign key (CustomerID) references Customer(CustomerID)
)

go


-- Inserting data into the Customer table
INSERT INTO Customer (CustomerID, Name, CitizenNumber, PhoneNumber, Address) 
VALUES 
('C001', 'John Doe', 'CN1012345678', '1234567890', '123 Main Street'),
('C002', 'Jane Smith', 'CN2020987654', '0987654321', '456 Broadway Street'),
('C003', 'Robert Johnson', 'CN3031122334', '1122334455', '789 Park Avenue'),
('C004', 'Emily Davis', 'CN4046677889', '6677889900', '321 Elm Street')

-- Inserting data into the ParkingSpot table
INSERT INTO ParkingSpot (ParkingSpotID, BeingOccupied, DesignatedFor, Capacity) 
VALUES 
('PS001', 0, 'Car', 4),
('PS002', 0, 'Car', 4),
('PS003', 0, 'Motorcycle', 1),
('PS004', 0, 'Motorcycle', 1),
('PS005', 0, 'Bicycle', 1),
('PS006', 0, 'Bicycle', 1)

-- MỘT CÔNG VIỆC KHÔNG THỂ NẰM TRONG 2 CHUYÊN NGÀNH
-- Inserting data into the Specialization table
INSERT INTO Specialization (SpecializationID, SpecializationName) 
VALUES 
('S001', 'Paint Coating and Surface Repair'),
('S002', 'Automotive Electronics'),
('S003', 'Motorcycle Electronics'),
('S004', 'Bicycle Maintenance and Repair'),
('S005', 'Customer Service Management'),
('S006', 'Automotive Interior Care'),
('S007', 'Parts Consultation and Retail'),
('S008', 'Internal Combustion Engines')



-- Inserting data into the Employee table
INSERT INTO Employee (EmployeeID, EmployeeType, EmployeeName, BirthDay, Gender, Address, PhoneNumber) 
VALUES 
('E001', 'Worker', 'Alice Smith', '1990-05-15', 'Female', '456 Elm Street', '0987654321'),
('E002', 'Salesperson', 'John Doe', '1985-08-20', 'Male', '123 Oak Avenue', '1234567890'),
('E003', 'Manager', 'Emily Johnson', '1978-12-10', 'Female', '789 Maple Drive', '2345678901'),
('E004', 'Accountant', 'Michael Brown', '1982-03-25', 'Male', '321 Pine Street', '3456789012'),
('E005', 'Technician', 'Saerah Miller', '1992-07-05', 'Female', '567 Birch Lane', '4567890123'),
('E006', 'Customer Service Representative', 'David Wilson', '1993-11-30', 'Male', '901 Cedar Road', '5678901234')


-- Inserting data into the Contract table
INSERT INTO Contract (ContractID, RentalStartDate, RentalEndDate, RentalDurationInDays, Price, PaymentStatus) 
VALUES 
('CN001', '2024-03-01', '2024-03-31', 30, 500, 1),
('CN002', '2024-04-01', '2024-04-30', 30, 550, 1),
('CN003', '2024-05-01', '2024-05-31', 30, 600, 0),
('CN004', '2024-06-01', '2024-06-30', 30, 600, 0)

-- Inserting data into the RentalContract table
INSERT INTO RentalContract (ContractID, Renter) 
VALUES 
('CN001', 'Customer'),
('CN003', 'Company')

-- Inserting data into the MaintenanceContract table
INSERT INTO MaintenanceContract (ContractID, WarrantyDurationInMonths)
VALUES 
('CN002', 3),
('CN004', 5)

-- Inserting data into the Receipt table
INSERT INTO Receipt (ReceiptID, TotalCost, CustomerID, ContractID) 
VALUES 
('R001', 500, 'C001', 'CN001'),
('R002', 550, 'C002', 'CN002'),
('R003', 600, 'C003', 'CN003'),
('R004', 600, 'C004', 'CN004')


-- Inserting data into the ExcelsIn table
INSERT INTO ExcelsIn (EmployeeID, SpecializationID) 
VALUES 
('E001', 'S001'),
('E002', 'S002'),
('E003', 'S005'),
('E004', 'S007'),
('E005', 'S008'),
('E006', 'S005')

-- Inserting data into the Job table
INSERT INTO Job (JobID, SpecializationID, JobName, JobValue) 
VALUES 
('J001', 'S001', 'Automotive Paint Technician', 25),
('J002', 'S001', 'Surface Repair Specialist', 30),
('J003', 'S001', 'Automotive Body Shop Technician', 28),
('J004', 'S001', 'Paint Coating Inspector', 35),
('J005', 'S001', 'Detailing Specialist', 20),

('J006', 'S002', 'Automotive Electronics Technician', 35),
('J007', 'S002', 'Vehicle Diagnostic Technician', 40),
('J008', 'S002', 'Car Audio Installer', 30),
('J009', 'S002', 'Automotive Electrical Engineer', 50),
('J010', 'S002', 'Embedded Systems Engineer', 55),

('J011', 'S003', 'Motorcycle Electronics Technician', 30),
('J012', 'S003', 'Motorcycle Diagnostic Specialist', 35),
('J013', 'S003', 'Motorcycle Electrical Engineer', 45),
('J014', 'S003', 'Motorcycle Audio System Installer', 25),
('J015', 'S003', 'Motorcycle ECU Programmer', 50),

('J016', 'S004', 'Bicycle Mechanic', 20),
('J017', 'S004', 'Bike Repair Technician', 25),
('J018', 'S004', 'Bicycle Assembly Specialist', 18),
('J019', 'S004', 'Bicycle Shop Manager', 40),
('J020', 'S004', 'Mobile Bicycle Repair Service Technician', 30),

('J021', 'S005', 'Customer Service Manager', 45),
('J022', 'S005', 'Client Relations Manager', 50),
('J023', 'S005', 'Customer Support Supervisor', 40),
('J024', 'S005', 'Service Quality Assurance Manager', 55),
('J025', 'S005', 'Customer Experience Strategist', 60),

('J026', 'S006', 'Automotive Interior Detailer', 20),
('J027', 'S006', 'Car Upholstery Technician', 25),
('J028', 'S006', 'Interior Cleaning Specialist', 18),
('J029', 'S006', 'Leather Care Specialist', 22),
('J030', 'S006', 'Automotive Interior Refurbishment Technician', 30),

('J031', 'S007', 'Automotive Parts Consultant', 35),
('J032', 'S007', 'Parts Retail Specialist', 40),
('J033', 'S007', 'Parts Inventory Manager', 50),
('J034', 'S007', 'Parts Sales Representative', 45),
('J035', 'S007', 'Parts Department Supervisor', 55),

('J036', 'S008', 'Automotive Engineer (Internal Combustion Engines)', 60),
('J037', 'S008', 'Engine Performance Technician', 45),
('J038', 'S008', 'Engine Calibration Engineer', 50),
('J039', 'S008', 'Engine Diagnostic Specialist', 40),
('J040', 'S008', 'Engine Rebuild Technician', 55);



-- Inserting data into the WorkSkill table
INSERT INTO WorkSkill (EmployeeID, JobID) 
VALUES
('E001', 'J001'),
('E002', 'J002'),
('E003', 'J003'),
('E004', 'J004'),
('E005', 'J005'),
('E006', 'J006');

-- Inserting data into the Vehicle table
INSERT INTO Vehicle (VehicleID, LicensePlate, Occupancy, TypeOfVehicle, CustomerID, ParkingSpotID) 
VALUES
('V001', 'ABC123', 4, 'Car', 'C001', 'PS001'),
('V002', 'XYZ456', 4, 'Car', 'C002', 'PS002'),
('V003', 'ABR554', 1, 'Motorcycle', 'C003', 'PS003'),
('V004', 'GHJ456', 1, 'Bicycle', 'C004', 'PS004')

-- Inserting data into the ContractSigning table
INSERT INTO ContractSigning (VehicleID, ContractID) 
VALUES 
('V001', 'CN001'),
('V002', 'CN002'),
('V003', 'CN003'),
('V004', 'CN004')

-- Wage will be calculated in the future
-- Inserting data into the ContractDetail table
INSERT INTO ContractDetail (ContractID, JobID, CustomerID) 
VALUES
('CN001', 'J001', 'C001'),
('CN001', 'J002', 'C001'),
('CN002', 'J003', 'C002'),
('CN002', 'J004', 'C002'),
('CN003', 'J005', 'C003'),
('CN003', 'J006', 'C003'),
('CN004', 'J007', 'C004'),
('CN004', 'J008', 'C004'),
('CN004', 'J009', 'C004')
go
*/





use ParkingLotManagement

select *
from ContractDetail

select *
from ContractSigning

select *
from Vehicle







