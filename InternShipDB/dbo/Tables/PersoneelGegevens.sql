CREATE TABLE [dbo].[PersoneelGegevens]
(
	[PersoneelID] INT NOT NULL PRIMARY KEY, 
    [voornaam] NCHAR(10) NULL, 
    [achternaam] NCHAR(10) NULL, 
    [wachtwoord] VARCHAR(50) NULL
)
