CREATE TABLE [dbo].[d_orderDetails]
(
	[orderDetailsID]	INT				NOT NULL PRIMARY KEY IDENTITY,
	[orderID]			INT				NOT NULL,
	[productNumber]		NVARCHAR(150)	NOT NULL,
	[productID]			INT				NOT NULL,
	[productOrigin]		INT				NOT NULL
)
