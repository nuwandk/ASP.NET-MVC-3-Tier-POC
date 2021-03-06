USE [master]
GO
/****** Object:  Database [HrManagementDb]    Script Date: 5/20/2015 12:10:08 PM ******/
CREATE DATABASE [HrManagementDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HrManagementDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HrManagementDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HrManagementDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HrManagementDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HrManagementDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HrManagementDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HrManagementDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HrManagementDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HrManagementDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HrManagementDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HrManagementDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [HrManagementDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HrManagementDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HrManagementDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HrManagementDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HrManagementDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HrManagementDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HrManagementDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HrManagementDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HrManagementDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HrManagementDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HrManagementDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HrManagementDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HrManagementDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HrManagementDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HrManagementDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HrManagementDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HrManagementDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HrManagementDb] SET RECOVERY FULL 
GO
ALTER DATABASE [HrManagementDb] SET  MULTI_USER 
GO
ALTER DATABASE [HrManagementDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HrManagementDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HrManagementDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HrManagementDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HrManagementDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HrManagementDb]
GO
/****** Object:  Table [dbo].[DepartmentInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DepartmentInfo](
	[DepartmentId] [int] NOT NULL,
	[Name] [varchar](250) NULL,
	[ManagerId] [int] NULL,
	[LocationId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_tblDepartment] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DesignationsInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DesignationsInfo](
	[DesignationId] [int] NOT NULL,
	[Title] [varchar](250) NULL,
	[MinSalary] [int] NULL,
	[MaxSalary] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_Designations] PRIMARY KEY CLUSTERED 
(
	[DesignationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeesInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeesInfo](
	[EmpId] [int] NOT NULL,
	[FirstName] [varchar](250) NOT NULL,
	[LastName] [varchar](250) NOT NULL,
	[Email] [varchar](350) NULL,
	[JobDesignationId] [int] NULL,
	[PhoneNumber] [nchar](10) NULL,
	[Salary] [int] NULL,
	[DepartmentId] [int] NULL,
	[ManagerId] [int] NULL,
	[DateOfJoin] [datetime] NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_tblEmployees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpolyeeHistoryInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpolyeeHistoryInfo](
	[EmpId] [int] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[DesignationId] [int] NULL,
	[DepartmentId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_EmpolyeeHistory] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationsInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LocationsInfo](
	[LocationId] [int] NOT NULL,
	[Address] [varchar](max) NULL,
	[Country] [varchar](max) NULL,
	[PostalCode] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OperationInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OperationInfo](
	[OperationId] [int] NOT NULL,
	[Operation] [varchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_OperationInfo] PRIMARY KEY CLUSTERED 
(
	[OperationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleOperationMappingInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoleOperationMappingInfo](
	[RoleOperationMapId] [int] NOT NULL,
	[UserRoleId] [int] NULL,
	[OperationId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedUserId] [varchar](100) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedUserId] [varchar](100) NULL,
 CONSTRAINT [PK_RoleOperationMappingInfo] PRIMARY KEY CLUSTERED 
(
	[RoleOperationMapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[EmailAddress] [varchar](150) NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRoleInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRoleInfo](
	[UserRoleId] [int] NOT NULL,
	[UserRoleName] [varchar](150) NULL,
	[CreateDate] [datetime] NULL,
	[CreateUserId] [varchar](200) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdateUserId] [varchar](200) NULL,
 CONSTRAINT [PK_UserRoleInfo] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRoleMappingInfo]    Script Date: 5/20/2015 12:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRoleMappingInfo](
	[UserRoleMapId] [int] NOT NULL,
	[UserId] [int] NULL,
	[UserRoleId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedUserId] [varchar](150) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdatedUserId] [varchar](150) NULL,
 CONSTRAINT [PK_UserRoleMappingInfo] PRIMARY KEY CLUSTERED 
(
	[UserRoleMapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DepartmentInfo] ([DepartmentId], [Name], [ManagerId], [LocationId], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (201, N'HR', 1001, 401, NULL, NULL, NULL, NULL)
INSERT [dbo].[DepartmentInfo] ([DepartmentId], [Name], [ManagerId], [LocationId], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (202, N'Finance', 1002, 402, NULL, NULL, NULL, NULL)
INSERT [dbo].[DepartmentInfo] ([DepartmentId], [Name], [ManagerId], [LocationId], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (203, N'Delivery', 1003, 402, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3001, N'Associate Engineer', 35000, 45000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3002, N'Engineer', 45000, 60000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3003, N'Senior Engineer', 60000, 100000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3004, N'Consultant', 100000, 150000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3005, N'Senior Consultant', 150000, 220000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3006, N'Associate Architect', 220000, 260000, NULL, NULL, NULL, NULL)
INSERT [dbo].[DesignationsInfo] ([DesignationId], [Title], [MinSalary], [MaxSalary], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3007, N'Architect', 260000, 320000, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1001, N'Nuwan', N'Chinthana', N'nchinthana@gmail.com', 3005, N'0772200943', 120000, 203, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1002, N'Chami', N'Fernando', N'chfernando@gmail.com', 3004, N'0772200943', 160000, 203, 1002, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1003, N'Ravi', N'Gayantha', N'nchinthana@gmail.com', 3002, N'0772200943', 100000, 203, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1005, N'Sandun', N'Jayaweera', N'SandunJaya@gmail.com', 3004, N'0772200977', 180000, 203, 1001, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2010, N'Dhammika', N'Perera', N'dprerea@gmail.com', 3005, N'0777234234', 210000, 203, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2045, N'Gayantha', N'Siriwardhana', N'gsiriwarshana@gmail.com', 3002, N'0778456789', 50000, 202, 1005, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2050, N'Isuru', N'Dewundara', N'isuruDew@yahoo.com', 3002, N'0772200978', 150000, 203, 1002, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2090, N'Shami', N'Fernandaz', N'shamifer@yahoo.com', 3001, N'0777688788', 35000, 201, 1002, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2145, N'Mahesh', N'Dharmawardhana', N'MDharmawardhana@gmail.com', 3004, N'0778389967', 120000, 203, 1001, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2456, N'Sachini', N'Ayendra', N'sayendra@gmail.com', 3002, N'0778234543', 45000, 203, 1001, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeesInfo] ([EmpId], [FirstName], [LastName], [Email], [JobDesignationId], [PhoneNumber], [Salary], [DepartmentId], [ManagerId], [DateOfJoin], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3003, N'Nimeshi', N'Sara', N'Nimeshi@gmail.com', 3001, N'0772789124', 35000, 202, 1001, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationsInfo] ([LocationId], [Address], [Country], [PostalCode], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (401, N'45/A, D R Wijewardana Mw, Colombo 2', N'Sri Lanka', N'100202', NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationsInfo] ([LocationId], [Address], [Country], [PostalCode], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (402, N'A12/A2, Torintan Street, Oriontan', N'Norway', N'100203', NULL, NULL, NULL, NULL)
INSERT [dbo].[OperationInfo] ([OperationId], [Operation], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1, N'GetEmployee', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[OperationInfo] ([OperationId], [Operation], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2, N'EditEmployee', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[OperationInfo] ([OperationId], [Operation], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3, N'DeleteEmployee', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[OperationInfo] ([OperationId], [Operation], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (4, N'CreateEmployee', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[OperationInfo] ([OperationId], [Operation], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (5, N'GenerateReport', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (1, 1, 1, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (2, 1, 2, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (3, 1, 3, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (4, 1, 4, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (5, 1, 5, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (6, 2, 1, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (7, 2, 2, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (8, 2, 5, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (9, 3, 1, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[RoleOperationMappingInfo] ([RoleOperationMapId], [UserRoleId], [OperationId], [CreatedDate], [CreatedUserId], [UpdatedDate], [UpdatedUserId]) VALUES (10, 3, 5, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserInfo] ([UserId], [UserName], [Password], [EmailAddress], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (1, N'nkaduruwana', N'ANYn0eGpPR4/3E2KzEengDECtFjPEs2dPYBabzc1yu5ihvd+g/xbW7L8O4Bz1TDZbw==', N'nkaduruwana@gmail.com', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserInfo] ([UserId], [UserName], [Password], [EmailAddress], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (2, N'mdharmasena', N'********', N'mdharmasena@gmail.com', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserInfo] ([UserId], [UserName], [Password], [EmailAddress], [CreateDate], [CreateUserId], [UpdateDate], [UpdateUserId]) VALUES (3, N'wshsilva', N'********', N'wshsilva@gmail.com', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-01-04 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleInfo] ([UserRoleId], [UserRoleName], [CreateDate], [CreateUserId], [LastUpdateDate], [LastUpdateUserId]) VALUES (1, N'Administrator', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleInfo] ([UserRoleId], [UserRoleName], [CreateDate], [CreateUserId], [LastUpdateDate], [LastUpdateUserId]) VALUES (2, N'Approver', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleInfo] ([UserRoleId], [UserRoleName], [CreateDate], [CreateUserId], [LastUpdateDate], [LastUpdateUserId]) VALUES (3, N'SystemUser', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleMappingInfo] ([UserRoleMapId], [UserId], [UserRoleId], [CreatedDate], [CreatedUserId], [UpdateDate], [UpdatedUserId]) VALUES (1, 1, 1, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleMappingInfo] ([UserRoleMapId], [UserId], [UserRoleId], [CreatedDate], [CreatedUserId], [UpdateDate], [UpdatedUserId]) VALUES (2, 2, 2, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
INSERT [dbo].[UserRoleMappingInfo] ([UserRoleMapId], [UserId], [UserRoleId], [CreatedDate], [CreatedUserId], [UpdateDate], [UpdatedUserId]) VALUES (3, 3, 3, CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana', CAST(N'2015-04-01 00:00:00.000' AS DateTime), N'nkaduruwana')
ALTER TABLE [dbo].[DepartmentInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblDepartment_tblEmployee] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[EmployeesInfo] ([EmpId])
GO
ALTER TABLE [dbo].[DepartmentInfo] CHECK CONSTRAINT [FK_tblDepartment_tblEmployee]
GO
ALTER TABLE [dbo].[DepartmentInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblDepartment_tblLocation] FOREIGN KEY([LocationId])
REFERENCES [dbo].[LocationsInfo] ([LocationId])
GO
ALTER TABLE [dbo].[DepartmentInfo] CHECK CONSTRAINT [FK_tblDepartment_tblLocation]
GO
ALTER TABLE [dbo].[EmployeesInfo]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Designations] FOREIGN KEY([JobDesignationId])
REFERENCES [dbo].[DesignationsInfo] ([DesignationId])
GO
ALTER TABLE [dbo].[EmployeesInfo] CHECK CONSTRAINT [FK_Employees_Designations]
GO
ALTER TABLE [dbo].[EmployeesInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblDepartment_tblEmployees] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[EmployeesInfo] ([EmpId])
GO
ALTER TABLE [dbo].[EmployeesInfo] CHECK CONSTRAINT [FK_tblDepartment_tblEmployees]
GO
ALTER TABLE [dbo].[EmployeesInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployees_tblDepartment] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[DepartmentInfo] ([DepartmentId])
GO
ALTER TABLE [dbo].[EmployeesInfo] CHECK CONSTRAINT [FK_tblEmployees_tblDepartment]
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmpolyeeHistory_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[DepartmentInfo] ([DepartmentId])
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo] CHECK CONSTRAINT [FK_EmpolyeeHistory_Department]
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmpolyeeHistory_Designation] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[DesignationsInfo] ([DesignationId])
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo] CHECK CONSTRAINT [FK_EmpolyeeHistory_Designation]
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmpolyeeHistory_Empolyee] FOREIGN KEY([EmpId])
REFERENCES [dbo].[EmployeesInfo] ([EmpId])
GO
ALTER TABLE [dbo].[EmpolyeeHistoryInfo] CHECK CONSTRAINT [FK_EmpolyeeHistory_Empolyee]
GO
ALTER TABLE [dbo].[RoleOperationMappingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RoleOperationMappingInfo_Operation] FOREIGN KEY([OperationId])
REFERENCES [dbo].[OperationInfo] ([OperationId])
GO
ALTER TABLE [dbo].[RoleOperationMappingInfo] CHECK CONSTRAINT [FK_RoleOperationMappingInfo_Operation]
GO
ALTER TABLE [dbo].[RoleOperationMappingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RoleOperationMappingInfo_UserRoleInfoId] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRoleInfo] ([UserRoleId])
GO
ALTER TABLE [dbo].[RoleOperationMappingInfo] CHECK CONSTRAINT [FK_RoleOperationMappingInfo_UserRoleInfoId]
GO
ALTER TABLE [dbo].[UserRoleMappingInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleMappingInfo_UserInfo] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInfo] ([UserId])
GO
ALTER TABLE [dbo].[UserRoleMappingInfo] CHECK CONSTRAINT [FK_UserRoleMappingInfo_UserInfo]
GO
ALTER TABLE [dbo].[UserRoleMappingInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleMappingInfo_UserRoleInfo] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRoleInfo] ([UserRoleId])
GO
ALTER TABLE [dbo].[UserRoleMappingInfo] CHECK CONSTRAINT [FK_UserRoleMappingInfo_UserRoleInfo]
GO
USE [master]
GO
ALTER DATABASE [HrManagementDb] SET  READ_WRITE 
GO
