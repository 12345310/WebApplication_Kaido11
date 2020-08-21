CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Email] NCHAR(10) NULL, 
    [Birth] DATETIME NULL, 
    [Married] BIT NULL, 
    [Memo] NCHAR(10) NULL, 

)
