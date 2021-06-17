/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server Local
 Source Server Type    : SQL Server
 Source Server Version : 14003370
 Source Host           : 0.0.0.0:1433
 Source Catalog        : UC10Project
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14003370
 File Encoding         : 65001

 Date: 17/06/2021 08:51:43
*/


-- ----------------------------
-- Table structure for Person
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type IN ('U'))
	DROP TABLE [dbo].[Person]
GO

CREATE TABLE [dbo].[Person] (
  [person_id] bigint  IDENTITY(1,1) NOT NULL,
  [name] varchar(80) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [telephone] bigint  NULL,
  [number] int  NULL,
  [address] varchar(80) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [city] varchar(80) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [state] varchar(80) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Person] SET (LOCK_ESCALATION = DISABLE)
GO


-- ----------------------------
-- Records of Person
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Person] ON
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'1', N'Reginaldo Morikawa', N'17981462389', N'2495', N'Rua General Osório', N'São José do Rio Preto', N'São Paulo')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'2', N'Nikola Tesla', N'17999999999', N'51', N'Krunska Street', N'Belgrade', N'São Paulo')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'3', N'Carl Sagan', N'17888888888', N'900', N'Stewart Avenue', N'Ithaca', N'New York')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'4', N'Nicolau Copérnico', N'17777777777', N'15', N'ul. Zólkiewskiego', N'Torun', N'Kujawsko-Pomorskie')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'5', N'Albert Einsten', N'17666666666', N'3005', N'Helvetiaplatz 5?', N'Bern', N'Canton of Bern')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'6', N'Isaac Newton', N'17555555555', N'2', N'Water Ln', N'Woolsthorpe-by-Colsterworth', N'Lincolnshire')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'7', N'Platão', N'17444444444', N'44', N'28th of October', N'Athens', N'Athens 106 82')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'8', N'Peter Trovão', N'17999996666', N'3518', N'Rua Jorge Tibiriçá', N'São José do Rio Preto', N'São Paulo')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'9', N'Alexandre Dionizio', N'17999998888', N'3518', N'Rua Jorge Tibiriçá', N'São José do Rio Preto', N'São Paulo')
GO

INSERT INTO [dbo].[Person] ([person_id], [name], [telephone], [number], [address], [city], [state]) VALUES (N'10', N'Pedro Carvalho', N'17999997777', N'3518', N'Rua Jorge Tibiriçá', N'São José do Rio Preto', N'São Paulo')
GO

SET IDENTITY_INSERT [dbo].[Person] OFF
GO

COMMIT
GO


-- ----------------------------
-- Auto increment value for Person
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Person]', RESEED, 10)
GO


-- ----------------------------
-- Primary Key structure for table Person
-- ----------------------------
ALTER TABLE [dbo].[Person] ADD CONSTRAINT [PK__Person__543848DFA335F973] PRIMARY KEY CLUSTERED ([person_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

