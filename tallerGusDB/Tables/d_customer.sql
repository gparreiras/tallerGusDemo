CREATE TABLE [dbo].[d_customer]
(
	[personID]		INT				NOT NULL PRIMARY KEY IDENTITY,
	[firstName]		NVARCHAR(150)	NOT NULL,
	[lastName]		NVARCHAR(150)	NOT NULL,
	[age]			INT				NOT NULL,
	[occupation]	NVARCHAR(150)	NULL,
	[maritalStatus] NVARCHAR(10)	NULL
)
