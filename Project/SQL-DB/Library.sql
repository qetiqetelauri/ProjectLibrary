USE [master]
GO
/****** Object:  Database [Library]    Script Date: 1/21/2019 5:43:31 PM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.QETI\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.QETI\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY FULL 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET QUERY_STORE = OFF
GO
USE [Library]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 1/21/2019 5:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorFirstName] [varchar](50) NOT NULL,
	[AuthorLastName] [varchar](50) NOT NULL,
	[AuthorBirthDate] [date] NOT NULL,
 CONSTRAINT [PK_Authors_1] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 1/21/2019 5:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](50) NOT NULL,
	[BookReleaseDate] [date] NOT NULL,
	[BookAuthorID] [int] NOT NULL,
	[BookPublishHouse] [varchar](50) NOT NULL,
	[BookUserID] [int] NULL,
	[BookUserTime] [date] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 1/21/2019 5:43:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[RequestDate] [date] NOT NULL,
	[RequestStatus] [bit] NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/21/2019 5:43:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserFirstName] [varchar](50) NOT NULL,
	[UserLastName] [varchar](50) NOT NULL,
	[UserMail] [varchar](50) NOT NULL,
	[UserPhoneNumber] [int] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[UserPassword] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorID], [AuthorFirstName], [AuthorLastName], [AuthorBirthDate]) VALUES (1, N'JK', N'Roulingg', CAST(N'1998-07-16' AS Date))
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (2, N'Harry Potteri', CAST(N'1998-07-16' AS Date), 1, N'saba', 2, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1007, N'nlkn', CAST(N'2019-01-16' AS Date), 1, N'bjbj', NULL, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1012, N'nkln', CAST(N'2019-01-20' AS Date), 1, N'nkn', NULL, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1014, N'knlk', CAST(N'2019-01-20' AS Date), 1, N'fg', NULL, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1015, N'me', CAST(N'2019-01-20' AS Date), 1, N'var', NULL, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1016, N'vai', CAST(N'2019-01-20' AS Date), 1, N'va', NULL, NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [BookReleaseDate], [BookAuthorID], [BookPublishHouse], [BookUserID], [BookUserTime]) VALUES (1017, N'svkn', CAST(N'2019-01-21' AS Date), 1, N'sdg', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Requests] ON 

INSERT [dbo].[Requests] ([RequestID], [UserID], [BookID], [RequestDate], [RequestStatus]) VALUES (13, 2, 2, CAST(N'2019-01-19' AS Date), 1)
INSERT [dbo].[Requests] ([RequestID], [UserID], [BookID], [RequestDate], [RequestStatus]) VALUES (15, 2, 1007, CAST(N'2019-01-21' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Requests] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName], [UserMail], [UserPhoneNumber], [IsAdmin], [UserPassword]) VALUES (1, N'qeti', N'qetelauri', N'qetiqetelauri@gmail.com', 0, 1, N'123456789')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName], [UserMail], [UserPhoneNumber], [IsAdmin], [UserPassword]) VALUES (2, N'bla', N'blu', N'bla@gmail.com', 0, 0, N'123456789')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName], [UserMail], [UserPhoneNumber], [IsAdmin], [UserPassword]) VALUES (3, N'ui', N'ai', N'ui@gmail.com', 0, 0, N'123456789')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([BookAuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Users] FOREIGN KEY([BookUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Users]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_book_request] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_book_request]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_User_Request] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_User_Request]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
