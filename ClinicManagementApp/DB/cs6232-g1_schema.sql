USE [master]
GO
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'cs6232-g1') 
BEGIN
ALTER DATABASE [cs6232-g1] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
DROP DATABASE [cs6232-g1]
END
GO

CREATE DATABASE [cs6232-g1]
GO
USE [cs6232-g1]
GO



/****** Object:  Table [dbo].[account]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[administrator]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[appointment]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[doctor]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[doctor_has_specialty]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[nurse]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[patient]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[person]    Script Date: 3/6/2023 5:40:06 PM ******/
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
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[specialty]    Script Date: 3/6/2023 5:40:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialty](
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_specialty] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[test]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[visit_has_test]    Script Date: 3/6/2023 5:40:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visit_has_test](
	[visitID] [int] NOT NULL,
	[testCode] [int] NOT NULL,
	[testDate] [date] NOT NULL,
	[result] [varchar](100) NOT NULL,
	[resultIsNormal] [tinyint] NOT NULL,
 CONSTRAINT [PK_visit_has_test] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC,
	[testCode] ASC,
	[testDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[visitRoutineResults]    Script Date: 3/6/2023 5:40:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Unique and default data ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_appointment_appointmentDatetime_doctorID] ON [dbo].[appointment]
(
	[appointmentDatetime] ASC,
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_appointment_appointmentDatetime_patientID] ON [dbo].[appointment]
(
	[appointmentDatetime] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_test_name] ON [dbo].[test]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_visitRoutineResults_appointmentID] ON [dbo].visitRoutineResults
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_nurse_recordID] ON [dbo].nurse
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_administrator_recordID] ON [dbo].administrator
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_nurse_username] ON [dbo].nurse
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_administrator_username] ON [dbo].administrator
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


CREATE UNIQUE NONCLUSTERED INDEX [UC_patient_recordID] ON [dbo].patient
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UC_doctor_recordID] ON [dbo].doctor
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[visitRoutineResults] ADD  CONSTRAINT [DF_visitRoutineResults_finalDiagnoses]  DEFAULT ('pending test results') FOR [finalDiagnoses]
GO

/****** Foreign keys ******/

ALTER TABLE [dbo].[administrator]  WITH CHECK ADD  CONSTRAINT [FK_administrator_account] FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username])
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
REFERENCES [dbo].[account] ([username])
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


USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE 
GO
