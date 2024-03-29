USE [master]
GO
/****** Object:  Database [abc_automotive]    Script Date: 17/07/2022 18:55:09 ******/
CREATE DATABASE [abc_automotive]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'abc_automotive', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\abc_automotive.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'abc_automotive_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\abc_automotive_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [abc_automotive] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [abc_automotive].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [abc_automotive] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [abc_automotive] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [abc_automotive] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [abc_automotive] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [abc_automotive] SET ARITHABORT OFF 
GO
ALTER DATABASE [abc_automotive] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [abc_automotive] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [abc_automotive] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [abc_automotive] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [abc_automotive] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [abc_automotive] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [abc_automotive] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [abc_automotive] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [abc_automotive] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [abc_automotive] SET  DISABLE_BROKER 
GO
ALTER DATABASE [abc_automotive] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [abc_automotive] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [abc_automotive] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [abc_automotive] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [abc_automotive] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [abc_automotive] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [abc_automotive] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [abc_automotive] SET RECOVERY FULL 
GO
ALTER DATABASE [abc_automotive] SET  MULTI_USER 
GO
ALTER DATABASE [abc_automotive] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [abc_automotive] SET DB_CHAINING OFF 
GO
ALTER DATABASE [abc_automotive] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [abc_automotive] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [abc_automotive] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [abc_automotive] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [abc_automotive] SET QUERY_STORE = OFF
GO
USE [abc_automotive]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CheckOutDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[CheckInDate] [datetime] NULL,
	[Status] [int] NOT NULL,
	[StudentID] [char](8) NOT NULL,
	[ResourceID] [int] NOT NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserName] [nchar](30) NOT NULL,
	[Password] [nchar](30) NOT NULL,
	[DepartementHead] [bit] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [money] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Type] [nvarchar](30) NOT NULL,
	[StudentID] [char](8) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Program]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Program](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[TypeID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_Program] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramType]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramType](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProgramType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReserveStatus]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReserveStatus](
	[ID] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[ReservingStudentID] [int] NULL,
 CONSTRAINT [PK_ReserveStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resource](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Status] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[ReserveStatus] [bit] NOT NULL,
	[ImagePath] [nvarchar](500) NULL,
	[DateRemoved] [datetime] NULL,
	[ReservingStudentID] [char](8) NULL,
 CONSTRAINT [PK_Ressources] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourceStatus]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourceStatus](
	[ID] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ResourceStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourceType](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ResourceType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [char](8) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BalanceDue] [money] NOT NULL,
	[Status] [bit] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Ressources] FOREIGN KEY([ResourceID])
