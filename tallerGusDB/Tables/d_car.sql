CREATE TABLE [dbo].[d_car]
(
	[carID]		INT				NOT NULL PRIMARY KEY IDENTITY,
	[make]		NVARCHAR(150)	NOT NULL,
	[model]		NVARCHAR(150)	NOT NULL,
	[year]		INT				NOT NULL,
	[doors]		INT				NOT NULL,
	[color]		NVARCHAR(150)	NOT NULL,
	[price]		INT				NOT NULL,
	[priceGuess] INT NULL

)
