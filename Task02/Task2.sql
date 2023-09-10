Use master
Create database Store

USE [Store]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[category_id] [int] NOT NULL,
	[category_name] [varchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[product_id] [int] NOT NULL,
	[product_name] [varchar](max) NULL,
	[category_id] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([category_id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO

--Данные таблица Category
INSERT INTO [dbo].[Category] ([category_id], [category_name]) VALUES
(1, 'Фрукты'),
(2, 'Овощи'),
(3, 'Молочная продукция'),
(4, 'Игрушки'),
(5, 'Мясо');
GO

--Данные таблица Products
INSERT INTO [dbo].[Products] ([product_id], [product_name], [category_id]) VALUES
(1, 'Бананы', 1),
(2, 'Апельсины', 1),
(3, 'Помидоры', 2),
(4, 'Конструктор', NULL),
(5, 'Молоко', 3),
(6, 'Перец', 2),
(7, 'Велосипед "Stels"', NULL),
(8, 'Кофемашина', NULL),
(9, 'Свинина охлажденная', 5);
GO

select Products.product_name, Category.category_name from Products left join Category on Products.category_id=Category.category_id