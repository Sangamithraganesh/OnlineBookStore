CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BookName] VARCHAR(256) NOT NULL, 
    [AuthorName] VARCHAR(256) NULL, 
    [BookCategory] VARCHAR(256) NOT NULL, 
    [Edition] VARCHAR(100) NULL, 
    [Price] DECIMAL(5, 3) NOT NULL
)
