USE [cs6232-g1]
GO

/****** Object:  StoredProcedure [dbo].[GenerateAppointmentTimeList]    Script Date: 3/11/2023 9:30:42 AM ******/
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

