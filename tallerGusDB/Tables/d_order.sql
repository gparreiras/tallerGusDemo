CREATE TABLE [dbo].[d_order]
(
	[orderID]			INT				NOT NULL PRIMARY KEY IDENTITY,
	[personID]			INT				NOT NULL,
	[dateCreated]		DATETIME		NOT NULL,
	[methodOfPurchase]	NVARCHAR(150)	NOT NULL
)