REFERENCES [dbo].[Resource] ([ID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Ressources]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Student]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Student]
GO
ALTER TABLE [dbo].[Program]  WITH CHECK ADD  CONSTRAINT [FK_Program_ProgramType] FOREIGN KEY([ID])
REFERENCES [dbo].[Program] ([ID])
GO
ALTER TABLE [dbo].[Program] CHECK CONSTRAINT [FK_Program_ProgramType]
GO
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Status] FOREIGN KEY([Status])
REFERENCES [dbo].[ResourceStatus] ([ID])
GO
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Status]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Program] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[Program] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Program]
GO
/****** Object:  StoredProcedure [dbo].[CheckIn_Get_Borrowings]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[CheckIn_Get_Borrowings]
    @ResourceID int
AS
BEGIN
    IF (SELECT [Status] FROM Loan WHERE Ressourceid = @ResourceID) = 1
    BEGIN
        SELECT Ressource.ID AS ResourceID, Title, [Type] AS ResourceType, Ressource.[Status] AS ResourceStatus, Loan.ID AS LoanID ,Loan.CheckOutDate, Loan.DueDate FROM Ressource
        INNER JOIN Loan ON Ressource.ID = Loan.RessourceID WHERE Loan.StudentID = (SELECT StudentID FROM Loan WHERE RessourceID = @ResourceID) AND Loan.[Status] = 1
    END
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[DeleteStudent]
@StudentId CHAR(8)
AS 
BEGIN
DELETE Student WHERE ID = @StudentId
END
GO
/****** Object:  StoredProcedure [dbo].[GetLoansByStudent]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetLoansByStudent]
    @StudentID int  
AS   

    SET NOCOUNT ON;
    SELECT [Resource].ID, [Resource].Title, ResourceType.[Name], Loan.CheckOutDate, [Resource].ImagePath, Loan.DueDate
    FROM [Resource]
	JOIN ResourceType ON [Resource].TypeID = ResourceType.ID
	JOIN Loan ON [Resource].ID = Loan.ResourceID
    WHERE Loan.StudentID = @StudentID
GO
/****** Object:  StoredProcedure [dbo].[GetResourceById]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetResourceById]
	@ResourceID int
AS   

    SET NOCOUNT ON;  
    SELECT Title, ResourceType.Name AS "Type", ResourceStatus.Status, ReserveStatus
    FROM Resource
	JOIN ResourceType ON Resource.TypeID = ResourceType.ID
	JOIN ResourceStatus ON Resource.Status = ResourceStatus.ID
    WHERE Resource.ID = @ResourceID
GO
/****** Object:  StoredProcedure [dbo].[GetStudentByResourceID]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetStudentByResourceID]
@ResourceID INT
AS
BEGIN
  IF(SELECT Status FROM Loan WHERE RessourceID = @ResourceID) = 1
  SELECT * FROM Student INNER JOIN Loan ON Student.ID = Loan.StudentID WHERE RessourceID = @ResourceID
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByLastName]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentsByLastName]   
    @LastName nvarchar(50) 
AS   

    SET NOCOUNT ON;  
    SELECT Student.*, Program.[Name] AS "Program", Program.[StartDate] AS "StartDate", Program.[EndDate] AS "EndDate"
    FROM Student
	INNER JOIN Program ON Student.ProgramID = Program.ID
    WHERE Student.LastName LIKE @LastName + '%'
GO
/****** Object:  StoredProcedure [dbo].[Insert_Loan]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[Insert_Loan]

@CheckOutDate DATETIME,
@DueDate DATETIME,
@CheckInDate DATETIME = NULL,
@Status NVARCHAR(50),
@StudentID CHAR(8),
@RessourceID INT
AS
BEGIN 
	INSERT INTO Loan VALUES (@CheckOutDate, @DueDate, @CheckInDate, @Status, @StudentID, @RessourceID)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertStudent]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[InsertStudent]
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@BalanceDue DECIMAL,
@Status BIT,
@ProgramID INT,
@StartDate DATETIME,
@EndDate DATETIME
AS
BEGIN
	DECLARE @RandomInt INT;
	SET @RandomInt = CONCAT(2020, (CAST(RAND()*10000 AS INT)));
	WHILE (@RandomInt IN (SELECT ID FROM Student))
		SET @RandomInt = CONCAT(2020, (CAST(RAND()*10000 AS INT)))

	INSERT INTO Student (ID, FirstName , LastName,BalanceDue ,Status, ProgramID , StartDate ,EndDate)
	VALUES 
		(@RandomInt, @FirstName ,@LastName,@BalanceDue ,@Status, @ProgramID , @StartDate ,@EndDate)

END
GO
/****** Object:  StoredProcedure [dbo].[PaymentAddPayment]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PaymentAddPayment]
	@StudentID CHAR(8),
	@Payment MONEY,
	@Date DATETIME,
	@Type NVARCHAR(30)
AS
BEGIN
	INSERT INTO Payments VALUES (@Payment, @Date, @Type, @StudentID)
END
GO
/****** Object:  StoredProcedure [dbo].[PaymentMakePayment]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PaymentMakePayment]
	@StudentID CHAR(8),
	@Payment MONEY
AS
BEGIN
	DECLARE @BalanceDue MONEY = (SELECT BalanceDue FROM Student WHERE ID = @StudentID)
	UPDATE Student SET BalanceDue = @BalanceDue - @Payment WHERE ID = @StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[PaymentRetrieveStudentInfo]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PaymentRetrieveStudentInfo]
	@StudentID NVARCHAR(MAX)
AS
BEGIN
	SELECT FirstName, LastName, BalanceDue, Program.[Type] AS Program, StartDate, EndDate, [Status] FROM Student
	INNER JOIN Program ON Student.ProgramID = Program.ID
	WHERE Student.ID = @StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[PaymentRetrieveStudents]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PaymentRetrieveStudents]
	@SearchCriteria NVARCHAR(MAX),
	@SearchBy INT
AS
BEGIN
	IF @SearchBy = 1
	BEGIN
		SELECT ID, FirstName, LastName FROM Student
		WHERE Student.ID LIKE @SearchCriteria + '%'
	END
	ELSE
	BEGIN
		SELECT ID, FirstName, LastName FROM Student
		WHERE FirstName + ' ' + LastName LIKE @SearchCriteria + '%' OR LastName LIKE @SearchCriteria + '%'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[RetriveMatchingStudents]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[RetriveMatchingStudents]
@StudentID CHAR(8) = NULL,
@PartialLastName  NVARCHAR(50) = NULL

AS

BEGIN 
	SELECT ID, FirstName, LastName, [TimeStamp]
	FROM Student 
	WHERE ID = @StudentID  OR LastName LIKE @PartialLastName +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[RetriveRessourceDetails]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[RetriveRessourceDetails]
@RessourceID INT

AS

BEGIN 
	SELECT ID ,Title, Type, Price, Status, ReserveStatus,ImagePath ,ReservingStudentID 
	FROM Ressource 
	WHERE ID = @RessourceID
	
END
GO
/****** Object:  StoredProcedure [dbo].[RetriveStudentInformation]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[RetriveStudentInformation]
@StudentID CHAR(8)

AS

BEGIN 
	SELECT *  FROM Student 
	WHERE ID = @StudentID
	
END
GO
/****** Object:  StoredProcedure [dbo].[RetriveStudentLoans]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[RetriveStudentLoans]
@StudentID CHAR(8) = NULL

AS

BEGIN 
	SELECT * FROM Loan WHERE StudentId = @StudentID
	
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Loan_Status]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Update_Loan_Status]
	@ResourceID int,
	@Status nvarchar(50),
	@CheckInDate datetime = NULL
AS
BEGIN
	UPDATE Loan SET [Status] = @Status, CheckInDate = @CheckInDate WHERE RessourceID = @ResourceID
END

SELECT * FROM Student
GO
/****** Object:  StoredProcedure [dbo].[Update_Resource_Status]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Update_Resource_Status]
	@ResourceID int,
	@ResourceStatus nvarchar(50),
	@DateRemoved Datetime = NULL
AS
BEGIN
	UPDATE Ressource SET [Status] = @ResourceStatus, DateRemoved = @DateRemoved WHERE ID = @ResourceID
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Student_BalanceDue]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Update_Student_BalanceDue]
	@StudentID char(8),
	@NewBalanceDue money
AS
BEGIN
	UPDATE Student SET BalanceDue = @NewBalanceDue WHERE ID = @StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRessource]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateRessource]
@RessourceID INT
AS
BEGIN
Update Ressource SET ReserveStatus = 0 WHERE ID = @RessourceID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRessource_ReserveStatus]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateRessource_ReserveStatus]
@RessourceID INT,
@StudentID CHAR(8)
AS
BEGIN
Update Ressource 
	SET ReserveStatus = 1 , ReservingStudentID = @StudentID
	WHERE ID = @RessourceID AND ReserveStatus = 0
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRessource_Status]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateRessource_Status]
@RessourceID INT
AS
BEGIN
Update Ressource SET Status = 2 WHERE ID = @RessourceID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 17/07/2022 18:55:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateStudent]
@TimeStamp TIMESTAMP OUTPUT,
@StudentID CHAR(8),
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@BalanceDue DECIMAL,
@Status BIT,
@ProgramID INT,
@StartDate DATETIME,
@EndDate DATETIME
AS
BEGIN 
Update Student
	SET FirstName = @FirstName,
	    LastName= @LastName,
		BalanceDue = @BalanceDue,
		Status = @Status,
		ProgramID = @ProgramID,
		StartDate = @StartDate,
		EndDate = @EndDate
	WHERE ID = @StudentID

	SET @TimeStamp = (SELECT [TimeStamp] FROM Student WHERE ID = @StudentID)
END
GO
USE [master]
GO
ALTER DATABASE [abc_automotive] SET  READ_WRITE 
GO
