USE [master]
GO
/****** Object:  Database [ClinicDB]    Script Date: 30/12/2024 3:14:32 CH ******/
CREATE DATABASE [ClinicDB]

GO
ALTER DATABASE [ClinicDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ClinicDB] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClinicDB] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClinicDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClinicDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ClinicDB] SET QUERY_STORE = OFF
GO
USE [ClinicDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[ID] [varchar](20) NOT NULL,
	[MedicineName] [nvarchar](50) NULL,
	[Price] [varchar](20) NULL,
	[Number] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[ID] [int] NOT NULL,
	[DateExam] [varchar](20) NOT NULL,
	[Fullname] [nvarchar](50) NULL,
	[Birth] [varchar](5) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [varchar](100) NULL,
	[Diagnose] [nvarchar](100) NULL,
	[Medicine] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[DateExam] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revenue]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revenue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](20) NOT NULL,
	[Deal] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](50) NOT NULL,
	[Fullname] [nvarchar](50) NULL,
	[Birth] [nchar](10) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'admin', N'e10adc3949ba59abbe56e057f20f883e', 0)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'dinhloc334', N'748190880b5dde774461732f1be87689', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'dinhlocpisces', N'e10adc3949ba59abbe56e057f20f883e', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'doctor1', N'202cb962ac59075b964b07152d234b70', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'doctor2', N'81dc9bdb52d04dc20036dbd8313ed055', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'doctor3', N'827ccb0eea8a706c4c34a16891f84e7b', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'doctor4', N'e10adc3949ba59abbe56e057f20f883e', 1)
