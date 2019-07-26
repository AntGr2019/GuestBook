CREATE TABLE [dbo].[GuestbookEntries]
(
	[Id] INT IDENTITY (1,1) NOT NULL,
	[Name] Varchar (50) NOT NULL,
	[Message] Varchar (1000) NOT NULL,
	[DateAdded] DateTime NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
