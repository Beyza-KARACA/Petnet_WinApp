USE [PETNET]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[AnimalID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[Age] [int] NOT NULL,
	[Kind] [nvarchar](50) NOT NULL,
	[UserID] [int] NOT NULL,
	[Which] [bit] NULL,
 CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED 
(
	[AnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bird]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bird](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Bird] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cat]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cat](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cat] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dog]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dog](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Dog] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralUser]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralUser](
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_GeneralUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici1]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici1](
	[KullaniciI_D] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Name] [nchar](10) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Birth] [datetime] NOT NULL,
	[Place] [nchar](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Kullanici1] PRIMARY KEY CLUSTERED 
(
	[KullaniciI_D] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LostAnimal]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LostAnimal](
	[LostID] [int] IDENTITY(1,1) NOT NULL,
	[AnimalID] [int] NOT NULL,
	[Place] [nvarchar](50) NULL,
	[Explanation] [nvarchar](max) NULL,
	[State] [int] NOT NULL,
	[TagID] [int] NULL,
 CONSTRAINT [PK_LostAnimal] PRIMARY KEY CLUSTERED 
(
	[LostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rehome]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rehome](
	[RehomeID] [int] IDENTITY(1,1) NOT NULL,
	[AnimalID] [int] NOT NULL,
	[TagID] [int] NULL,
	[Explanation] [nvarchar](max) NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_Rehome] PRIMARY KEY CLUSTERED 
(
	[RehomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[TagID] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nchar](10) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([UserID], [RoleID]) VALUES (1, 22)
INSERT [dbo].[Admin] ([UserID], [RoleID]) VALUES (2, 22)
SET IDENTITY_INSERT [dbo].[Animal] ON 

INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (10, 7, N'CİCİKUŞ', N'DİŞİ      ', 1, N'muhabbet', 1, NULL)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (11, 4, N'Palindrom', N'DİŞİ      ', 2, N'tekir', 2, 0)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (12, 5, N'HAVHAV', N'ERKEK     ', 3, N'kurt', 3, 1)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (13, 0, N'a', N'          ', 2, N'b', 1, 0)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (1013, 5, N'a', N'DİŞİ      ', 5, N'c', 2, 0)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (1014, 7, N'a', N'ERKEK     ', 4, N'k', 3, 1)
INSERT [dbo].[Animal] ([AnimalID], [TypeID], [FullName], [Gender], [Age], [Kind], [UserID], [Which]) VALUES (1015, 0, N'a', N'          ', 1, N'a', 1, 0)
SET IDENTITY_INSERT [dbo].[Animal] OFF
SET IDENTITY_INSERT [dbo].[Bird] ON 

INSERT [dbo].[Bird] ([TypeID], [TypeName]) VALUES (7, N'KUŞ       ')
SET IDENTITY_INSERT [dbo].[Bird] OFF
SET IDENTITY_INSERT [dbo].[Cat] ON 

INSERT [dbo].[Cat] ([TypeID], [TypeName]) VALUES (4, N'kedi')
SET IDENTITY_INSERT [dbo].[Cat] OFF
SET IDENTITY_INSERT [dbo].[Dog] ON 

INSERT [dbo].[Dog] ([TypeID], [TypeName]) VALUES (5, N'Köpek     ')
SET IDENTITY_INSERT [dbo].[Dog] OFF
INSERT [dbo].[GeneralUser] ([UserID], [RoleID]) VALUES (3, 24)
SET IDENTITY_INSERT [dbo].[Kullanici1] ON 

INSERT [dbo].[Kullanici1] ([KullaniciI_D], [Kullanici_Name], [Password], [FullName], [Birth], [Place], [Email], [RoleID]) VALUES (1, N'Beyza     ', N'1234', N'Beyza KARACA', CAST(N'1998-12-05T00:00:00.000' AS DateTime), N'Sakarya   ', N'byz@gmail.com', 22)
INSERT [dbo].[Kullanici1] ([KullaniciI_D], [Kullanici_Name], [Password], [FullName], [Birth], [Place], [Email], [RoleID]) VALUES (2, N'Ece       ', N'1234', N'Ece Nur', CAST(N'1999-03-05T00:00:00.000' AS DateTime), N'İstanbul  ', N'ece@gmail.com', 22)
INSERT [dbo].[Kullanici1] ([KullaniciI_D], [Kullanici_Name], [Password], [FullName], [Birth], [Place], [Email], [RoleID]) VALUES (3, N'Zeynep    ', N'1234', N'Zeynep Burcu BAŞTUĞ', CAST(N'1998-05-26T00:00:00.000' AS DateTime), N'Çarşamba  ', N'zeynep@gmail.com', 24)
INSERT [dbo].[Kullanici1] ([KullaniciI_D], [Kullanici_Name], [Password], [FullName], [Birth], [Place], [Email], [RoleID]) VALUES (4, N'Ayşe      ', N'1234', N'Ayşe Deneme', CAST(N'2019-12-16T00:00:00.000' AS DateTime), N'Sakarya   ', N'deneme@gmail.com', 24)
INSERT [dbo].[Kullanici1] ([KullaniciI_D], [Kullanici_Name], [Password], [FullName], [Birth], [Place], [Email], [RoleID]) VALUES (5, N'Veli      ', N'1234', N'Veli Dnm', CAST(N'2019-12-16T00:00:00.000' AS DateTime), N'x         ', N'dnm@gmail.com', 24)
SET IDENTITY_INSERT [dbo].[Kullanici1] OFF
SET IDENTITY_INSERT [dbo].[LostAnimal] ON 

INSERT [dbo].[LostAnimal] ([LostID], [AnimalID], [Place], [Explanation], [State], [TagID]) VALUES (3, 11, N'İSTANBUL', N'kayboldu', -1, 9)
INSERT [dbo].[LostAnimal] ([LostID], [AnimalID], [Place], [Explanation], [State], [TagID]) VALUES (1003, 1013, N'Sakaraya', N'a', 0, 9)
SET IDENTITY_INSERT [dbo].[LostAnimal] OFF
SET IDENTITY_INSERT [dbo].[Rehome] ON 

INSERT [dbo].[Rehome] ([RehomeID], [AnimalID], [TagID], [Explanation], [State]) VALUES (5, 12, 8, N'sahipsiz', -1)
INSERT [dbo].[Rehome] ([RehomeID], [AnimalID], [TagID], [Explanation], [State]) VALUES (1003, 1014, 9, N'a', 0)
SET IDENTITY_INSERT [dbo].[Rehome] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (22, N'Admin     ')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (24, N'General   ')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Tag] ON 

INSERT [dbo].[Tag] ([TagID], [Tag]) VALUES (7, N'cicikuş   ')
INSERT [dbo].[Tag] ([TagID], [Tag]) VALUES (8, N'usluköpek ')
INSERT [dbo].[Tag] ([TagID], [Tag]) VALUES (9, N'miyav     ')
SET IDENTITY_INSERT [dbo].[Tag] OFF
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([TypeID], [TypeName]) VALUES (4, N'Kedi      ')
INSERT [dbo].[Type] ([TypeID], [TypeName]) VALUES (5, N'Köpek     ')
INSERT [dbo].[Type] ([TypeID], [TypeName]) VALUES (7, N'Kuş       ')
SET IDENTITY_INSERT [dbo].[Type] OFF
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Kullanici1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Kullanici1] ([KullaniciI_D])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Kullanici1]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Kullanici1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Kullanici1] ([KullaniciI_D])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Kullanici1]
GO
ALTER TABLE [dbo].[Bird]  WITH CHECK ADD  CONSTRAINT [FK_Bird_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([TypeID])
GO
ALTER TABLE [dbo].[Bird] CHECK CONSTRAINT [FK_Bird_Type]
GO
ALTER TABLE [dbo].[Cat]  WITH CHECK ADD  CONSTRAINT [FK_Cat_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([TypeID])
GO
ALTER TABLE [dbo].[Cat] CHECK CONSTRAINT [FK_Cat_Type]
GO
ALTER TABLE [dbo].[Dog]  WITH CHECK ADD  CONSTRAINT [FK_Dog_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([TypeID])
GO
ALTER TABLE [dbo].[Dog] CHECK CONSTRAINT [FK_Dog_Type]
GO
ALTER TABLE [dbo].[GeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GeneralUser_Kullanici1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Kullanici1] ([KullaniciI_D])
GO
ALTER TABLE [dbo].[GeneralUser] CHECK CONSTRAINT [FK_GeneralUser_Kullanici1]
GO
ALTER TABLE [dbo].[Kullanici1]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici1_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Kullanici1] CHECK CONSTRAINT [FK_Kullanici1_Role]
GO
ALTER TABLE [dbo].[LostAnimal]  WITH CHECK ADD  CONSTRAINT [FK_LostAnimal_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LostAnimal] CHECK CONSTRAINT [FK_LostAnimal_Animal]
GO
ALTER TABLE [dbo].[LostAnimal]  WITH CHECK ADD  CONSTRAINT [FK_LostAnimal_Tag] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tag] ([TagID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LostAnimal] CHECK CONSTRAINT [FK_LostAnimal_Tag]
GO
ALTER TABLE [dbo].[Rehome]  WITH CHECK ADD  CONSTRAINT [FK_Rehome_Animal] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animal] ([AnimalID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rehome] CHECK CONSTRAINT [FK_Rehome_Animal]
GO
ALTER TABLE [dbo].[Rehome]  WITH CHECK ADD  CONSTRAINT [FK_Rehome_Tag] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tag] ([TagID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rehome] CHECK CONSTRAINT [FK_Rehome_Tag]
GO
/****** Object:  StoredProcedure [dbo].[AnimalEkle]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AnimalEkle]
	@TypeID INT,
	@FullName  NVARCHAR (50),
	@Gender NCHAR (10),
	@Age  INT ,
	@Kind  NVARCHAR (50),
	@UserID INT,
	@Which BIT
AS
 
insert into Animal values(@TypeID,@FullName,@Gender,@Age,@Kind,@UserID,@Which);

RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[KayipGuncelle]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KayipGuncelle]
(
	@LostID int
 
)
AS
BEGIN

  Update LostAnimal SET State=0
  WHERE LostID=@LostID

END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KullaniciEkle]
	@Kullanici_Name nchar(10),
	@Password nvarchar(50),
	@FullName nvarchar(50),
	@Birth datetime,
	@Place nchar(10),
	@Email nvarchar(50),
	@RoleID int=24
AS
	insert into Kullanici1 values(@Kullanici_Name,@Password,@FullName,@Birth,@Place,@Email,@RoleID);
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[LostList]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LostList]
	
AS

SELECT LostAnimal.Explanation,Animal.Age,Animal.FullName,Animal.Gender,Animal.Kind,Tag.Tag,Kullanici1.Kullanici_Name,Kullanici1.Email,Type.TypeName,LostAnimal.State
From (((( Animal
INNER JOIN LostAnimal ON LostAnimal.AnimalID=Animal.AnimalID)
INNER JOIN Tag ON LostAnimal.TagID=Tag.TagID)
INNER JOIN Kullanici1 ON Animal.UserID=Kullanici1.KullaniciI_D)
INNER JOIN Type ON Animal.TypeID=Type.TypeID) WHERE LostAnimal.State=-1;
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[RehomeList]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RehomeList]
	
AS

SELECT Rehome.Explanation,Animal.Age,Animal.FullName,Animal.Gender,Animal.Kind,Tag.Tag,Kullanici1.Kullanici_Name,Kullanici1.Email,Type.TypeName
From (((( Animal
INNER JOIN Rehome ON Rehome.AnimalID=Animal.AnimalID)
INNER JOIN Tag ON Rehome.TagID=Tag.TagID)
INNER JOIN Kullanici1 ON Animal.UserID=Kullanici1.KullaniciI_D)
INNER JOIN Type ON Animal.TypeID=Type.TypeID) WHERE Rehome.State=-1;
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[YoneticiLost]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YoneticiLost]
	
AS

SELECT LostAnimal.Explanation,Animal.Age,Animal.FullName,Animal.Gender,Animal.Kind,Tag.Tag,Kullanici1.Kullanici_Name,Kullanici1.Email
From ((( Animal
INNER JOIN LostAnimal ON LostAnimal.AnimalID=Animal.AnimalID)
INNER JOIN Tag ON LostAnimal.TagID=Tag.TagID)
INNER JOIN Kullanici1 ON Animal.UserID=Kullanici1.KullaniciI_D) WHERE LostAnimal.State=0;

RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[YoneticiRehome]    Script Date: 16.12.2019 13:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YoneticiRehome]
	
AS

SELECT Rehome.Explanation,Animal.Age,Animal.FullName,Animal.Gender,Animal.Kind,Tag.Tag,Kullanici1.Kullanici_Name,Kullanici1.Email
From ((( Animal
INNER JOIN Rehome ON Rehome.AnimalID=Animal.AnimalID)
INNER JOIN Tag ON Rehome.TagID=Tag.TagID)
INNER JOIN Kullanici1 ON Animal.UserID=Kullanici1.KullaniciI_D) WHERE Rehome.State=0;

RETURN 0
GO
/****** Object:  DdlTrigger [DatabaseTrigger]    Script Date: 16.12.2019 13:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [DatabaseTrigger]
ON DATABASE
FOR DDL_TABLE_VIEW_EVENTS
AS
BEGIN
	SET NOCOUNT ON
END
GO
DISABLE TRIGGER [DatabaseTrigger] ON DATABASE
GO
