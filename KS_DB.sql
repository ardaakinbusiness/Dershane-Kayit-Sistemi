USE [master]
GO
ALTER DATABASE [KS_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KS_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KS_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KS_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KS_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KS_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KS_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KS_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KS_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KS_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KS_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KS_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KS_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KS_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KS_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KS_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KS_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KS_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KS_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KS_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KS_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KS_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KS_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [KS_DB] SET  MULTI_USER 
GO
ALTER DATABASE [KS_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KS_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KS_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KS_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KS_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KS_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'KS_DB', N'ON'
GO
ALTER DATABASE [KS_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [KS_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [KS_DB]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[DersAdi] [nvarchar](50) NOT NULL,
	[DersGunu] [nvarchar](200) NOT NULL,
	[KursID] [int] NOT NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DersNotu]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DersNotu](
	[DersID] [int] NOT NULL,
	[OgrenciID] [int] NOT NULL,
	[DersNotu] [float] NOT NULL,
 CONSTRAINT [PK_DersNotu_1] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC,
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egitmen]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egitmen](
	[KullaniciID] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](100) NOT NULL,
	[TC] [char](11) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CepTelefonu] [char](14) NOT NULL,
	[Adres] [nvarchar](500) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
 CONSTRAINT [PK_Egitmen_1] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EgitmenMaasi]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EgitmenMaasi](
	[MaasID] [int] IDENTITY(1,1) NOT NULL,
	[EgitmenID] [int] NOT NULL,
	[Maas] [bigint] NOT NULL,
	[Yil] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Sifre] [varchar](50) NOT NULL,
	[Rol] [int] NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[KursAdi] [nvarchar](50) NOT NULL,
	[BaslangicTarihi] [date] NOT NULL,
	[KursKontenjani] [int] NOT NULL,
	[EgitmenID] [int] NOT NULL,
 CONSTRAINT [PK_Kurs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[KullaniciID] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[TC] [char](11) NOT NULL,
	[CepTelefonu] [char](14) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
	[Adres] [nvarchar](500) NOT NULL,
	[KursID] [int] NOT NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetim]    Script Date: 14.01.2024 09:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetim](
	[KullaniciID] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](100) NOT NULL,
	[TC] [char](11) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CepTelefonu] [char](14) NOT NULL,
 CONSTRAINT [PK_Yonetim] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ders] ON 
