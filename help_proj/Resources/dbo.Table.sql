CREATE TABLE [dbo].[Labor]
(
	[Id] INT NOT NULL , 
    [labor_name] NVARCHAR(100) NOT NULL, 
    [labor_phone]NVARCHAR (100) NOT NULL,
	[labor_job] NVARCHAR (50) NOT NULL,
	[labor_city] NVARCHAR (50) NOT NULL,
	[labor_email] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
);