INSERT [dbo].[Account] ([Username], [Password], [Type]) VALUES (N'doctor5', N'fcea920f7412b5da7be0cf42b8c93759', 1)
GO
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'AA', N'Kem bối chống hâm, ngứa, nổi mẫn', N'15000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'AB', N'Kem thoa chống xẹo', N'2500', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'AT', N'Thuốc an thần', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'CSC', N'Viên Sủi vitamin C', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'CSD', N'Viên Sủi vitamin D', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'DBH', N'Dầu bạc hà - giảm đau rát họng', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'DC', N'Dầu cá', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'DM', N'Thuốc kim cương - tăng sức đề kháng', N'25000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'GD', N'Thuốc giảm đau', N'30000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'KS', N'Kháng sinh', N'30000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'PAN', N'Panadol', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'Strepsil', N'Strepsil - viên ngậm trị ho', N'15000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'TD', N'Thuốc đỏ', N'15000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'THO', N'Thuốc ho', N'20000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'THS', N'Thuốc hạ sốt', N'25000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'TN', N'Thuốc ngủ', N'30000', 100)
INSERT [dbo].[Medicine] ([ID], [MedicineName], [Price], [Number]) VALUES (N'TX', N'Thuốc xổ', N'25000', 100)
GO
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (1, N'04/07/2021', N'Bùi Đình Lộc', N'2001', N'Hóc Môn', N'FXoIXureZhFw6ZbMxgN05A==', N'Ho', N'+ Thuốc hạ sốt: 3;
+ Thuốc ho: 3;
+ Viên Sủi vitamin C: 3;
')
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (2, N'04/07/2021', N'Nguyễn Phùng Lê Luân', N'2001', N'Bình Thuân', N'SPL8xWA2N9YJdoo0jb2Odg==', N'Sốt', N'+ Thuốc hạ sốt: 3;
+ Strepsil - viên ngậm trị ho: 3;
+ Panadol: 3;
')
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (3, N'04/07/2021', N'Patient 1', N'2001', N'HCM', N'SPL8xWA2N9YJdoo0jb2Odg==', N'Ho', N'+ Thuốc ho: 3;
+ Dầu cá: 3;
+ Panadol: 3;
')
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (4, N'04/07/2021', N'Patient 2', N'2001', N'HCM', N'N2YBy4+ba+F00BF48/LO3A==', N'Sốt', N'+ Thuốc hạ sốt: 3;
+ Panadol: 3;
')
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (1, N'05/07/2021', N'Patient 3', N'2003', N'Bình Thạnh', N'A/vb4RMyd5//oWGm5YTXYQ==', N'Viêm da dị ứng', N'+ Kem bối chống hâm, ngứa, nổi mẫn: 3;
+ Kem thoa chống xẹo: 3;
')
INSERT [dbo].[Patients] ([ID], [DateExam], [Fullname], [Birth], [Address], [Phone], [Diagnose], [Medicine]) VALUES (2, N'05/07/2021', N'Patient 4', N'2003', N'Quận 12', N'mGCm1sr2+tfi5m5lWip2xw==', N'Đau họng', N'+ Strepsil - viên ngậm trị ho: 3;
+ Thuốc ho: 3;
')
GO
SET IDENTITY_INSERT [dbo].[Revenue] ON 

INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (7, N'03/07/2021', 150000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (9, N'03/07/2021', 150000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (10, N'03/07/2021', 330000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (11, N'04/07/2021', 180000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (12, N'04/07/2021', 175000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (13, N'04/07/2021', 150000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (15, N'04/07/2021', 300000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (16, N'04/07/2021', 120000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (17, N'05/07/2021', 100000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (18, N'05/07/2021', 210000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (19, N'05/07/2021', 120000)
INSERT [dbo].[Revenue] ([ID], [Date], [Deal]) VALUES (20, N'05/07/2021', 170000)
SET IDENTITY_INSERT [dbo].[Revenue] OFF
GO
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'admin', N'', N'1900      ', N'', N'', N'')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'dinhloc334', N'Bùi Đình Lộc', N'1900      ', NULL, N'uuBlIF/TvmdFPc54Jpq0CA==', N'TrwSncpwMOrnW1mT8Vyc3PUC+JH3VXoUUlgcwKmssvs=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'dinhlocpisces', N'Bùi Đình Lộc', N'2001      ', N'Hóc Môn', N'FXoIXureZhFw6ZbMxgN05A==', N'8uZ6y37tt1SZonR21AYQ2g/pKBvHjNrS/isfQMn0Dmk=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'doctor1', N'Nguyễn Văn A', N'1900      ', NULL, N'zBXBOeowhg5ToI8nODqvoQ==', N'f/wCp6fSyTPLtRtZi4KVX0yofUwV//7ynl2XuO0zJAk=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'doctor2', N'Nguyễn Văn B', N'1900      ', NULL, N'Fx32ikL6K380srL3sJPBYQ==', N'vy6fdtadf9HeIcNHl9wN35mHC4MvHKyR0IsfLz2Au7U=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'doctor3', N'Nguyễn Văn B', N'1900      ', NULL, N'IK0Dpjte23Z+Q3yA7px1NQ==', N'Jn70Y/J5b9CRmL++fA/zKRkQ2y53y6xIY+Q8a9b5liQ=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'doctor4', N'Nguyễn Văn D', N'1900      ', NULL, N'pdQFfB3dYGrptwNcDEfd2Q==', N'UCUzaj/Ogl4B90deZuP1ZqiF5011Ro/UD6lEiRhDvCM=')
INSERT [dbo].[Users] ([Username], [Fullname], [Birth], [Address], [Phone], [Email]) VALUES (N'doctor5', N'Nguyễn Văn Em', N'1900      ', NULL, N'8B3wFQAoZ2C7TcDktQND+g==', N'8QYz16MssJ1clMuN+10eWLC6pi18Zc2JvTF2KrDMsKI=')
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_Type]  DEFAULT ((1)) FOR [Type]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_User_Birth]  DEFAULT ((1900)) FOR [Birth]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Account] FOREIGN KEY([Username])
REFERENCES [dbo].[Account] ([Username])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Account]
GO
/****** Object:  StoredProcedure [dbo].[USP_AddDeal]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[USP_AddDeal]
@date varchar(20), @deal real
as
begin
	insert Revenue (Date, Deal)
	values (@date, @deal)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddMedicine]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_AddMedicine]
@id varchar(50), @medicineName nvarchar(50), @price varchar(20), @number int
as
begin
	insert Medicine(ID, MedicineName, Price, Number)
	values (@id, @medicineName, @price, @number)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddPatient]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_AddPatient]
@id int, @dateExam varchar(20), @fullName nvarchar(50), @birth varchar(5), @address nvarchar(50), @phone varchar(100), @diagnose nvarchar(100), @medicine nvarchar(100)
as
begin
	insert Patients(ID, DateExam, Fullname, Birth, Address, Phone, Diagnose, Medicine)
	values(@id, @dateExam, @fullName, @birth, @address, @phone, @diagnose, @medicine)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangePassword]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ChangePassword]
@username varchar(50), @password varchar(50)
as
begin
	update Account
	set Password = @password
	where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckAccount]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_CheckAccount]
@check varchar(100), @type int
as
begin
	if(@type = 0)
		select * from Users where @check = Email
	else
		select * from Users where @check = Phone
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CreateAccount]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CreateAccount]
@username varchar(50),
@password varchar(50),
@fullname nvarchar(50),
@phone varchar(100),
@email varchar(100)
as
begin
	insert into Account(Username, Password, Type)
	Values (@username, @password, 1)
	insert into Users (Username, Fullname, Phone, Email)
	Values (@username, @fullname, @phone, @email)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteMedicine]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_DeleteMedicine]
@id varchar(50)
as
begin
	delete Medicine where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[USP_DeletePatient]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DeletePatient]
@id int, @dateExam varchar(20)
as
begin
	delete Patients where ID = @id and DateExam = @dateExam
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ExistEmail]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_ExistEmail]
@email varchar(100)
as
begin
select * from Users where Email = @email
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ExistPhone]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_ExistPhone]
@phone varchar(100)
as
begin
select * from Users where Phone = @phone
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ExistUsername]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ExistUsername]
@username varchar(50)
as
begin
select * from Account where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountList]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetAccountList]
as
select * from dbo.Account
GO
/****** Object:  StoredProcedure [dbo].[USP_GetMedicineList]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetMedicineList]
as
begin
	select * from Medicine
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetOrderOfExam]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetOrderOfExam]
@dateExam varchar(20)
as
begin
	select * from Patients where DateExam = @dateExam order by ID Desc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetPassword]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetPassword]
@username varchar(50)
as
begin
	select * from Account where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetPatientList]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetPatientList]
as
begin
	select * from Patients
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetRevenueList]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetRevenueList]
as
begin
	select * from Revenue
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetUserInfo]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetUserInfo]
@username varchar(50)
as
begin
	select * from Users where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetUserList]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetUserList]
as
begin
	select * from Users
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_Login]
@username varchar(50), @password varchar(50)
As
Begin
	Select * from dbo.Account where Username = @username and Password = @password
End
GO
/****** Object:  StoredProcedure [dbo].[USP_OrderbyDate]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[USP_OrderbyDate]
@date varchar(20)
as
begin
	select * from Revenue where Date = @date
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ReplaceAtmpValues]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ReplaceAtmpValues]
@userName varchar(50)
as 
begin
	update Users
	set Email = '-1', Phone = '-1'
	where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateInfo]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_UpdateInfo]
@username varchar(50), @fullname nvarchar(50), @birth varchar(5), @address nvarchar(50), @phone varchar(100), @email varchar(100)
as
begin
	Update Users
	set Users.Fullname = @fullname, Users.Birth = @birth, Users.Address = @address, Users.Phone = @phone, Users.Email = @email
	where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateMedicineInfo]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_UpdateMedicineInfo]
@id varchar(50), @medicineName nvarchar(50), @price varchar(20), @number int
as
begin
	update Medicine
	set MedicineName = @medicineName, Price = @price, Number = @number
	where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePatientInfo]    Script Date: 30/12/2024 3:14:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_UpdatePatientInfo]
@id int, @dateExam varchar(20), @fullName nvarchar(50), @birth varchar(5), @address nvarchar(50), @phone varchar(100), @diagnose nvarchar(100), @medicine nvarchar(100)
as
begin
	update Patients
	set Fullname = @fullName, Birth = @birth, Address = @address, Phone = @phone, Diagnose = @diagnose, Medicine = @medicine
	where ID = @id and DateExam = @dateExam
end
GO
USE [master]
GO
ALTER DATABASE [ClinicDB] SET  READ_WRITE 
GO
