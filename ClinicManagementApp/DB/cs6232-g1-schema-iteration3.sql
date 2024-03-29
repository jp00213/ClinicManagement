USE [master]
GO
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'cs6232-g1') 
BEGIN
ALTER DATABASE [cs6232-g1] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
DROP DATABASE [cs6232-g1]
END
GO


GO
/****** Object:  Database [cs6232-g1]    Script Date: 4/7/2023 8:48:20 PM ******/
CREATE DATABASE [cs6232-g1]
GO
ALTER DATABASE [cs6232-g1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g1] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g1', N'ON'
GO
ALTER DATABASE [cs6232-g1] SET QUERY_STORE = OFF
GO
USE [cs6232-g1]
GO
/****** Object:  Table [dbo].[account]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[administrator]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administrator](
	[administratorID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[recordID] [int] NOT NULL,
 CONSTRAINT [PK_administrator] PRIMARY KEY CLUSTERED 
(
	[administratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[appointmentDatetime] [datetime] NOT NULL,
	[reason] [varchar](100) NOT NULL,
 CONSTRAINT [PK_appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[recordID] [int] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor_has_specialty]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_has_specialty](
	[doctorID] [int] NOT NULL,
	[specialtyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_doctor_has_specialty] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC,
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nurse]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nurse](
	[nurseID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[recordID] [int] NOT NULL,
	[activeStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_nurse] PRIMARY KEY CLUSTERED 
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[recordID] [int] NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[person]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[recordID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[addressStreet] [varchar](100) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [char](2) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
	[sex] [char](1) NOT NULL,
	[ssn] [char](9) NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialty]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialty](
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_specialty] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[testCode] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_test] PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visit_has_test]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visit_has_test](
	[visitID] [int] NOT NULL,
	[testCode] [int] NOT NULL,
	[testDate] [datetime] NOT NULL,
	[result] [varchar](100) NOT NULL,
	[resultIsNormal] [tinyint] NOT NULL,
 CONSTRAINT [PK_visit_has_test] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC,
	[testCode] ASC,
	[testDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visitRoutineResults]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitRoutineResults](
	[visitID] [int] IDENTITY(1,1) NOT NULL,
	[appointmentID] [int] NOT NULL,
	[nurseID] [int] NOT NULL,
	[visitDatetime] [datetime] NOT NULL,
	[height] [decimal](6, 2) NOT NULL,
	[weight] [decimal](6, 2) NOT NULL,
	[bloodPressureDiastolic] [int] NOT NULL,
	[bloodPressureSystolic] [int] NOT NULL,
	[bodyTemperature] [decimal](6, 1) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](500) NOT NULL,
	[initialDiagnoses] [varchar](500) NOT NULL,
	[finalDiagnoses] [varchar](500) NULL,
 CONSTRAINT [PK_visitRoutineResults] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[account] ([username], [password]) VALUES (N'admin001', N'BDEr9bCKzkeMPeJ9My75h7VpO4a9j811qteQxn+HSN/JQo0KAUvWiroIagyuIsnL50bW3PNax9PuKg8eNBkeIQ==')
INSERT [dbo].[account] ([username], [password]) VALUES (N'admin002', N'MJtYNVNwul6WNW9pkDLIz0uylf02sXLpzbrqqPuTByMXSHPwEcK20LxxcG5WwNAxIGwIdLUfM9kmWgHT50V7Zg==')
INSERT [dbo].[account] ([username], [password]) VALUES (N'admin003', N'iDGlbxyGTdGNu5xAf9AZFXtUVwt6cY9wYxO0NDNUQ/v2QIlR5OK0SNnArxeZ8s4pUcNQv4bQmTZRybESZ7Fu/Q==')
INSERT [dbo].[account] ([username], [password]) VALUES (N'nurse001', N'BDEr9bCKzkeMPeJ9My75h7VpO4a9j811qteQxn+HSN/JQo0KAUvWiroIagyuIsnL50bW3PNax9PuKg8eNBkeIQ==')
INSERT [dbo].[account] ([username], [password]) VALUES (N'nurse002', N'MJtYNVNwul6WNW9pkDLIz0uylf02sXLpzbrqqPuTByMXSHPwEcK20LxxcG5WwNAxIGwIdLUfM9kmWgHT50V7Zg==')
INSERT [dbo].[account] ([username], [password]) VALUES (N'nurse003', N'iDGlbxyGTdGNu5xAf9AZFXtUVwt6cY9wYxO0NDNUQ/v2QIlR5OK0SNnArxeZ8s4pUcNQv4bQmTZRybESZ7Fu/Q==')
GO
SET IDENTITY_INSERT [dbo].[administrator] ON 

INSERT [dbo].[administrator] ([administratorID], [username], [recordID]) VALUES (2, N'admin001', 3)
INSERT [dbo].[administrator] ([administratorID], [username], [recordID]) VALUES (3, N'admin002', 4)
INSERT [dbo].[administrator] ([administratorID], [username], [recordID]) VALUES (4, N'admin003', 5)
SET IDENTITY_INSERT [dbo].[administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[appointment] ON 

INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (1, 1, 1, CAST(N'2023-01-05T09:15:00.000' AS DateTime), N'sickness')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (2, 2, 2, CAST(N'2023-02-05T09:45:00.000' AS DateTime), N'sickness')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (3, 3, 2, CAST(N'2023-03-06T09:15:00.000' AS DateTime), N'sickness')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (4, 4, 2, CAST(N'2023-03-06T09:30:00.000' AS DateTime), N'fever')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (5, 4, 1, CAST(N'2023-03-07T09:15:00.000' AS DateTime), N'back pain')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (6, 4, 1, CAST(N'2023-04-05T09:15:00.000' AS DateTime), N'fever')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (7, 2, 1, CAST(N'2023-04-05T09:45:00.000' AS DateTime), N'sickness')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (8, 3, 2, CAST(N'2023-04-06T09:15:00.000' AS DateTime), N'sickness')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (9, 9, 2, CAST(N'2023-04-06T09:30:00.000' AS DateTime), N'fever')
INSERT [dbo].[appointment] ([appointmentID], [patientID], [doctorID], [appointmentDatetime], [reason]) VALUES (10, 10, 1, CAST(N'2023-04-07T09:15:00.000' AS DateTime), N'back pain')
SET IDENTITY_INSERT [dbo].[appointment] OFF
GO
SET IDENTITY_INSERT [dbo].[doctor] ON 

INSERT [dbo].[doctor] ([doctorID], [recordID]) VALUES (1, 1)
INSERT [dbo].[doctor] ([doctorID], [recordID]) VALUES (2, 2)
SET IDENTITY_INSERT [dbo].[doctor] OFF
GO
INSERT [dbo].[doctor_has_specialty] ([doctorID], [specialtyName]) VALUES (1, N'Family Medicine')
INSERT [dbo].[doctor_has_specialty] ([doctorID], [specialtyName]) VALUES (1, N'Internal Medicine')
INSERT [dbo].[doctor_has_specialty] ([doctorID], [specialtyName]) VALUES (2, N'Orthopedics')
GO
SET IDENTITY_INSERT [dbo].[nurse] ON 

INSERT [dbo].[nurse] ([nurseID], [username], [recordID], [activeStatus]) VALUES (4, N'nurse001', 6, 1)
INSERT [dbo].[nurse] ([nurseID], [username], [recordID], [activeStatus]) VALUES (5, N'nurse002', 7, 0)
INSERT [dbo].[nurse] ([nurseID], [username], [recordID], [activeStatus]) VALUES (6, N'nurse003', 8, 1)
SET IDENTITY_INSERT [dbo].[nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (1, 9)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (2, 10)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (3, 11)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (4, 12)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (5, 13)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (6, 14)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (7, 15)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (8, 16)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (9, 17)
INSERT [dbo].[patient] ([patientID], [recordID]) VALUES (10, 18)
SET IDENTITY_INSERT [dbo].[patient] OFF
GO
SET IDENTITY_INSERT [dbo].[person] ON 

INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (1, N'Smith', N'Jane', CAST(N'2023-01-01' AS Date), N'10 Hill St', N'Orlando', N'FL', N'12345', N'123456789 ', N'F', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (2, N'Morales', N'John', CAST(N'2013-01-02' AS Date), N'20 Hill St', N'Inverness', N'FL', N'12345', N'123456789 ', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (3, N'Lee', N'Allen', CAST(N'1980-01-01' AS Date), N'123 Street A', N'Los Angeles', N'CA', N'91234', N'2131234567', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (4, N'Taylor', N'James', CAST(N'1990-02-11' AS Date), N'234 Street B', N'Wood city', N'CA', N'91111', N'2132225555', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (5, N'Johnson', N'Mary', CAST(N'1990-03-12' AS Date), N'565 Street C', N'Water city', N'CA', N'92222', N'6261234545', N'F', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (6, N'Bangloy', N'Susan', CAST(N'1970-04-16' AS Date), N'25222 Street D', N'Silver city', N'CA', N'93333', N'6265551214', N'F', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (7, N'Su', N'David', CAST(N'1981-05-18' AS Date), N'56555 Street E', N'Diamond city', N'CA', N'95678', N'6264575685', N'M', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (8, N'Williams', N'Thomas', CAST(N'1982-06-01' AS Date), N'12454 Street F', N'Stone city', N'CA', N'90123', N'6264547780', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (9, N'Miller', N'Charles', CAST(N'1983-07-05' AS Date), N'55521 Street K', N'Sapphire', N'CA', N'91231', N'6262745121', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (10, N'Garcia', N'Robert', CAST(N'1993-08-10' AS Date), N'99 Grand Ave', N'Gold', N'CA', N'91222', N'9091234567', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (11, N'Brown', N'John', CAST(N'1994-10-15' AS Date), N'1002 Main St ', N'Green', N'CA', N'91223', N'9092228895', N'M', N'12345678')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (12, N'Davis', N'Andy', CAST(N'2011-11-17' AS Date), N'13001 Amy Rd', N'Blue', N'CA', N'91224', N'9093338100', N'M', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (13, N'Johnson', N'Billy', CAST(N'1977-06-19' AS Date), N'184 Hidden st', N'Stone city', N'CA', N'90123', N'6264588180', N'M', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (14, N'Walker', N'Thomas', CAST(N'1955-07-27' AS Date), N'51 Huge Ave', N'Sapphire', N'CA', N'91231', N'6262745441', N'M', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (15, N'Sanchez', N'Louis', CAST(N'2022-08-18' AS Date), N'39 The Road', N'Gold', N'CA', N'91222', N'9091235567', N'M', NULL)
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (16, N'Young', N'Harry', CAST(N'2021-10-05' AS Date), N'1008 Canyon Rd ', N'Green', N'CA', N'98223', N'9092228195', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (17, N'Hill', N'Bruce', CAST(N'2020-11-09' AS Date), N'181 Suzanne Rd ', N'Blue', N'CA', N'91284', N'9093338166', N'M', N'123456789')
INSERT [dbo].[person] ([recordID], [lastName], [firstName], [birthday], [addressStreet], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (18, N'Parks', N'Alice', CAST(N'2023-02-28' AS Date), N'555 Address Way', N'Sometown', N'GA', N'12345', N'1234567890', N'F', N'123456789')
SET IDENTITY_INSERT [dbo].[person] OFF
GO
INSERT [dbo].[specialty] ([name]) VALUES (N'Family Medicine')
INSERT [dbo].[specialty] ([name]) VALUES (N'Internal Medicine')
INSERT [dbo].[specialty] ([name]) VALUES (N'Orthopedics')
GO
SET IDENTITY_INSERT [dbo].[test] ON 

INSERT [dbo].[test] ([testCode], [name]) VALUES (3, N'Hepatitis A test')
INSERT [dbo].[test] ([testCode], [name]) VALUES (4, N'Hepatitis B test')
INSERT [dbo].[test] ([testCode], [name]) VALUES (2, N'Low-Density Lipoproteins (LDL)')
INSERT [dbo].[test] ([testCode], [name]) VALUES (1, N'White Blood Cell (WBC)')
SET IDENTITY_INSERT [dbo].[test] OFF
GO
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (2, 1, CAST(N'2023-01-08' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (2, 2, CAST(N'2023-01-06' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (2, 3, CAST(N'2023-01-07' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (2, 4, CAST(N'2023-01-07' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (3, 1, CAST(N'2023-02-07' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (3, 2, CAST(N'2023-02-07' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (3, 3, CAST(N'2023-02-08' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (3, 4, CAST(N'2023-02-07' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (4, 1, CAST(N'2023-03-08' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (4, 2, CAST(N'2023-03-08' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (4, 4, CAST(N'2023-03-08' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (5, 1, CAST(N'2023-03-07' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (5, 2, CAST(N'2023-03-08' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (6, 1, CAST(N'2023-03-07' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (6, 2, CAST(N'2023-03-08' AS Date), N'this is another result ', 0)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (6, 3, CAST(N'2023-03-09' AS Date), N'this is a result', 1)
INSERT [dbo].[visit_has_test] ([visitID], [testCode], [testDate], [result], [resultIsNormal]) VALUES (6, 4, CAST(N'2023-03-10' AS Date), N'this is another result ', 0)
GO
SET IDENTITY_INSERT [dbo].[visitRoutineResults] ON 

INSERT [dbo].[visitRoutineResults] ([visitID], [appointmentID], [nurseID], [visitDatetime], [height], [weight], [bloodPressureDiastolic], [bloodPressureSystolic], [bodyTemperature], [pulse], [symptoms], [initialDiagnoses], [finalDiagnoses]) VALUES (2, 1, 4, CAST(N'2023-01-05T09:15:00.000' AS DateTime), CAST(120.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)), 120, 80, CAST(98.6 AS Decimal(6, 1)), 52, N'pain', N'sprained ankle', NULL)
INSERT [dbo].[visitRoutineResults] ([visitID], [appointmentID], [nurseID], [visitDatetime], [height], [weight], [bloodPressureDiastolic], [bloodPressureSystolic], [bodyTemperature], [pulse], [symptoms], [initialDiagnoses], [finalDiagnoses]) VALUES (3, 2, 4, CAST(N'2023-02-05T09:45:00.000' AS DateTime), CAST(200.00 AS Decimal(6, 2)), CAST(95.00 AS Decimal(6, 2)), 120, 80, CAST(98.0 AS Decimal(6, 1)), 75, N'fever', N'flu', NULL)
INSERT [dbo].[visitRoutineResults] ([visitID], [appointmentID], [nurseID], [visitDatetime], [height], [weight], [bloodPressureDiastolic], [bloodPressureSystolic], [bodyTemperature], [pulse], [symptoms], [initialDiagnoses], [finalDiagnoses]) VALUES (4, 3, 5, CAST(N'2023-03-06T09:15:00.000' AS DateTime), CAST(75.00 AS Decimal(6, 2)), CAST(180.00 AS Decimal(6, 2)), 125, 78, CAST(102.5 AS Decimal(6, 1)), 85, N'fever', N'flu', NULL)
INSERT [dbo].[visitRoutineResults] ([visitID], [appointmentID], [nurseID], [visitDatetime], [height], [weight], [bloodPressureDiastolic], [bloodPressureSystolic], [bodyTemperature], [pulse], [symptoms], [initialDiagnoses], [finalDiagnoses]) VALUES (5, 4, 5, CAST(N'2023-03-06T09:30:00.000' AS DateTime), CAST(70.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)), 125, 85, CAST(103.2 AS Decimal(6, 1)), 80, N'fever', N'Covid', NULL)
INSERT [dbo].[visitRoutineResults] ([visitID], [appointmentID], [nurseID], [visitDatetime], [height], [weight], [bloodPressureDiastolic], [bloodPressureSystolic], [bodyTemperature], [pulse], [symptoms], [initialDiagnoses], [finalDiagnoses]) VALUES (6, 5, 6, CAST(N'2023-03-07T09:15:00.000' AS DateTime), CAST(65.00 AS Decimal(6, 2)), CAST(80.00 AS Decimal(6, 2)), 110, 99, CAST(98.1 AS Decimal(6, 1)), 90, N'fever', N'injury', NULL)
SET IDENTITY_INSERT [dbo].[visitRoutineResults] OFF
GO
/****** Object:  Index [UC_administrator_recordID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_administrator_recordID] ON [dbo].[administrator]
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_administrator_username]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_administrator_username] ON [dbo].[administrator]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_appointment_appointmentDatetime_doctorID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_appointment_appointmentDatetime_doctorID] ON [dbo].[appointment]
(
	[appointmentDatetime] ASC,
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_appointment_appointmentDatetime_patientID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_appointment_appointmentDatetime_patientID] ON [dbo].[appointment]
(
	[appointmentDatetime] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_doctor_recordID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_doctor_recordID] ON [dbo].[doctor]
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_nurse_recordID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_nurse_recordID] ON [dbo].[nurse]
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_nurse_username]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_nurse_username] ON [dbo].[nurse]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_patient_recordID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_patient_recordID] ON [dbo].[patient]
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_test_name]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_test_name] ON [dbo].[test]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UC_visitRoutineResults_appointmentID]    Script Date: 4/7/2023 8:48:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_visitRoutineResults_appointmentID] ON [dbo].[visitRoutineResults]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[administrator]  WITH CHECK ADD  CONSTRAINT [FK_administrator_account] FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[administrator] CHECK CONSTRAINT [FK_administrator_account]
GO
ALTER TABLE [dbo].[administrator]  WITH CHECK ADD  CONSTRAINT [FK_administrator_person] FOREIGN KEY([recordID])
REFERENCES [dbo].[person] ([recordID])
GO
ALTER TABLE [dbo].[administrator] CHECK CONSTRAINT [FK_administrator_person]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[doctor] ([doctorID])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_doctor]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[patient] ([patientID])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_patient]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_person] FOREIGN KEY([recordID])
REFERENCES [dbo].[person] ([recordID])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_person]
GO
ALTER TABLE [dbo].[doctor_has_specialty]  WITH CHECK ADD  CONSTRAINT [FK_doctorhasspecialty_doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[doctor] ([doctorID])
GO
ALTER TABLE [dbo].[doctor_has_specialty] CHECK CONSTRAINT [FK_doctorhasspecialty_doctor]
GO
ALTER TABLE [dbo].[doctor_has_specialty]  WITH CHECK ADD  CONSTRAINT [FK_doctorhasspecialty_specialty] FOREIGN KEY([specialtyName])
REFERENCES [dbo].[specialty] ([name])
GO
ALTER TABLE [dbo].[doctor_has_specialty] CHECK CONSTRAINT [FK_doctorhasspecialty_specialty]
GO
ALTER TABLE [dbo].[nurse]  WITH CHECK ADD  CONSTRAINT [FK_nurse_account] FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[nurse] CHECK CONSTRAINT [FK_nurse_account]
GO
ALTER TABLE [dbo].[nurse]  WITH CHECK ADD  CONSTRAINT [FK_nurse_person] FOREIGN KEY([recordID])
REFERENCES [dbo].[person] ([recordID])
GO
ALTER TABLE [dbo].[nurse] CHECK CONSTRAINT [FK_nurse_person]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK_patient_person] FOREIGN KEY([recordID])
REFERENCES [dbo].[person] ([recordID])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK_patient_person]
GO
ALTER TABLE [dbo].[visit_has_test]  WITH CHECK ADD  CONSTRAINT [FK_visithastest_test] FOREIGN KEY([testCode])
REFERENCES [dbo].[test] ([testCode])
GO
ALTER TABLE [dbo].[visit_has_test] CHECK CONSTRAINT [FK_visithastest_test]
GO
ALTER TABLE [dbo].[visit_has_test]  WITH CHECK ADD  CONSTRAINT [FK_visithastest_visitRoutineResults] FOREIGN KEY([visitID])
REFERENCES [dbo].[visitRoutineResults] ([visitID])
GO
ALTER TABLE [dbo].[visit_has_test] CHECK CONSTRAINT [FK_visithastest_visitRoutineResults]
GO
ALTER TABLE [dbo].[visitRoutineResults]  WITH CHECK ADD  CONSTRAINT [FK_visitRoutineResults_appointment] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[appointment] ([appointmentID])
GO
ALTER TABLE [dbo].[visitRoutineResults] CHECK CONSTRAINT [FK_visitRoutineResults_appointment]
GO
ALTER TABLE [dbo].[visitRoutineResults]  WITH CHECK ADD  CONSTRAINT [FK_visitRoutineResults_nurse] FOREIGN KEY([nurseID])
REFERENCES [dbo].[nurse] ([nurseID])
GO
ALTER TABLE [dbo].[visitRoutineResults] CHECK CONSTRAINT [FK_visitRoutineResults_nurse]
GO
/****** Object:  StoredProcedure [dbo].[GenerateAppointmentTimeList]    Script Date: 4/7/2023 8:48:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Nicholas,,Amber>
-- Create date: <3.11.23,,>
-- Description:	<Generates a list of time options in 15 minute intervals for appointments,,>
-- =============================================
CREATE PROCEDURE [dbo].[GenerateAppointmentTimeList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @StartTime TIME = '08:00:00'
    DECLARE @EndTime TIME = '16:00:00'
    DECLARE @Interval INT = 15
    
    DECLARE @AppointmentTime TABLE (TimeOption TIME)
    
    WHILE @StartTime <= @EndTime
    BEGIN
        INSERT INTO @AppointmentTime (TimeOption) VALUES (@StartTime)
        SET @StartTime = DATEADD(MINUTE, @Interval, @StartTime)
    END
    
    SELECT TimeOption FROM @AppointmentTime
END


GO
IF OBJECT_ID('dbo.spGetMostPerformedTestsDuringDates', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spGetMostPerformedTestsDuringDates;
GO
CREATE PROCEDURE dbo.spGetMostPerformedTestsDuringDates
	@startDate DateTime,
	@endDate DateTime
AS

BEGIN


if  ((@startDate is null) or (@endDate is null))
     throw 50001, 'Start Date and End Date are mandatory.', 1;
if 	(@startDate > @endDate)	throw 50001, 'Start Date should be lower than End Date.', 1;

Declare @all_tests_count INTEGER;

set @all_tests_count =
(select count(vt.testCode)
from visit_has_test vt
where vt.testDate >= @startDate
and vt.testDate <= @endDate
and vt.result is not null);

set Nocount on;

select vt.testCode as testCodeNumber , DATEDIFF(hour, pe.birthday, vt.testDate)/8766.0 AS age,
pe.firstName, pe.lastName, pe.birthday, vr.visitID
into #TempTablePatientHasTest
from patient pa, person pe, appointment a, visitRoutineResults vr, visit_has_test vt, test t
where pa.recordID = pe.recordID
and   a.patientID = pa.patientID
and vr.appointmentID = a.appointmentID
and vt.visitID = vr.visitID
and vt.testCode =  t.testCode
and vt.result is not null
and vt.testDate >= @startDate
and vt.testDate < = @endDate;


select vt.testCode as testCode ,
t.name as testName,
count(vt.testCode) as timesPerformed,
@all_tests_count as allTestTotal,
FORMAT(count(vt.testCode) / (@all_tests_count * 1.0), 'P') as percentOfAllTests,
(SELECT COUNT(*) FROM visit_has_test vht WHERE vht.testCode = vt.testCode and vht.resultIsNormal = 0 and vht.testDate >= @startDate and vht.testDate < = @endDate            )  as normalCount,
(SELECT COUNT(*) FROM visit_has_test vht WHERE vht.testCode = vt.testCode and vht.resultIsNormal = 1 and vht.testDate >= @startDate and vht.testDate < = @endDate             )  as abnormalCount,

FORMAT((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest WHERE age >= 18 and age < 30  and testCodeNumber = vt.testCode) /
((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest v where v.testCodeNumber = vt.testCode) * 1.0), 'P') as age18To29,

FORMAT((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest WHERE age >= 30 and age < 40  and testCodeNumber = vt.testCode) /
((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest v where v.testCodeNumber = vt.testCode) * 1.0), 'P') as age30To39,

FORMAT((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest WHERE (age < 18 or  age >= 40) and testCodeNumber = vt.testCode) /
((SELECT COUNT(testCodeNumber) FROM #TempTablePatientHasTest v where v.testCodeNumber = vt.testCode) * 1.0), 'P') as otherAges

from visit_has_test vt, test t
where vt.testCode = t.testCode
and   vt.testDate >= @startDate
and   vt.testDate <= @endDate
and   vt.result is not null
group by vt.testCode, t.name
having count(vt.testCode)> 1
order by 3 desc, 1 desc;
set Nocount on;


drop table #TempTablePatientHasTest;

END


GO
USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE 
GO
