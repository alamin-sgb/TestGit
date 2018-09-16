USE [BookInfo]
GO
/****** Object:  Table [dbo].[product_tbl]    Script Date: 8/8/2018 11:56:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product_tbl](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[pcode] [varchar](50) NOT NULL,
	[pdescription] [varchar](50) NOT NULL,
	[pquantity] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
