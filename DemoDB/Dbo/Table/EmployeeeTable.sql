CREATE TABLE [dbo].[EmployeeeTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAdress] NVARCHAR(50) NOT NULL, 
    [ConfirmEmail] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [ConfirmPassword] NVARCHAR(50) NOT NULL
)
