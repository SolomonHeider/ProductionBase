USE [master]
GO
/****** Object:  Database [Production]    Script Date: 06.10.2022 23:09:00 ******/
CREATE DATABASE [Production]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Production', FILENAME = N'D:\Program Files (x86)\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Production.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Production_log', FILENAME = N'D:\Program Files (x86)\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Production_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Production] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Production].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Production] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Production] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Production] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Production] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Production] SET ARITHABORT OFF 
GO
ALTER DATABASE [Production] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Production] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Production] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Production] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Production] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Production] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Production] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Production] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Production] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Production] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Production] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Production] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Production] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Production] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Production] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Production] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Production] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Production] SET RECOVERY FULL 
GO
ALTER DATABASE [Production] SET  MULTI_USER 
GO
ALTER DATABASE [Production] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Production] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Production] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Production] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Production] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Production] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Production', N'ON'
GO
ALTER DATABASE [Production] SET QUERY_STORE = OFF
GO
USE [Production]
GO
/****** Object:  Table [dbo].[ChangeLog]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChangeLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChangeDate] [datetime] NOT NULL,
	[TableName] [varchar](50) NOT NULL,
	[RecordKey] [varchar](50) NOT NULL,
	[FieldName] [varchar](50) NULL,
	[OldValue] [varchar](150) NULL,
	[NewValue] [varchar](150) NULL,
	[ChangeType] [char](1) NOT NULL,
 CONSTRAINT [PK_ChangeLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Component]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Component](
	[Code] [varchar](30) NOT NULL,
	[Amount] [decimal](18, 8) NOT NULL,
	[ProductCode] [varchar](30) NOT NULL,
	[ComponentCode] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Components]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Components](
	[Code] [char](30) NOT NULL,
	[Amount] [decimal](18, 8) NOT NULL,
	[ProductCode] [varchar](30) NOT NULL,
	[ComponentCode] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Components] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Code] [varchar](30) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Unit] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp1', CAST(1.00000000 AS Decimal(18, 8)), N'Prod0', N'Prod1')
INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp2', CAST(1.00000000 AS Decimal(18, 8)), N'Prod0', N'Prod2')
INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp3', CAST(2.00000000 AS Decimal(18, 8)), N'Prod1', N'Prod3')
INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp4', CAST(10.00000000 AS Decimal(18, 8)), N'Prod1', N'Prod4')
INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp5', CAST(3.00000000 AS Decimal(18, 8)), N'Prod2', N'Prod5')
INSERT [dbo].[Component] ([Code], [Amount], [ProductCode], [ComponentCode]) VALUES (N'Comp6', CAST(2.00000000 AS Decimal(18, 8)), N'Prod7', N'Prod4')
GO
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod0', N'Изделие 0', N'шт ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod1', N'Изделие 1', N'шт ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod2', N'Изделие 2', N'шт ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod3', N'Изделие 3', N'шт ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod4', N'Изделие 4', N'гр ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod5', N'Изделие 5', N'кг ')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod6', N'Изделие 6', N'шт')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod7', N'Изделие 7', N'шт')
INSERT [dbo].[Product] ([Code], [Name], [Unit]) VALUES (N'Prod8', N'Изделие 8', N'кг')
GO
ALTER TABLE [dbo].[Component]  WITH CHECK ADD  CONSTRAINT [FK_Components_Product] FOREIGN KEY([ComponentCode])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Component] CHECK CONSTRAINT [FK_Components_Product]
GO
ALTER TABLE [dbo].[Component]  WITH CHECK ADD  CONSTRAINT [FK_Components_Product1] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Component] CHECK CONSTRAINT [FK_Components_Product1]
GO
ALTER TABLE [dbo].[Components]  WITH CHECK ADD  CONSTRAINT [FK_Components_Product2] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Components] CHECK CONSTRAINT [FK_Components_Product2]
GO
ALTER TABLE [dbo].[Components]  WITH CHECK ADD  CONSTRAINT [FK_Components_Product3] FOREIGN KEY([ComponentCode])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Components] CHECK CONSTRAINT [FK_Components_Product3]
GO
/****** Object:  StoredProcedure [dbo].[AddComponent]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddComponent]
@Code varchar(30),
@Amount decimal(18,8),
@ProdCode varchar(30),
@CompCode varchar(30)
As
insert into Component
values (@Code, @Amount, @ProdCode, @CompCode)
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddProduct]
@Code VARCHAR(30),
@Name VARCHAR(150),
@Unit VARCHAR(2)
AS
Insert into Product
values (@Code, @Name, @Unit)
GO
/****** Object:  StoredProcedure [dbo].[DeleteComponent]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DeleteComponent]
@Code varchar(30)
As
delete from Component
where Code = @Code
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteProduct]
@Code VARCHAR(30)
AS
Delete from Product
where Code = @Code
GO
/****** Object:  StoredProcedure [dbo].[GetChangeLogByCode]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetChangeLogByCode]
@code VARCHAR(30),
@table VARCHAR(10)
AS
select Id, ChangeDate, TableName, RecordKey, FieldName, OldValue, NewValue,
CASE
    WHEN ChangeType = 'I' THEN 'Добавление'
    WHEN ChangeType = 'D' THEN 'Удаление'
	WHEN ChangeType = 'U' THEN 'Обновление'
  END ChangeType
  from ChangeLog
where RecordKey = @code and TableName = @table
GO
/****** Object:  StoredProcedure [dbo].[GetHierarchyFromLeaf]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetHierarchyFromLeaf]
@Code varchar(30)
as
with tree (Code) as
(
	select p.Code
	FROM Product p
	where p.Code = @Code

	UNION ALL

	select c.ProductCode
	FROM tree t inner join Component c on t.Code = c.ComponentCode inner join Product p1 on c.ProductCode = p1.Code inner join Product p on c.ComponentCode = p.Code 
)

select * from tree
GO
/****** Object:  StoredProcedure [dbo].[GetPossibleComponents]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetPossibleComponents]
@code VARCHAR(30)
As
declare @Hierarchy table (Code Varchar(30))
Insert @Hierarchy
exec GetHierarchyFromLeaf @code

select Code As Product from product
except
select c.ComponentCode As Product from product p
inner join Component c on p.Code = c.ProductCode inner join product p1 on p1.Code = c.ComponentCode
where c.ProductCode = @code
except select * from @Hierarchy 
GO
/****** Object:  StoredProcedure [dbo].[GetProductCodeBycomponentCode]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetProductCodeBycomponentCode]
@Code varchar(30)
as
select ComponentCode from Component where code = @Code
GO
/****** Object:  StoredProcedure [dbo].[GetProductComponentsByCode]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetProductComponentsByCode]
@code VARCHAR(30)
AS
select c.Code, p.Name, c.Amount, p.Unit 
from Component c inner join Product p on c.ComponentCode = p.Code
where c.ProductCode = @code
GO
/****** Object:  StoredProcedure [dbo].[GetProductUnitByCode]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetProductUnitByCode]
@Code varchar(30)
as
select Unit from Product where code = @Code
GO
/****** Object:  StoredProcedure [dbo].[GetTreeViewCTE]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetTreeViewCTE]
@code VARCHAR(30)
AS
with tree (CompCode, Level, Code, Name, Amount, Unit, Path) as
(
	select cast('' as varchar(30)), 0, p.Code, p.Name, CAST(0 AS DECIMAL(18,8)), p.Unit, CAST('' AS VARCHAR(max))
	FROM Product p
	where p.Code = @code

	UNION ALL

	select c.Code, t.Level + 1, c.ComponentCode, p.Name, c.Amount, p.Unit, t.path + p.Name
	FROM tree t inner join Component c on t.Code = c.ProductCode inner join Product p on c.ComponentCode = p.Code inner join Product p1 on c.ProductCode = p1.Code
)

select Cast(SPACE(level) + code as varchar(max)) As Code, Name, Amount, Unit, level 
from tree
order by path
GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[test]
@code varchar(30)
as
DECLARE @Tree TABLE (Number int, Code varchar(30))
insert @Tree
select ROW_NUMBER() over (order by ComponentCode), ComponentCode from Component
where ProductCode = @code

declare @cnt_total int = @@rowcount
DECLARE @cnt INT = 1;

WHILE @cnt < @cnt_total
BEGIN
   declare @num varchar(30) = (select Code from @Tree where number = @cnt)
   exec test @num
   SET @cnt = @cnt + 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateComponent]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateComponent]
@UpdatedCode varchar(30),
@Code varchar(30),
@Amount decimal(18,8),
@ProdCode varchar(30),
@CompCode varchar(30)
As
update Component
set
Code = @Code, Amount = @Amount, ProductCode = @ProdCode, ComponentCode = @CompCode
where Code = @UpdatedCode
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 06.10.2022 23:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateProduct]
@UpdatedCode VARCHAR(30),
@Code VARCHAR(30),
@Name VARCHAR(150),
@Unit VARCHAR(2)
AS
Update Product
Set Code = @Code, Name = @Name, Unit = @Unit
where Code = @UpdatedCode
GO
USE [master]
GO
ALTER DATABASE [Production] SET  READ_WRITE 
GO
