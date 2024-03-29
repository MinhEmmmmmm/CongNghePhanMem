USE [master]
GO
/****** Object:  Database [QLShopMoHinh]    Script Date: 10/24/2023 10:13:50 PM ******/
CREATE DATABASE [QLShopMoHinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLShopMoHinh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MAY1\MSSQL\DATA\QLShopMoHinh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLShopMoHinh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MAY1\MSSQL\DATA\QLShopMoHinh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLShopMoHinh] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLShopMoHinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLShopMoHinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLShopMoHinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLShopMoHinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLShopMoHinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLShopMoHinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLShopMoHinh] SET  MULTI_USER 
GO
ALTER DATABASE [QLShopMoHinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLShopMoHinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLShopMoHinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLShopMoHinh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLShopMoHinh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLShopMoHinh] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLShopMoHinh] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLShopMoHinh] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLShopMoHinh]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[ClientID] [nvarchar](50) NOT NULL,
	[TaltolMoney] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[ToltalMoney] [int] NOT NULL,
	[RankID] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientRank]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientRank](
	[ID] [int] NOT NULL,
	[Rank] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ClientRank] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID] [nvarchar](50) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Inventory] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 10/24/2023 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([ID], [Date], [ClientID], [TaltolMoney]) VALUES (1, CAST(N'2023-10-23' AS Date), N'2', N'1500000')
INSERT [dbo].[Bill] ([ID], [Date], [ClientID], [TaltolMoney]) VALUES (2, CAST(N'2023-10-24' AS Date), N'3', N'11700000')
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
INSERT [dbo].[Class] ([ID], [Name]) VALUES (1, N'Mô hình khủng lông')
INSERT [dbo].[Class] ([ID], [Name]) VALUES (2, N'Mô hình Onepice')
INSERT [dbo].[Class] ([ID], [Name]) VALUES (3, N'mô hình mini')
GO
INSERT [dbo].[Client] ([ID], [FullName], [Address], [ToltalMoney], [RankID], [PhoneNumber]) VALUES (N'1', N'Mai Văn Tùng', N'Xóm cờ bạc', 15000000, 4, N'0950768105')
INSERT [dbo].[Client] ([ID], [FullName], [Address], [ToltalMoney], [RankID], [PhoneNumber]) VALUES (N'2', N'Hoàng Văn Ngọc', N'Xóm nợ', 1500000, 1, N'0943058318')
INSERT [dbo].[Client] ([ID], [FullName], [Address], [ToltalMoney], [RankID], [PhoneNumber]) VALUES (N'3', N'Mai Xuân Trường', N'Xóm đần', 11700000, 2, N'0975603571')
INSERT [dbo].[Client] ([ID], [FullName], [Address], [ToltalMoney], [RankID], [PhoneNumber]) VALUES (N'4', N'Bùi Huy Hoàng', N'Xóm đần', 0, 1, N'0976413058')
GO
INSERT [dbo].[ClientRank] ([ID], [Rank]) VALUES (1, N'Normal    ')
INSERT [dbo].[ClientRank] ([ID], [Rank]) VALUES (2, N'Silver    ')
INSERT [dbo].[ClientRank] ([ID], [Rank]) VALUES (3, N'Gold      ')
INSERT [dbo].[ClientRank] ([ID], [Rank]) VALUES (4, N'Diamond   ')
GO
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'KL001', N'T-Rex 1 :35', 1500000, 19, 1)
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'KL002', N'Trikeratop 1:16', 1250000, 18, 1)
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'MN001', N'Goku táo bón', 800000, 17, 3)
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'MN002', N'Conan', 750000, 20, 3)
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'OP001', N'Donut lửa 1;6', 1000000, 18, 2)
INSERT [dbo].[Item] ([ID], [ItemName], [Price], [Inventory], [ClassID]) VALUES (N'OP002', N'Sank 2 tay 1;4', 1200000, 16, 2)
GO
INSERT [dbo].[Staff] ([ID], [UserName], [FullName], [Password], [Type]) VALUES (N'001', N'nam123', N'Lê Nguyễn Nhật Nam', N'123       ', 1)
INSERT [dbo].[Staff] ([ID], [UserName], [FullName], [Password], [Type]) VALUES (N'002', N'minh123', N'Nguyễn Thanh Minh', N'123       ', 0)
INSERT [dbo].[Staff] ([ID], [UserName], [FullName], [Password], [Type]) VALUES (N'003', N'vu123', N'Nguyễn Phi Vũ', N'123       ', 0)
INSERT [dbo].[Staff] ([ID], [UserName], [FullName], [Password], [Type]) VALUES (N'004', N'trung123', N'Doãn thành Trung', N'123       ', 0)
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Client]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientRank] FOREIGN KEY([RankID])
REFERENCES [dbo].[ClientRank] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientRank]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Class]
GO
USE [master]
GO
ALTER DATABASE [QLShopMoHinh] SET  READ_WRITE 
GO