GO
INSERT [dbo].[Ders] ([ID], [DersAdi], [DersGunu], [KursID]) VALUES (100, N'C#', N'Cumartesi: 10:00 - 13:00 , Pazar: 10:00 - 13:00', 100)
GO
INSERT [dbo].[Ders] ([ID], [DersAdi], [DersGunu], [KursID]) VALUES (101, N'SQL', N'Cumartesi: 10:00 - 13:00 , Pazar: 10:00 - 13:00', 100)
GO
INSERT [dbo].[Ders] ([ID], [DersAdi], [DersGunu], [KursID]) VALUES (102, N'Web', N'Cumartesi: 10:00 - 13:00 , Pazar: 10:00 - 13:00', 101)
GO
INSERT [dbo].[Ders] ([ID], [DersAdi], [DersGunu], [KursID]) VALUES (103, N'Python', N'Cuma: 10:00 - 13:30 ,
 
Pazar: 9:00 - 12:30', 101)
GO
SET IDENTITY_INSERT [dbo].[Ders] OFF
GO
INSERT [dbo].[DersNotu] ([DersID], [OgrenciID], [DersNotu]) VALUES (100, 103, 95.236)
GO
INSERT [dbo].[DersNotu] ([DersID], [OgrenciID], [DersNotu]) VALUES (101, 103, 74.5)
GO
INSERT [dbo].[Egitmen] ([KullaniciID], [Ad], [Soyad], [TC], [Email], [CepTelefonu], [Adres], [DogumTarihi]) VALUES (105, N'Hessam', N'Mamagani', N'11111111111', N'hessam.akademi@gmail.com', N'(539) 229-4251', N'Istanbul', CAST(N'1984-12-31' AS Date))
GO
INSERT [dbo].[Egitmen] ([KullaniciID], [Ad], [Soyad], [TC], [Email], [CepTelefonu], [Adres], [DogumTarihi]) VALUES (106, N'Ali', N'Veli', N'22222222222', N'ali.veli@gmail.com', N'(543) 116-5651', N'Izmir', CAST(N'1992-04-03' AS Date))
GO
INSERT [dbo].[Egitmen] ([KullaniciID], [Ad], [Soyad], [TC], [Email], [CepTelefonu], [Adres], [DogumTarihi]) VALUES (107, N'Ahmet', N'', N'           ', N'', N'(5  )    -    ', N'', CAST(N'2024-01-13' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 
GO
INSERT [dbo].[Kullanici] ([ID], [KullaniciAdi], [Sifre], [Rol]) VALUES (100, N'admin', N'admin', 2)
GO
INSERT [dbo].[Kullanici] ([ID], [KullaniciAdi], [Sifre], [Rol]) VALUES (103, N'zeynep', N'111', 0)
GO
INSERT [dbo].[Kullanici] ([ID], [KullaniciAdi], [Sifre], [Rol]) VALUES (105, N'hessam', N'123', 1)
GO
INSERT [dbo].[Kullanici] ([ID], [KullaniciAdi], [Sifre], [Rol]) VALUES (106, N'aliveli', N'222', 0)
GO
INSERT [dbo].[Kullanici] ([ID], [KullaniciAdi], [Sifre], [Rol]) VALUES (107, N'Ahmet', N'123', 1)
GO
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Kurs] ON 
GO
INSERT [dbo].[Kurs] ([ID], [KursAdi], [BaslangicTarihi], [KursKontenjani], [EgitmenID]) VALUES (100, N'Yazılım', CAST(N'2023-08-01' AS Date), 30, 105)
GO
INSERT [dbo].[Kurs] ([ID], [KursAdi], [BaslangicTarihi], [KursKontenjani], [EgitmenID]) VALUES (101, N'Yazılım', CAST(N'2024-02-01' AS Date), 35, 106)
GO
INSERT [dbo].[Kurs] ([ID], [KursAdi], [BaslangicTarihi], [KursKontenjani], [EgitmenID]) VALUES (102, N'Yapay Zeka', CAST(N'2024-02-01' AS Date), 10, 105)
GO
SET IDENTITY_INSERT [dbo].[Kurs] OFF
GO
INSERT [dbo].[Ogrenci] ([KullaniciID], [Ad], [Soyad], [Email], [TC], [CepTelefonu], [DogumTarihi], [Adres], [KursID]) VALUES (103, N'Zeynep', N'Arslan', N'za@gmail.com', N'12332145678', N'05478542131   ', CAST(N'1996-03-29' AS Date), N'Istanbul - Türkiye', 100)
GO
INSERT [dbo].[Yonetim] ([KullaniciID], [Ad], [Soyad], [TC], [Email], [CepTelefonu]) VALUES (100, N'Admin', N'Admin', N'00000000000', N'admin@gmail.com', N'(541) 487-1521')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Kullanici]    Script Date: 14.01.2024 09:57:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Kullanici] ON [dbo].[Kullanici]
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_Kurs] FOREIGN KEY([KursID])
REFERENCES [dbo].[Kurs] ([ID])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_Kurs]
GO
ALTER TABLE [dbo].[DersNotu]  WITH CHECK ADD  CONSTRAINT [FK_DersNotu_Ders] FOREIGN KEY([DersID])
REFERENCES [dbo].[Ders] ([ID])
GO
ALTER TABLE [dbo].[DersNotu] CHECK CONSTRAINT [FK_DersNotu_Ders]
GO
ALTER TABLE [dbo].[DersNotu]  WITH CHECK ADD  CONSTRAINT [FK_DersNotu_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([KullaniciID])
GO
ALTER TABLE [dbo].[DersNotu] CHECK CONSTRAINT [FK_DersNotu_Ogrenci]
GO
ALTER TABLE [dbo].[Egitmen]  WITH CHECK ADD  CONSTRAINT [FK_Egitmen_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([ID])
GO
ALTER TABLE [dbo].[Egitmen] CHECK CONSTRAINT [FK_Egitmen_Kullanici]
GO
ALTER TABLE [dbo].[EgitmenMaasi]  WITH CHECK ADD  CONSTRAINT [FK_EgitmenMaasi_Egitmen] FOREIGN KEY([EgitmenID])
REFERENCES [dbo].[Egitmen] ([KullaniciID])
GO
ALTER TABLE [dbo].[EgitmenMaasi] CHECK CONSTRAINT [FK_EgitmenMaasi_Egitmen]
GO
ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_Egitmen] FOREIGN KEY([EgitmenID])
REFERENCES [dbo].[Egitmen] ([KullaniciID])
GO
ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_Egitmen]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([ID])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_Kullanici]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_Kurs] FOREIGN KEY([KursID])
REFERENCES [dbo].[Kurs] ([ID])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_Kurs]
GO
ALTER TABLE [dbo].[Yonetim]  WITH CHECK ADD  CONSTRAINT [FK_Yonetim_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([ID])
GO
ALTER TABLE [dbo].[Yonetim] CHECK CONSTRAINT [FK_Yonetim_Kullanici]
GO
USE [master]
GO
ALTER DATABASE [KS_DB] SET  READ_WRITE 
GO
